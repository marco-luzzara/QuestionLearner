using QuestionLearner.Extensions;
using QuestionLearner.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Timers;
using QuestionLearner.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace QuestionLearner
{
    public partial class MainForm : Form
    {
        protected Queue<Question> questions;
        protected Question curQuestion;
        protected IDictionary<string, string> resources;
        protected System.Timers.Timer timerCorrectAnswer = new System.Timers.Timer();

        public MainForm()
        {
            InitializeComponent();

            this.timerCorrectAnswer.Interval = AppConfigManager.timeAfterCorrectAnswer;
            this.timerCorrectAnswer.Elapsed += new ElapsedEventHandler((obj, args) => LoadNextQuestionOnForm());
            this.timerCorrectAnswer.AutoReset = false;
            this.timerCorrectAnswer.Enabled = false;
        }

        private async Task LoadRecentQuestionnaires()
        {
            using (var fStream = new FileStream(AppConfigManager.recentFilePath, FileMode.OpenOrCreate, FileAccess.Read))
            using (var sr = new StreamReader(fStream))
            {
                string tempLine;

                while ((tempLine = await sr.ReadLineAsync().ConfigureAwait(false)) != null)
                {
                    var item = new ToolStripMenuItem();
                    item.Text = tempLine;
                    item.Click += new EventHandler(tsmItemRecentQuestionnaire_Click);

                    this.recentMenuItem.DropDownItems.Add(item);
                }
            }
        }

        private async void mainForm_Load(object sender, EventArgs e)
        {
            await LoadRecentQuestionnaires();
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createQuestionnaireMenuItem_Click(object sender, EventArgs e)
        {
            CreateQuestionnaireForm form = new CreateQuestionnaireForm();
            form.ShowDialog();
        }

        protected virtual IEnumerable<Question> GetNextQuestion()
        {
            if (this.questions.Count > 0)
            {
                var question = this.questions.Dequeue();
                this.questions.Enqueue(question);

                yield return question;
            }
            else
            {
                yield return null;
            }
        }

        protected virtual void LoadNextQuestionOnForm()
        {
            this.curQuestion = GetNextQuestion().First();

            this.lblQuestionText.Text = this.curQuestion.Text;
            this.pBoxImgDisplay.Image = this.curQuestion.Resource?.Image ?? null;
            this.lblCorrectAnswer.Visible = false;
            this.btnNextQuestion.Visible = false;
            //this.radioBtnTrue.Checked = false;
            //this.radioBtnFalse.Checked = false;
        }

        protected virtual void InitComponentForQuestionnaire()
        {
            this.lblQuestionText.Visible = true;
            this.pnlQuestion.Visible = true;
            this.pBoxImgDisplay.Visible = true;
            this.gBoxAnswers.Visible = true;
            this.btnNextQuestion.Visible = true;

            LoadNextQuestionOnForm();
        }



        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dlgOpenQuestionnaire.ShowDialog() == DialogResult.OK)
            {
                LoadQuestionnaire(this.dlgOpenQuestionnaire.FileName);


            }
        }

        private void LoadQuestionnaire(string fileName)
        {
            var questionnaireXml = XElement.Load(fileName);

            var questionsElems = questionnaireXml.XPathSelectElements("questions/question");
            var resourcesElems = questionnaireXml.XPathSelectElements("resources/resource");

            resources = resourcesElems.ToDictionary(
                elem => elem.Attribute("id").Value,
                elem => elem.Value
            );
            this.questions = new Queue<Question>(questionsElems.Select(elem => QuestionExtension.FromXml(elem, resources)));

            if (this.questions.Count > 0)
                InitComponentForQuestionnaire();
        }

        protected void ProcessAnswer(string givenAnswer)
        {
            this.lblCorrectAnswer.Visible = true;

            if (this.curQuestion.Answer.ToLower() == givenAnswer.ToLower())
            {
                this.lblCorrectAnswer.Text = "Correct answer";
                this.lblCorrectAnswer.ForeColor = Color.Green;

                this.timerCorrectAnswer.Start();
            }
            else
            {
                this.lblCorrectAnswer.Text = $"Wrong! The correct answer is: {this.curQuestion.Answer}";
                this.lblCorrectAnswer.ForeColor = Color.Black;
                this.btnNextQuestion.Visible = true;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            LoadNextQuestionOnForm();
        }

        private void radioBtnTrue_Click(object sender, EventArgs e)
        {
            ProcessAnswer("true");
        }

        private void radioBtnFalse_Click(object sender, EventArgs e)
        {
            ProcessAnswer("false");
        }

        private void tsmItemRecentQuestionnaire_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            LoadQuestionnaire(clickedItem.Text);
        }
    }
}

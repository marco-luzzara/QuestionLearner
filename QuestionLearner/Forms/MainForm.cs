using QuestionLearner.Extensions;
using QuestionLearner.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace QuestionLearner
{
    public partial class MainForm : Form
    {
        protected Queue<Question> questions;
        protected IDictionary<string, string> resources;

        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

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
            if (questions.Count > 0)
            {
                var question = questions.Dequeue();
                questions.Enqueue(question);

                yield return question;
            }
            else
            {
                yield return null;
            }
        }

        protected virtual void LoadQuestionOnForm()
        {
            var curQuestion = GetNextQuestion().First();

            this.lblQuestionText.Text = curQuestion.Text;
            this.pBoxImgDisplay.Image = curQuestion.Resource?.Image;
        }

        protected virtual void InitComponentForQuestionnaire()
        {
            this.lblQuestionText.Visible = true;
            this.pnlQuestion.Visible = true;
            this.pBoxImgDisplay.Visible = true;
            this.gBoxAnswers.Visible = true;
            this.radioBtnTrue.Visible = true;
            this.radioBtnFalse.Visible = true;

            LoadQuestionOnForm();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dlgOpenQuestionnaire.ShowDialog() == DialogResult.OK)
            {
                var filename = this.dlgOpenQuestionnaire.FileName;
                var questionnaireXml = XElement.Load(filename);

                var questionsElems = questionnaireXml.XPathSelectElements("questions/question");
                var resourcesElems = questionnaireXml.XPathSelectElements("resources/resource");

                resources = resourcesElems.ToDictionary(
                    elem => elem.Attribute("id").Value,
                    elem => elem.Value
                );
                questions = new Queue<Question>(questionsElems.Select(elem => QuestionExtension.FromXml(elem, resources)));

                if (questions.Count > 0)
                    InitComponentForQuestionnaire();
            }
        }
    }
}

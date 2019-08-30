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

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dlgOpenQuestionnaire.ShowDialog() == DialogResult.OK)
            {
                var filename = this.dlgOpenQuestionnaire.FileName;
                var questionnaireXml = XElement.Load(filename);

                var questionsElems = questionnaireXml.XPathSelectElements("questions/question");
                var resourcesElems = questionnaireXml.XPathSelectElements("resources/resource");

                IDictionary<string, string> resources = resourcesElems.ToDictionary(
                    elem => elem.Attribute("id").Value,
                    elem => elem.Value
                );
                IEnumerable<Question> questions = questionsElems.Select(elem => QuestionExtension.FromXml(elem, resources));
            }
        }
    }
}

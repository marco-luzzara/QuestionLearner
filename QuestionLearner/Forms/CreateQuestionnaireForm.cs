using QuestionLearner.Configuration;
using QuestionLearner.Forms;
using QuestionLearner.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuestionLearner
{
    public partial class CreateQuestionnaireForm : Form
    {
        protected MainForm.MainFormAccess formAccess;
        public ListBox ResourceListBox
        {
            get
            {
                return this.resourcesListBox;
            }
        }

        public CreateQuestionnaireForm(MainForm.MainFormAccess formAccess)
        {
            InitializeComponent();
            this.formAccess = formAccess;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionForm form = new AddQuestionForm(this);
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.questionsListBox.Items.Add(form.Question);
            }
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            dlgOpenResource.ShowDialog();
        }

        private void dlgOpenResource_FileOk(object sender, CancelEventArgs e)
        {
            if (this.dlgOpenResource.FileNames != null)
            {
                string[] filenames = this.dlgOpenResource.FileNames;
                ImageFile[] imageFiles = filenames.Select(fn => new ImageFile(fn)).ToArray();

                this.resourcesListBox.Items.AddRange(imageFiles);
            }
        }

        private void resourcesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.resourcesListBox.SelectedIndex != -1)
            {
                this.pboxResourceDisplay.Image = ((ImageFile) this.resourcesListBox.SelectedItem).Image;
            }
        }

        private int? GetResourceIdAndAddIfNecessary(ImageFile imgFile, IDictionary<ImageFile, int> currentImgFiles)
        {
            if (imgFile == null)
                return null;

            int resourceId;
            if (!currentImgFiles.TryGetValue(imgFile, out resourceId))
            {
                resourceId = currentImgFiles.Count;
                currentImgFiles.Add(imgFile, resourceId);
            }

            return resourceId;
        }

        protected virtual XElement CreateXmlFromQuestions()
        {
            XElement root = new XElement("questionnaire");

            // <questions>
            IDictionary<ImageFile, int> storedResources = new Dictionary<ImageFile, int>();

            XElement questionsTag = new XElement("questions");
            var questionElems = this.questionsListBox.Items
                .Cast<Question>()
                .Select(q => new XElement("question",
                    new XElement("text", q.Text),
                    new XElement("answer", q.Answer),
                    new XElement("resource", GetResourceIdAndAddIfNecessary(q.Resource, storedResources)?.ToString() ?? "null"))
                );

            questionsTag.Add(questionElems.ToArray<object>());
            // </questions>

            // <resources>
            XElement resourcesTag = new XElement("resources");
            resourcesTag.Add(storedResources
                .Select(entry => new XElement("resource",
                    new XAttribute("id", entry.Value),
                    entry.Key.FilePath))
                .ToArray<object>()
            );
            // </resources>

            root.Add(questionsTag);
            root.Add(resourcesTag);

            return root;
        }
        
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var xml = CreateXmlFromQuestions();

            if (this.dlgSaveQuestions.ShowDialog() == DialogResult.OK)
            {
                using (Stream xmlStream = this.dlgSaveQuestions.OpenFile())
                {
                    var fileName = this.dlgSaveQuestions.FileName;

                    if (fileName != "")
                    {
                        xml.Save(xmlStream);

                        using (var fStream = new FileStream(AppConfigManager.recentFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                        {
                            await Utils.AddToRecentQuestionnairesIfOut(fStream, fileName);
                        }

                        await this.formAccess.LoadRecentQuestionnaires();
                    }
                }
            }
        }
    }
}

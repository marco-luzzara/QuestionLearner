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

namespace QuestionLearner
{
    public partial class CreateQuestionnaireForm : Form
    {
        public ListBox ResourceListBox
        {
            get
            {
                return this.resourcesListBox;
            }
        }

        public CreateQuestionnaireForm()
        {
            InitializeComponent();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestionForm form = new AddQuestionForm(this);
            form.ShowDialog();
        }

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            dlgOpenResource.ShowDialog();
        }

        private void dlgOpenResource_FileOk(object sender, CancelEventArgs e)
        {
            string[] filenames = this.dlgOpenResource.FileNames;
            ImageFile[] imageFiles = filenames.Select(fn => new ImageFile(fn)).ToArray();

            this.resourcesListBox.Items.AddRange(imageFiles);
        }
    }
}

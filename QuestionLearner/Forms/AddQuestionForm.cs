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
    public partial class AddQuestionForm : Form
    {
        private CreateQuestionnaireForm _callingForm;
        private Question _question;

        public Question Question
        {
            get
            {
                return _question;
            }
        }

        public AddQuestionForm(CreateQuestionnaireForm callingForm)
        {
            InitializeComponent();
            this._callingForm = callingForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool @checked = groupBoxAnswer.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked).Checked;

            _question = new Question(this.txtBoxQuestion.Text, @checked ? "true" : "false");
            _question.Resource = this.listBoxResources.SelectedIndex != -1 ? (ImageFile) this.listBoxResources.SelectedItem : null;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            listBoxResources.Items.AddRange(_callingForm.ResourceListBox.Items);
        }
    }
}

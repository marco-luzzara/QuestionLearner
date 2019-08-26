namespace QuestionLearner
{
    partial class AddQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.radioBtnTrue = new System.Windows.Forms.RadioButton();
            this.radioBtnFalse = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBoxResources = new System.Windows.Forms.ListBox();
            this.lblResources = new System.Windows.Forms.Label();
            this.groupBoxAnswer = new System.Windows.Forms.GroupBox();
            this.groupBoxAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxQuestion
            // 
            this.txtBoxQuestion.Location = new System.Drawing.Point(13, 33);
            this.txtBoxQuestion.Multiline = true;
            this.txtBoxQuestion.Name = "txtBoxQuestion";
            this.txtBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxQuestion.Size = new System.Drawing.Size(559, 87);
            this.txtBoxQuestion.TabIndex = 0;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(13, 14);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(49, 13);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Question";
            // 
            // radioBtnTrue
            // 
            this.radioBtnTrue.AutoSize = true;
            this.radioBtnTrue.Checked = true;
            this.radioBtnTrue.Location = new System.Drawing.Point(6, 22);
            this.radioBtnTrue.Name = "radioBtnTrue";
            this.radioBtnTrue.Size = new System.Drawing.Size(47, 17);
            this.radioBtnTrue.TabIndex = 3;
            this.radioBtnTrue.TabStop = true;
            this.radioBtnTrue.Text = "True";
            this.radioBtnTrue.UseVisualStyleBackColor = true;
            // 
            // radioBtnFalse
            // 
            this.radioBtnFalse.AutoSize = true;
            this.radioBtnFalse.Location = new System.Drawing.Point(98, 22);
            this.radioBtnFalse.Name = "radioBtnFalse";
            this.radioBtnFalse.Size = new System.Drawing.Size(50, 17);
            this.radioBtnFalse.TabIndex = 4;
            this.radioBtnFalse.TabStop = true;
            this.radioBtnFalse.Text = "False";
            this.radioBtnFalse.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(478, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listBoxResources
            // 
            this.listBoxResources.FormattingEnabled = true;
            this.listBoxResources.Location = new System.Drawing.Point(13, 224);
            this.listBoxResources.Name = "listBoxResources";
            this.listBoxResources.Size = new System.Drawing.Size(559, 186);
            this.listBoxResources.TabIndex = 7;
            this.listBoxResources.DisplayMember = "FileName";
            this.listBoxResources.ValueMember = "Image";
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Location = new System.Drawing.Point(16, 205);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(58, 13);
            this.lblResources.TabIndex = 8;
            this.lblResources.Text = "Resources";
            // 
            // groupBoxAnswer
            // 
            this.groupBoxAnswer.Controls.Add(this.radioBtnFalse);
            this.groupBoxAnswer.Controls.Add(this.radioBtnTrue);
            this.groupBoxAnswer.Location = new System.Drawing.Point(13, 137);
            this.groupBoxAnswer.Name = "groupBoxAnswer";
            this.groupBoxAnswer.Size = new System.Drawing.Size(152, 55);
            this.groupBoxAnswer.TabIndex = 9;
            this.groupBoxAnswer.TabStop = false;
            this.groupBoxAnswer.Text = "Answer";
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 476);
            this.Controls.Add(this.groupBoxAnswer);
            this.Controls.Add(this.lblResources);
            this.Controls.Add(this.listBoxResources);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.txtBoxQuestion);
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            this.groupBoxAnswer.ResumeLayout(false);
            this.groupBoxAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxQuestion;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.RadioButton radioBtnTrue;
        private System.Windows.Forms.RadioButton radioBtnFalse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBoxResources;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.GroupBox groupBoxAnswer;
    }
}
namespace QuestionLearner
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuestionnaireMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenQuestionnaire = new System.Windows.Forms.OpenFileDialog();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.pBoxImgDisplay = new System.Windows.Forms.PictureBox();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.gBoxAnswer = new System.Windows.Forms.GroupBox();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.mainMenuStrip.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImgDisplay)).BeginInit();
            this.gBoxAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.toolsMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(744, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.recentMenuItem,
            this.closeMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // recentMenuItem
            // 
            this.recentMenuItem.Name = "recentMenuItem";
            this.recentMenuItem.Size = new System.Drawing.Size(110, 22);
            this.recentMenuItem.Text = "Recent";
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(110, 22);
            this.closeMenuItem.Text = "Close";
            this.closeMenuItem.Click += new System.EventHandler(this.closeMenuItem_Click);
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQuestionnaireMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsMenuItem.Text = "Tools";
            // 
            // createQuestionnaireMenuItem
            // 
            this.createQuestionnaireMenuItem.Name = "createQuestionnaireMenuItem";
            this.createQuestionnaireMenuItem.Size = new System.Drawing.Size(185, 22);
            this.createQuestionnaireMenuItem.Text = "Create Questionnaire";
            this.createQuestionnaireMenuItem.Click += new System.EventHandler(this.createQuestionnaireMenuItem_Click);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(3, 3);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(75, 17);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Test Label";
            this.lblQuestionText.Visible = false;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.AutoScroll = true;
            this.pnlQuestion.Controls.Add(this.lblQuestionText);
            this.pnlQuestion.Location = new System.Drawing.Point(21, 41);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(437, 155);
            this.pnlQuestion.TabIndex = 2;
            this.pnlQuestion.Visible = false;
            // 
            // pBoxImgDisplay
            // 
            this.pBoxImgDisplay.Location = new System.Drawing.Point(21, 213);
            this.pBoxImgDisplay.Name = "pBoxImgDisplay";
            this.pBoxImgDisplay.Size = new System.Drawing.Size(701, 384);
            this.pBoxImgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxImgDisplay.TabIndex = 4;
            this.pBoxImgDisplay.TabStop = false;
            this.pBoxImgDisplay.Visible = false;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(523, 148);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(44, 17);
            this.lblCorrectAnswer.TabIndex = 2;
            this.lblCorrectAnswer.Text = "prova";
            this.lblCorrectAnswer.Visible = false;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(657, 63);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 34);
            this.btnNextQuestion.TabIndex = 5;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Visible = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // gBoxAnswer
            // 
            this.gBoxAnswer.Controls.Add(this.rbFalse);
            this.gBoxAnswer.Controls.Add(this.rbTrue);
            this.gBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxAnswer.Location = new System.Drawing.Point(480, 44);
            this.gBoxAnswer.Name = "gBoxAnswer";
            this.gBoxAnswer.Size = new System.Drawing.Size(153, 84);
            this.gBoxAnswer.TabIndex = 6;
            this.gBoxAnswer.TabStop = false;
            this.gBoxAnswer.Text = "Your Answer";
            this.gBoxAnswer.Visible = false;
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFalse.Location = new System.Drawing.Point(9, 53);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(60, 21);
            this.rbFalse.TabIndex = 1;
            this.rbFalse.TabStop = false;
            this.rbFalse.Text = "False";
            this.rbFalse.UseVisualStyleBackColor = true;
            this.rbFalse.Click += new System.EventHandler(this.rbFalse_Click);
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTrue.Location = new System.Drawing.Point(9, 26);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(56, 21);
            this.rbTrue.TabIndex = 0;
            this.rbTrue.TabStop = false;
            this.rbTrue.Text = "True";
            this.rbTrue.UseVisualStyleBackColor = true;
            this.rbTrue.Click += new System.EventHandler(this.rbTrue_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 617);
            this.Controls.Add(this.gBoxAnswer);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.pBoxImgDisplay);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "QuestionLearner";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImgDisplay)).EndInit();
            this.gBoxAnswer.ResumeLayout(false);
            this.gBoxAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createQuestionnaireMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOpenQuestionnaire;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.PictureBox pBoxImgDisplay;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.GroupBox gBoxAnswer;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
    }
}


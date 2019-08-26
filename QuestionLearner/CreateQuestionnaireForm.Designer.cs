﻿namespace QuestionLearner
{
    partial class CreateQuestionnaireForm
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
            this.components = new System.ComponentModel.Container();
            this.questionsPanel = new System.Windows.Forms.Panel();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.resourcePanel = new System.Windows.Forms.Panel();
            this.resourcesListBox = new System.Windows.Forms.ListBox();
            this.imgDisplayPanel = new System.Windows.Forms.Panel();
            this.lblResources = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.btnRemoveResource = new System.Windows.Forms.Button();
            this.btnAddResource = new System.Windows.Forms.Button();
            this.questionsListBox = new System.Windows.Forms.ListBox();
            this.questionsPanel.SuspendLayout();
            this.resourcePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionsPanel
            // 
            this.questionsPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.questionsPanel.Controls.Add(this.questionsListBox);
            this.questionsPanel.Controls.Add(this.btnRemoveQuestion);
            this.questionsPanel.Controls.Add(this.btnAddQuestion);
            this.questionsPanel.Controls.Add(this.lblQuestions);
            this.questionsPanel.Location = new System.Drawing.Point(12, 12);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(367, 521);
            this.questionsPanel.TabIndex = 0;
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.Location = new System.Drawing.Point(3, 4);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(72, 17);
            this.lblQuestions.TabIndex = 0;
            this.lblQuestions.Text = "Questions";
            // 
            // resourcePanel
            // 
            this.resourcePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resourcePanel.Controls.Add(this.btnRemoveResource);
            this.resourcePanel.Controls.Add(this.btnAddResource);
            this.resourcePanel.Controls.Add(this.resourcesListBox);
            this.resourcePanel.Controls.Add(this.imgDisplayPanel);
            this.resourcePanel.Controls.Add(this.lblResources);
            this.resourcePanel.Location = new System.Drawing.Point(433, 12);
            this.resourcePanel.Name = "resourcePanel";
            this.resourcePanel.Size = new System.Drawing.Size(367, 521);
            this.resourcePanel.TabIndex = 0;
            // 
            // resourcesListBox
            // 
            this.resourcesListBox.FormattingEnabled = true;
            this.resourcesListBox.Location = new System.Drawing.Point(3, 37);
            this.resourcesListBox.Name = "resourcesListBox";
            this.resourcesListBox.Size = new System.Drawing.Size(361, 290);
            this.resourcesListBox.TabIndex = 2;
            // 
            // imgDisplayPanel
            // 
            this.imgDisplayPanel.Location = new System.Drawing.Point(3, 333);
            this.imgDisplayPanel.Name = "imgDisplayPanel";
            this.imgDisplayPanel.Size = new System.Drawing.Size(361, 185);
            this.imgDisplayPanel.TabIndex = 1;
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResources.Location = new System.Drawing.Point(4, 4);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(76, 17);
            this.lblResources.TabIndex = 0;
            this.lblResources.Text = "Resources";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(715, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(611, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(157, 4);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Location = new System.Drawing.Point(253, 4);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveQuestion.TabIndex = 2;
            this.btnRemoveQuestion.Text = "Remove";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // btnRemoveResource
            // 
            this.btnRemoveResource.Location = new System.Drawing.Point(253, 4);
            this.btnRemoveResource.Name = "btnRemoveResource";
            this.btnRemoveResource.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveResource.TabIndex = 4;
            this.btnRemoveResource.Text = "Remove";
            this.btnRemoveResource.UseVisualStyleBackColor = true;
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(159, 4);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(75, 23);
            this.btnAddResource.TabIndex = 3;
            this.btnAddResource.Text = "Add";
            this.btnAddResource.UseVisualStyleBackColor = true;
            // 
            // questionsListBox
            // 
            this.questionsListBox.FormattingEnabled = true;
            this.questionsListBox.Location = new System.Drawing.Point(3, 37);
            this.questionsListBox.Name = "questionsListBox";
            this.questionsListBox.Size = new System.Drawing.Size(361, 472);
            this.questionsListBox.TabIndex = 5;
            // 
            // CreateQuestionnaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 595);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.resourcePanel);
            this.Controls.Add(this.questionsPanel);
            this.Name = "CreateQuestionnaireForm";
            this.Text = "CreateQuestionnaireForm";
            this.questionsPanel.ResumeLayout(false);
            this.questionsPanel.PerformLayout();
            this.resourcePanel.ResumeLayout(false);
            this.resourcePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel questionsPanel;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Panel resourcePanel;
        private System.Windows.Forms.ListBox resourcesListBox;
        private System.Windows.Forms.Panel imgDisplayPanel;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox questionsListBox;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnRemoveResource;
        private System.Windows.Forms.Button btnAddResource;
    }
}
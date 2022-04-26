namespace MusicProject.Views
{
    partial class AddRecordLabelView
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
            this.uxAddRLButton = new System.Windows.Forms.Button();
            this.uxRLNameText = new System.Windows.Forms.Label();
            this.uxRlNText = new System.Windows.Forms.TextBox();
            this.uxFoundLabel = new System.Windows.Forms.Label();
            this.uxEndLabel = new System.Windows.Forms.Label();
            this.uxLocationText = new System.Windows.Forms.TextBox();
            this.uxLocationLabel = new System.Windows.Forms.Label();
            this.uxDateFoundedInfo = new System.Windows.Forms.MonthCalendar();
            this.uxDateEndInfo = new System.Windows.Forms.MonthCalendar();
            this.uxQuestion = new System.Windows.Forms.Label();
            this.uxCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uxAddRLButton
            // 
            this.uxAddRLButton.Location = new System.Drawing.Point(267, 372);
            this.uxAddRLButton.Name = "uxAddRLButton";
            this.uxAddRLButton.Size = new System.Drawing.Size(168, 23);
            this.uxAddRLButton.TabIndex = 0;
            this.uxAddRLButton.Text = "Add Record Label";
            this.uxAddRLButton.UseVisualStyleBackColor = true;
            // 
            // uxRLNameText
            // 
            this.uxRLNameText.AutoSize = true;
            this.uxRLNameText.Location = new System.Drawing.Point(16, 77);
            this.uxRLNameText.Name = "uxRLNameText";
            this.uxRLNameText.Size = new System.Drawing.Size(105, 13);
            this.uxRLNameText.TabIndex = 1;
            this.uxRLNameText.Text = "Record Label Name:";
            // 
            // uxRlNText
            // 
            this.uxRlNText.Location = new System.Drawing.Point(127, 77);
            this.uxRlNText.Name = "uxRlNText";
            this.uxRlNText.Size = new System.Drawing.Size(252, 20);
            this.uxRlNText.TabIndex = 2;
            // 
            // uxFoundLabel
            // 
            this.uxFoundLabel.AutoSize = true;
            this.uxFoundLabel.Location = new System.Drawing.Point(16, 109);
            this.uxFoundLabel.Name = "uxFoundLabel";
            this.uxFoundLabel.Size = new System.Drawing.Size(52, 13);
            this.uxFoundLabel.TabIndex = 3;
            this.uxFoundLabel.Text = "Founded:";
            // 
            // uxEndLabel
            // 
            this.uxEndLabel.AutoSize = true;
            this.uxEndLabel.Location = new System.Drawing.Point(340, 109);
            this.uxEndLabel.Name = "uxEndLabel";
            this.uxEndLabel.Size = new System.Drawing.Size(70, 13);
            this.uxEndLabel.TabIndex = 5;
            this.uxEndLabel.Text = "Date Ended: ";
            // 
            // uxLocationText
            // 
            this.uxLocationText.Location = new System.Drawing.Point(127, 332);
            this.uxLocationText.Name = "uxLocationText";
            this.uxLocationText.Size = new System.Drawing.Size(464, 20);
            this.uxLocationText.TabIndex = 8;
            // 
            // uxLocationLabel
            // 
            this.uxLocationLabel.AutoSize = true;
            this.uxLocationLabel.Location = new System.Drawing.Point(60, 332);
            this.uxLocationLabel.Name = "uxLocationLabel";
            this.uxLocationLabel.Size = new System.Drawing.Size(51, 13);
            this.uxLocationLabel.TabIndex = 7;
            this.uxLocationLabel.Text = "Location:";
            // 
            // uxDateFoundedInfo
            // 
            this.uxDateFoundedInfo.Location = new System.Drawing.Point(80, 109);
            this.uxDateFoundedInfo.Name = "uxDateFoundedInfo";
            this.uxDateFoundedInfo.TabIndex = 9;
            // 
            // uxDateEndInfo
            // 
            this.uxDateEndInfo.Enabled = false;
            this.uxDateEndInfo.Location = new System.Drawing.Point(422, 109);
            this.uxDateEndInfo.Name = "uxDateEndInfo";
            this.uxDateEndInfo.TabIndex = 10;
            // 
            // uxQuestion
            // 
            this.uxQuestion.AutoSize = true;
            this.uxQuestion.Location = new System.Drawing.Point(419, 48);
            this.uxQuestion.Name = "uxQuestion";
            this.uxQuestion.Size = new System.Drawing.Size(155, 13);
            this.uxQuestion.TabIndex = 11;
            this.uxQuestion.Text = "Has The Record Label Ended?";
            // 
            // uxCheckBox
            // 
            this.uxCheckBox.AutoSize = true;
            this.uxCheckBox.Location = new System.Drawing.Point(422, 76);
            this.uxCheckBox.Name = "uxCheckBox";
            this.uxCheckBox.Size = new System.Drawing.Size(129, 17);
            this.uxCheckBox.TabIndex = 12;
            this.uxCheckBox.Text = "If Yes, Check the Box";
            this.uxCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddRecordLabelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.uxCheckBox);
            this.Controls.Add(this.uxQuestion);
            this.Controls.Add(this.uxDateEndInfo);
            this.Controls.Add(this.uxDateFoundedInfo);
            this.Controls.Add(this.uxLocationText);
            this.Controls.Add(this.uxLocationLabel);
            this.Controls.Add(this.uxEndLabel);
            this.Controls.Add(this.uxFoundLabel);
            this.Controls.Add(this.uxRlNText);
            this.Controls.Add(this.uxRLNameText);
            this.Controls.Add(this.uxAddRLButton);
            this.Name = "AddRecordLabelView";
            this.Text = "AddView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddRLButton;
        private System.Windows.Forms.Label uxRLNameText;
        private System.Windows.Forms.TextBox uxRlNText;
        private System.Windows.Forms.Label uxFoundLabel;
        private System.Windows.Forms.Label uxEndLabel;
        private System.Windows.Forms.TextBox uxLocationText;
        private System.Windows.Forms.Label uxLocationLabel;
        private System.Windows.Forms.MonthCalendar uxDateFoundedInfo;
        private System.Windows.Forms.MonthCalendar uxDateEndInfo;
        private System.Windows.Forms.Label uxQuestion;
        private System.Windows.Forms.CheckBox uxCheckBox;
    }
}
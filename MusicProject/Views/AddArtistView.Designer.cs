namespace MusicProject.Views
{
    partial class AddArtistView
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
            this.uxAddPersonButton = new System.Windows.Forms.Button();
            this.uxPersonNameText = new System.Windows.Forms.Label();
            this.uxPNText = new System.Windows.Forms.TextBox();
            this.uxBornLabel = new System.Windows.Forms.Label();
            this.uxDeadLabel = new System.Windows.Forms.Label();
            this.uxHRText = new System.Windows.Forms.TextBox();
            this.uxHRLabel = new System.Windows.Forms.Label();
            this.uxDateFoundedInfo = new System.Windows.Forms.MonthCalendar();
            this.uxDateDeadInfo = new System.Windows.Forms.MonthCalendar();
            this.uxQuestion = new System.Windows.Forms.Label();
            this.uxCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uxAddPersonButton
            // 
            this.uxAddPersonButton.Location = new System.Drawing.Point(267, 372);
            this.uxAddPersonButton.Name = "uxAddPersonButton";
            this.uxAddPersonButton.Size = new System.Drawing.Size(168, 23);
            this.uxAddPersonButton.TabIndex = 0;
            this.uxAddPersonButton.Text = "Add Person";
            this.uxAddPersonButton.UseVisualStyleBackColor = true;
            // 
            // uxPersonNameText
            // 
            this.uxPersonNameText.AutoSize = true;
            this.uxPersonNameText.Location = new System.Drawing.Point(16, 77);
            this.uxPersonNameText.Name = "uxPersonNameText";
            this.uxPersonNameText.Size = new System.Drawing.Size(74, 13);
            this.uxPersonNameText.TabIndex = 1;
            this.uxPersonNameText.Text = "Person Name:";
            // 
            // uxPNText
            // 
            this.uxPNText.Location = new System.Drawing.Point(127, 77);
            this.uxPNText.Name = "uxPNText";
            this.uxPNText.Size = new System.Drawing.Size(252, 20);
            this.uxPNText.TabIndex = 2;
            // 
            // uxBornLabel
            // 
            this.uxBornLabel.AutoSize = true;
            this.uxBornLabel.Location = new System.Drawing.Point(16, 109);
            this.uxBornLabel.Name = "uxBornLabel";
            this.uxBornLabel.Size = new System.Drawing.Size(32, 13);
            this.uxBornLabel.TabIndex = 3;
            this.uxBornLabel.Text = "Born:";
            // 
            // uxDeadLabel
            // 
            this.uxDeadLabel.AutoSize = true;
            this.uxDeadLabel.Location = new System.Drawing.Point(340, 109);
            this.uxDeadLabel.Name = "uxDeadLabel";
            this.uxDeadLabel.Size = new System.Drawing.Size(70, 13);
            this.uxDeadLabel.TabIndex = 5;
            this.uxDeadLabel.Text = "Date Ended: ";
            // 
            // uxHRText
            // 
            this.uxHRText.Location = new System.Drawing.Point(127, 332);
            this.uxHRText.Name = "uxHRText";
            this.uxHRText.Size = new System.Drawing.Size(464, 20);
            this.uxHRText.TabIndex = 8;
            // 
            // uxHRLabel
            // 
            this.uxHRLabel.AutoSize = true;
            this.uxHRLabel.Location = new System.Drawing.Point(46, 332);
            this.uxHRLabel.Name = "uxHRLabel";
            this.uxHRLabel.Size = new System.Drawing.Size(75, 13);
            this.uxHRLabel.TabIndex = 7;
            this.uxHRLabel.Text = "Home Region:";
            // 
            // uxDateFoundedInfo
            // 
            this.uxDateFoundedInfo.Location = new System.Drawing.Point(80, 109);
            this.uxDateFoundedInfo.Name = "uxDateFoundedInfo";
            this.uxDateFoundedInfo.TabIndex = 9;
            // 
            // uxDateDeadInfo
            // 
            this.uxDateDeadInfo.Enabled = false;
            this.uxDateDeadInfo.Location = new System.Drawing.Point(422, 109);
            this.uxDateDeadInfo.Name = "uxDateDeadInfo";
            this.uxDateDeadInfo.TabIndex = 10;
            // 
            // uxQuestion
            // 
            this.uxQuestion.AutoSize = true;
            this.uxQuestion.Location = new System.Drawing.Point(419, 48);
            this.uxQuestion.Name = "uxQuestion";
            this.uxQuestion.Size = new System.Drawing.Size(56, 13);
            this.uxQuestion.TabIndex = 11;
            this.uxQuestion.Text = "He Dead?";
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
            // AddPersonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.uxCheckBox);
            this.Controls.Add(this.uxQuestion);
            this.Controls.Add(this.uxDateDeadInfo);
            this.Controls.Add(this.uxDateFoundedInfo);
            this.Controls.Add(this.uxHRText);
            this.Controls.Add(this.uxHRLabel);
            this.Controls.Add(this.uxDeadLabel);
            this.Controls.Add(this.uxBornLabel);
            this.Controls.Add(this.uxPNText);
            this.Controls.Add(this.uxPersonNameText);
            this.Controls.Add(this.uxAddPersonButton);
            this.Name = "AddPersonView";
            this.Text = "AddView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddPersonButton;
        private System.Windows.Forms.Label uxPersonNameText;
        private System.Windows.Forms.TextBox uxPNText;
        private System.Windows.Forms.Label uxBornLabel;
        private System.Windows.Forms.Label uxDeadLabel;
        private System.Windows.Forms.TextBox uxHRText;
        private System.Windows.Forms.Label uxHRLabel;
        private System.Windows.Forms.MonthCalendar uxDateFoundedInfo;
        private System.Windows.Forms.MonthCalendar uxDateDeadInfo;
        private System.Windows.Forms.Label uxQuestion;
        private System.Windows.Forms.CheckBox uxCheckBox;
    }
}
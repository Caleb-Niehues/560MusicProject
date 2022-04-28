
namespace MusicProject.Views
{
    partial class AddPersonView
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
            this.uxCheckBox = new System.Windows.Forms.CheckBox();
            this.uxQuestion = new System.Windows.Forms.Label();
            this.uxDateDeadInfo = new System.Windows.Forms.MonthCalendar();
            this.uxDateFoundedInfo = new System.Windows.Forms.MonthCalendar();
            this.uxHRText = new System.Windows.Forms.TextBox();
            this.uxHRLabel = new System.Windows.Forms.Label();
            this.uxDeadLabel = new System.Windows.Forms.Label();
            this.uxBornLabel = new System.Windows.Forms.Label();
            this.uxPNText = new System.Windows.Forms.TextBox();
            this.uxPersonNameText = new System.Windows.Forms.Label();
            this.uxAddPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxCheckBox
            // 
            this.uxCheckBox.AutoSize = true;
            this.uxCheckBox.Location = new System.Drawing.Point(540, 47);
            this.uxCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxCheckBox.Name = "uxCheckBox";
            this.uxCheckBox.Size = new System.Drawing.Size(163, 21);
            this.uxCheckBox.TabIndex = 23;
            this.uxCheckBox.Text = "If Yes, Check the Box";
            this.uxCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxQuestion
            // 
            this.uxQuestion.AutoSize = true;
            this.uxQuestion.Location = new System.Drawing.Point(536, 12);
            this.uxQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxQuestion.Name = "uxQuestion";
            this.uxQuestion.Size = new System.Drawing.Size(72, 17);
            this.uxQuestion.TabIndex = 22;
            this.uxQuestion.Text = "He Dead?";
            // 
            // uxDateDeadInfo
            // 
            this.uxDateDeadInfo.Enabled = false;
            this.uxDateDeadInfo.Location = new System.Drawing.Point(540, 87);
            this.uxDateDeadInfo.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.uxDateDeadInfo.Name = "uxDateDeadInfo";
            this.uxDateDeadInfo.TabIndex = 21;
            // 
            // uxDateFoundedInfo
            // 
            this.uxDateFoundedInfo.Location = new System.Drawing.Point(84, 87);
            this.uxDateFoundedInfo.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.uxDateFoundedInfo.Name = "uxDateFoundedInfo";
            this.uxDateFoundedInfo.TabIndex = 20;
            // 
            // uxHRText
            // 
            this.uxHRText.Location = new System.Drawing.Point(146, 362);
            this.uxHRText.Margin = new System.Windows.Forms.Padding(4);
            this.uxHRText.Name = "uxHRText";
            this.uxHRText.Size = new System.Drawing.Size(617, 22);
            this.uxHRText.TabIndex = 19;
            // 
            // uxHRLabel
            // 
            this.uxHRLabel.AutoSize = true;
            this.uxHRLabel.Location = new System.Drawing.Point(38, 362);
            this.uxHRLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxHRLabel.Name = "uxHRLabel";
            this.uxHRLabel.Size = new System.Drawing.Size(98, 17);
            this.uxHRLabel.TabIndex = 18;
            this.uxHRLabel.Text = "Home Region:";
            // 
            // uxDeadLabel
            // 
            this.uxDeadLabel.AutoSize = true;
            this.uxDeadLabel.Location = new System.Drawing.Point(430, 87);
            this.uxDeadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxDeadLabel.Name = "uxDeadLabel";
            this.uxDeadLabel.Size = new System.Drawing.Size(91, 17);
            this.uxDeadLabel.TabIndex = 17;
            this.uxDeadLabel.Text = "Date Ended: ";
            // 
            // uxBornLabel
            // 
            this.uxBornLabel.AutoSize = true;
            this.uxBornLabel.Location = new System.Drawing.Point(-2, 87);
            this.uxBornLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxBornLabel.Name = "uxBornLabel";
            this.uxBornLabel.Size = new System.Drawing.Size(42, 17);
            this.uxBornLabel.TabIndex = 16;
            this.uxBornLabel.Text = "Born:";
            // 
            // uxPNText
            // 
            this.uxPNText.Location = new System.Drawing.Point(146, 48);
            this.uxPNText.Margin = new System.Windows.Forms.Padding(4);
            this.uxPNText.Name = "uxPNText";
            this.uxPNText.Size = new System.Drawing.Size(335, 22);
            this.uxPNText.TabIndex = 15;
            // 
            // uxPersonNameText
            // 
            this.uxPersonNameText.AutoSize = true;
            this.uxPersonNameText.Location = new System.Drawing.Point(-2, 48);
            this.uxPersonNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPersonNameText.Name = "uxPersonNameText";
            this.uxPersonNameText.Size = new System.Drawing.Size(98, 17);
            this.uxPersonNameText.TabIndex = 14;
            this.uxPersonNameText.Text = "Person Name:";
            // 
            // uxAddPersonButton
            // 
            this.uxAddPersonButton.Location = new System.Drawing.Point(333, 411);
            this.uxAddPersonButton.Margin = new System.Windows.Forms.Padding(4);
            this.uxAddPersonButton.Name = "uxAddPersonButton";
            this.uxAddPersonButton.Size = new System.Drawing.Size(224, 28);
            this.uxAddPersonButton.TabIndex = 13;
            this.uxAddPersonButton.Text = "Add Person";
            this.uxAddPersonButton.UseVisualStyleBackColor = true;
            // 
            // AddPersonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "AddPersonView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox uxCheckBox;
        private System.Windows.Forms.Label uxQuestion;
        private System.Windows.Forms.MonthCalendar uxDateDeadInfo;
        private System.Windows.Forms.MonthCalendar uxDateFoundedInfo;
        private System.Windows.Forms.TextBox uxHRText;
        private System.Windows.Forms.Label uxHRLabel;
        private System.Windows.Forms.Label uxDeadLabel;
        private System.Windows.Forms.Label uxBornLabel;
        private System.Windows.Forms.TextBox uxPNText;
        private System.Windows.Forms.Label uxPersonNameText;
        private System.Windows.Forms.Button uxAddPersonButton;
    }
}
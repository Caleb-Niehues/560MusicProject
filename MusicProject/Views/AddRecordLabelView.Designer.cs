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
            this.uxNameText = new System.Windows.Forms.TextBox();
            this.uxFoundLabel = new System.Windows.Forms.Label();
            this.uxEndLabel = new System.Windows.Forms.Label();
            this.uxLocationText = new System.Windows.Forms.TextBox();
            this.uxLocationLabel = new System.Windows.Forms.Label();
            this.uxEndedCheck = new System.Windows.Forms.CheckBox();
            this.uxFoundedDate = new System.Windows.Forms.DateTimePicker();
            this.uxEndedDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uxAddRLButton
            // 
            this.uxAddRLButton.Location = new System.Drawing.Point(133, 179);
            this.uxAddRLButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxAddRLButton.Name = "uxAddRLButton";
            this.uxAddRLButton.Size = new System.Drawing.Size(224, 28);
            this.uxAddRLButton.TabIndex = 0;
            this.uxAddRLButton.Text = "Add Record Label";
            this.uxAddRLButton.UseVisualStyleBackColor = true;
            this.uxAddRLButton.Click += new System.EventHandler(this.uxAddRLButton_Click);
            // 
            // uxRLNameText
            // 
            this.uxRLNameText.AutoSize = true;
            this.uxRLNameText.Location = new System.Drawing.Point(11, 26);
            this.uxRLNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxRLNameText.Name = "uxRLNameText";
            this.uxRLNameText.Size = new System.Drawing.Size(138, 17);
            this.uxRLNameText.TabIndex = 1;
            this.uxRLNameText.Text = "Record Label Name:";
            // 
            // uxNameText
            // 
            this.uxNameText.Location = new System.Drawing.Point(159, 26);
            this.uxNameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxNameText.Name = "uxNameText";
            this.uxNameText.Size = new System.Drawing.Size(335, 22);
            this.uxNameText.TabIndex = 2;
            // 
            // uxFoundLabel
            // 
            this.uxFoundLabel.AutoSize = true;
            this.uxFoundLabel.Location = new System.Drawing.Point(11, 100);
            this.uxFoundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxFoundLabel.Name = "uxFoundLabel";
            this.uxFoundLabel.Size = new System.Drawing.Size(102, 17);
            this.uxFoundLabel.TabIndex = 3;
            this.uxFoundLabel.Text = "Date Founded:";
            // 
            // uxEndLabel
            // 
            this.uxEndLabel.AutoSize = true;
            this.uxEndLabel.Location = new System.Drawing.Point(284, 100);
            this.uxEndLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxEndLabel.Name = "uxEndLabel";
            this.uxEndLabel.Size = new System.Drawing.Size(91, 17);
            this.uxEndLabel.TabIndex = 5;
            this.uxEndLabel.Text = "Date Ended: ";
            // 
            // uxLocationText
            // 
            this.uxLocationText.Location = new System.Drawing.Point(85, 56);
            this.uxLocationText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxLocationText.Name = "uxLocationText";
            this.uxLocationText.Size = new System.Drawing.Size(409, 22);
            this.uxLocationText.TabIndex = 8;
            // 
            // uxLocationLabel
            // 
            this.uxLocationLabel.AutoSize = true;
            this.uxLocationLabel.Location = new System.Drawing.Point(11, 59);
            this.uxLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLocationLabel.Name = "uxLocationLabel";
            this.uxLocationLabel.Size = new System.Drawing.Size(66, 17);
            this.uxLocationLabel.TabIndex = 7;
            this.uxLocationLabel.Text = "Location:";
            // 
            // uxEndedCheck
            // 
            this.uxEndedCheck.AutoSize = true;
            this.uxEndedCheck.Checked = true;
            this.uxEndedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxEndedCheck.Location = new System.Drawing.Point(323, 133);
            this.uxEndedCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxEndedCheck.Name = "uxEndedCheck";
            this.uxEndedCheck.Size = new System.Drawing.Size(171, 21);
            this.uxEndedCheck.TabIndex = 12;
            this.uxEndedCheck.Text = "Is the label still active?";
            this.uxEndedCheck.UseVisualStyleBackColor = true;
            this.uxEndedCheck.CheckedChanged += new System.EventHandler(this.uxEndedCheck_CheckedChanged);
            // 
            // uxFoundedDate
            // 
            this.uxFoundedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxFoundedDate.Location = new System.Drawing.Point(120, 95);
            this.uxFoundedDate.Name = "uxFoundedDate";
            this.uxFoundedDate.Size = new System.Drawing.Size(112, 22);
            this.uxFoundedDate.TabIndex = 13;
            // 
            // uxEndedDate
            // 
            this.uxEndedDate.Enabled = false;
            this.uxEndedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxEndedDate.Location = new System.Drawing.Point(382, 95);
            this.uxEndedDate.Name = "uxEndedDate";
            this.uxEndedDate.Size = new System.Drawing.Size(112, 22);
            this.uxEndedDate.TabIndex = 14;
            // 
            // AddRecordLabelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 231);
            this.Controls.Add(this.uxEndedDate);
            this.Controls.Add(this.uxFoundedDate);
            this.Controls.Add(this.uxEndedCheck);
            this.Controls.Add(this.uxLocationText);
            this.Controls.Add(this.uxLocationLabel);
            this.Controls.Add(this.uxEndLabel);
            this.Controls.Add(this.uxFoundLabel);
            this.Controls.Add(this.uxNameText);
            this.Controls.Add(this.uxRLNameText);
            this.Controls.Add(this.uxAddRLButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddRecordLabelView";
            this.Text = "AddView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddRLButton;
        private System.Windows.Forms.Label uxRLNameText;
        private System.Windows.Forms.TextBox uxNameText;
        private System.Windows.Forms.Label uxFoundLabel;
        private System.Windows.Forms.Label uxEndLabel;
        private System.Windows.Forms.TextBox uxLocationText;
        private System.Windows.Forms.Label uxLocationLabel;
        private System.Windows.Forms.CheckBox uxEndedCheck;
        private System.Windows.Forms.DateTimePicker uxFoundedDate;
        private System.Windows.Forms.DateTimePicker uxEndedDate;
    }
}
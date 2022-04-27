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
            this.uxAddArtistButton = new System.Windows.Forms.Button();
            this.uxArtistLabel = new System.Windows.Forms.Label();
            this.uxArtistName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxAddArtistButton
            // 
            this.uxAddArtistButton.Location = new System.Drawing.Point(95, 133);
            this.uxAddArtistButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxAddArtistButton.Name = "uxAddArtistButton";
            this.uxAddArtistButton.Size = new System.Drawing.Size(146, 28);
            this.uxAddArtistButton.TabIndex = 0;
            this.uxAddArtistButton.Text = "Add Artist";
            this.uxAddArtistButton.UseVisualStyleBackColor = true;
            this.uxAddArtistButton.Click += new System.EventHandler(this.uxAddArtistButton_Click);
            // 
            // uxArtistLabel
            // 
            this.uxArtistLabel.AutoSize = true;
            this.uxArtistLabel.Location = new System.Drawing.Point(83, 54);
            this.uxArtistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxArtistLabel.Name = "uxArtistLabel";
            this.uxArtistLabel.Size = new System.Drawing.Size(171, 17);
            this.uxArtistLabel.TabIndex = 1;
            this.uxArtistLabel.Text = "What is the artist\'s name?";
            // 
            // uxArtistName
            // 
            this.uxArtistName.Location = new System.Drawing.Point(23, 90);
            this.uxArtistName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxArtistName.Name = "uxArtistName";
            this.uxArtistName.Size = new System.Drawing.Size(271, 22);
            this.uxArtistName.TabIndex = 2;
            // 
            // AddArtistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 198);
            this.Controls.Add(this.uxArtistName);
            this.Controls.Add(this.uxArtistLabel);
            this.Controls.Add(this.uxAddArtistButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddArtistView";
            this.Text = "AddView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddArtistButton;
        private System.Windows.Forms.Label uxArtistLabel;
        private System.Windows.Forms.TextBox uxArtistName;
    }
}
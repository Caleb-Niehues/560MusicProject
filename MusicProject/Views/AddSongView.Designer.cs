namespace MusicProject.Views
{
    partial class AddSongView
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
            this.uxAddSongButton = new System.Windows.Forms.Button();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxNameBox = new System.Windows.Forms.TextBox();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxTimeSpanLabel = new System.Windows.Forms.Label();
            this.uxMinute = new System.Windows.Forms.NumericUpDown();
            this.uxSecond = new System.Windows.Forms.NumericUpDown();
            this.uxGenreDropDown = new System.Windows.Forms.ComboBox();
            this.uxAlbumLabel = new System.Windows.Forms.Label();
            this.uxArtistLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // uxAddSongButton
            // 
            this.uxAddSongButton.Location = new System.Drawing.Point(350, 16);
            this.uxAddSongButton.Margin = new System.Windows.Forms.Padding(4);
            this.uxAddSongButton.Name = "uxAddSongButton";
            this.uxAddSongButton.Size = new System.Drawing.Size(100, 28);
            this.uxAddSongButton.TabIndex = 0;
            this.uxAddSongButton.Text = "Add Song";
            this.uxAddSongButton.UseVisualStyleBackColor = true;
            this.uxAddSongButton.Click += new System.EventHandler(this.uxAddSongButton_Click);
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Location = new System.Drawing.Point(28, 82);
            this.uxNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(49, 17);
            this.uxNameLabel.TabIndex = 1;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxNameBox
            // 
            this.uxNameBox.Location = new System.Drawing.Point(85, 82);
            this.uxNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxNameBox.Name = "uxNameBox";
            this.uxNameBox.Size = new System.Drawing.Size(365, 22);
            this.uxNameBox.TabIndex = 2;
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Location = new System.Drawing.Point(28, 127);
            this.uxGenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(52, 17);
            this.uxGenreLabel.TabIndex = 5;
            this.uxGenreLabel.Text = "Genre:";
            // 
            // uxTimeSpanLabel
            // 
            this.uxTimeSpanLabel.AutoSize = true;
            this.uxTimeSpanLabel.Location = new System.Drawing.Point(243, 127);
            this.uxTimeSpanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxTimeSpanLabel.Name = "uxTimeSpanLabel";
            this.uxTimeSpanLabel.Size = new System.Drawing.Size(90, 17);
            this.uxTimeSpanLabel.TabIndex = 7;
            this.uxTimeSpanLabel.Text = "Length(M,S):";
            // 
            // uxMinute
            // 
            this.uxMinute.Location = new System.Drawing.Point(332, 127);
            this.uxMinute.Margin = new System.Windows.Forms.Padding(4);
            this.uxMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.uxMinute.Name = "uxMinute";
            this.uxMinute.Size = new System.Drawing.Size(55, 22);
            this.uxMinute.TabIndex = 9;
            // 
            // uxSecond
            // 
            this.uxSecond.Location = new System.Drawing.Point(395, 126);
            this.uxSecond.Margin = new System.Windows.Forms.Padding(4);
            this.uxSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.uxSecond.Name = "uxSecond";
            this.uxSecond.Size = new System.Drawing.Size(55, 22);
            this.uxSecond.TabIndex = 10;
            // 
            // uxGenreDropDown
            // 
            this.uxGenreDropDown.FormattingEnabled = true;
            this.uxGenreDropDown.Location = new System.Drawing.Point(85, 124);
            this.uxGenreDropDown.Name = "uxGenreDropDown";
            this.uxGenreDropDown.Size = new System.Drawing.Size(151, 24);
            this.uxGenreDropDown.TabIndex = 11;
            // 
            // uxAlbumLabel
            // 
            this.uxAlbumLabel.AutoSize = true;
            this.uxAlbumLabel.Location = new System.Drawing.Point(28, 16);
            this.uxAlbumLabel.Name = "uxAlbumLabel";
            this.uxAlbumLabel.Size = new System.Drawing.Size(81, 17);
            this.uxAlbumLabel.TabIndex = 12;
            this.uxAlbumLabel.Text = "Album title: ";
            // 
            // uxArtistLabel
            // 
            this.uxArtistLabel.AutoSize = true;
            this.uxArtistLabel.Location = new System.Drawing.Point(28, 47);
            this.uxArtistLabel.Name = "uxArtistLabel";
            this.uxArtistLabel.Size = new System.Drawing.Size(87, 17);
            this.uxArtistLabel.TabIndex = 13;
            this.uxArtistLabel.Text = "Artist name: ";
            // 
            // AddSongView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 173);
            this.Controls.Add(this.uxArtistLabel);
            this.Controls.Add(this.uxAlbumLabel);
            this.Controls.Add(this.uxGenreDropDown);
            this.Controls.Add(this.uxSecond);
            this.Controls.Add(this.uxMinute);
            this.Controls.Add(this.uxTimeSpanLabel);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxNameBox);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxAddSongButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSongView";
            this.Text = "AddView";
            ((System.ComponentModel.ISupportInitialize)(this.uxMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddSongButton;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.TextBox uxNameBox;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.Label uxTimeSpanLabel;
        private System.Windows.Forms.NumericUpDown uxMinute;
        private System.Windows.Forms.NumericUpDown uxSecond;
        private System.Windows.Forms.ComboBox uxGenreDropDown;
        private System.Windows.Forms.Label uxAlbumLabel;
        private System.Windows.Forms.Label uxArtistLabel;
    }
}
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
            this.uxSongNameText = new System.Windows.Forms.Label();
            this.uxSongNText = new System.Windows.Forms.TextBox();
            this.uxAlbumText = new System.Windows.Forms.TextBox();
            this.uxAlbumLabel = new System.Windows.Forms.Label();
            this.uxGenreText = new System.Windows.Forms.TextBox();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxTimeSpanLabel = new System.Windows.Forms.Label();
            this.uxHours = new System.Windows.Forms.NumericUpDown();
            this.uxMinute = new System.Windows.Forms.NumericUpDown();
            this.uxSecond = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // uxAddSongButton
            // 
            this.uxAddSongButton.Location = new System.Drawing.Point(167, 274);
            this.uxAddSongButton.Name = "uxAddSongButton";
            this.uxAddSongButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddSongButton.TabIndex = 0;
            this.uxAddSongButton.Text = "Add Song";
            this.uxAddSongButton.UseVisualStyleBackColor = true;
            // 
            // uxSongNameText
            // 
            this.uxSongNameText.AutoSize = true;
            this.uxSongNameText.Location = new System.Drawing.Point(22, 77);
            this.uxSongNameText.Name = "uxSongNameText";
            this.uxSongNameText.Size = new System.Drawing.Size(66, 13);
            this.uxSongNameText.TabIndex = 1;
            this.uxSongNameText.Text = "Song Name:";
            // 
            // uxSongNText
            // 
            this.uxSongNText.Location = new System.Drawing.Point(94, 77);
            this.uxSongNText.Name = "uxSongNText";
            this.uxSongNText.Size = new System.Drawing.Size(252, 20);
            this.uxSongNText.TabIndex = 2;
            // 
            // uxAlbumText
            // 
            this.uxAlbumText.Location = new System.Drawing.Point(94, 120);
            this.uxAlbumText.Name = "uxAlbumText";
            this.uxAlbumText.Size = new System.Drawing.Size(252, 20);
            this.uxAlbumText.TabIndex = 4;
            // 
            // uxAlbumLabel
            // 
            this.uxAlbumLabel.AutoSize = true;
            this.uxAlbumLabel.Location = new System.Drawing.Point(48, 120);
            this.uxAlbumLabel.Name = "uxAlbumLabel";
            this.uxAlbumLabel.Size = new System.Drawing.Size(39, 13);
            this.uxAlbumLabel.TabIndex = 3;
            this.uxAlbumLabel.Text = "Album:";
            // 
            // uxGenreText
            // 
            this.uxGenreText.Location = new System.Drawing.Point(94, 160);
            this.uxGenreText.Name = "uxGenreText";
            this.uxGenreText.Size = new System.Drawing.Size(252, 20);
            this.uxGenreText.TabIndex = 6;
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Location = new System.Drawing.Point(48, 160);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(39, 13);
            this.uxGenreLabel.TabIndex = 5;
            this.uxGenreLabel.Text = "Genre:";
            // 
            // uxTimeSpanLabel
            // 
            this.uxTimeSpanLabel.AutoSize = true;
            this.uxTimeSpanLabel.Location = new System.Drawing.Point(3, 203);
            this.uxTimeSpanLabel.Name = "uxTimeSpanLabel";
            this.uxTimeSpanLabel.Size = new System.Drawing.Size(97, 13);
            this.uxTimeSpanLabel.TabIndex = 7;
            this.uxTimeSpanLabel.Text = "Time Span(H,M,S):";
            // 
            // uxHours
            // 
            this.uxHours.Location = new System.Drawing.Point(106, 201);
            this.uxHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxHours.Name = "uxHours";
            this.uxHours.Size = new System.Drawing.Size(41, 20);
            this.uxHours.TabIndex = 8;
            // 
            // uxMinute
            // 
            this.uxMinute.Location = new System.Drawing.Point(153, 201);
            this.uxMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.uxMinute.Name = "uxMinute";
            this.uxMinute.Size = new System.Drawing.Size(41, 20);
            this.uxMinute.TabIndex = 9;
            // 
            // uxSecond
            // 
            this.uxSecond.Location = new System.Drawing.Point(200, 201);
            this.uxSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.uxSecond.Name = "uxSecond";
            this.uxSecond.Size = new System.Drawing.Size(41, 20);
            this.uxSecond.TabIndex = 10;
            // 
            // AddSongView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.uxSecond);
            this.Controls.Add(this.uxMinute);
            this.Controls.Add(this.uxHours);
            this.Controls.Add(this.uxTimeSpanLabel);
            this.Controls.Add(this.uxGenreText);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxAlbumText);
            this.Controls.Add(this.uxAlbumLabel);
            this.Controls.Add(this.uxSongNText);
            this.Controls.Add(this.uxSongNameText);
            this.Controls.Add(this.uxAddSongButton);
            this.Name = "AddSongView";
            this.Text = "AddView";
            ((System.ComponentModel.ISupportInitialize)(this.uxHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddSongButton;
        private System.Windows.Forms.Label uxSongNameText;
        private System.Windows.Forms.TextBox uxSongNText;
        private System.Windows.Forms.TextBox uxAlbumText;
        private System.Windows.Forms.Label uxAlbumLabel;
        private System.Windows.Forms.TextBox uxGenreText;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.Label uxTimeSpanLabel;
        private System.Windows.Forms.NumericUpDown uxHours;
        private System.Windows.Forms.NumericUpDown uxMinute;
        private System.Windows.Forms.NumericUpDown uxSecond;
    }
}
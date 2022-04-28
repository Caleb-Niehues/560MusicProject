
namespace MusicProject.Views
{
    partial class AddAlbumView
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
            this.uxReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxArtistLabel = new System.Windows.Forms.Label();
            this.uxCertificationLabel = new System.Windows.Forms.Label();
            this.uxReleaseDateLabel = new System.Windows.Forms.Label();
            this.uxSongList = new System.Windows.Forms.ListBox();
            this.uxProducerList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uxCertificationCombo = new System.Windows.Forms.ComboBox();
            this.uxProducerLabel = new System.Windows.Forms.Label();
            this.uxFetchProducerText = new System.Windows.Forms.TextBox();
            this.uxNewProducerButton = new System.Windows.Forms.Button();
            this.uxNewLabelButton = new System.Windows.Forms.Button();
            this.uxFetchLabelBox = new System.Windows.Forms.TextBox();
            this.uxLabelLabel = new System.Windows.Forms.Label();
            this.uxNewSongButton = new System.Windows.Forms.Button();
            this.uxSongsLabel = new System.Windows.Forms.Label();
            this.uxFinishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxReleaseDate
            // 
            this.uxReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxReleaseDate.Location = new System.Drawing.Point(114, 122);
            this.uxReleaseDate.Name = "uxReleaseDate";
            this.uxReleaseDate.Size = new System.Drawing.Size(168, 22);
            this.uxReleaseDate.TabIndex = 0;
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Location = new System.Drawing.Point(12, 20);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(43, 17);
            this.uxTitleLabel.TabIndex = 1;
            this.uxTitleLabel.Text = "Title: ";
            // 
            // uxArtistLabel
            // 
            this.uxArtistLabel.AutoSize = true;
            this.uxArtistLabel.Location = new System.Drawing.Point(12, 52);
            this.uxArtistLabel.Name = "uxArtistLabel";
            this.uxArtistLabel.Size = new System.Drawing.Size(48, 17);
            this.uxArtistLabel.TabIndex = 2;
            this.uxArtistLabel.Text = "Artist: ";
            // 
            // uxCertificationLabel
            // 
            this.uxCertificationLabel.AutoSize = true;
            this.uxCertificationLabel.Location = new System.Drawing.Point(12, 86);
            this.uxCertificationLabel.Name = "uxCertificationLabel";
            this.uxCertificationLabel.Size = new System.Drawing.Size(86, 17);
            this.uxCertificationLabel.TabIndex = 3;
            this.uxCertificationLabel.Text = "Certification:";
            // 
            // uxReleaseDateLabel
            // 
            this.uxReleaseDateLabel.AutoSize = true;
            this.uxReleaseDateLabel.Location = new System.Drawing.Point(12, 122);
            this.uxReleaseDateLabel.Name = "uxReleaseDateLabel";
            this.uxReleaseDateLabel.Size = new System.Drawing.Size(96, 17);
            this.uxReleaseDateLabel.TabIndex = 5;
            this.uxReleaseDateLabel.Text = "Release date:";
            // 
            // uxSongList
            // 
            this.uxSongList.FormattingEnabled = true;
            this.uxSongList.ItemHeight = 16;
            this.uxSongList.Location = new System.Drawing.Point(314, 53);
            this.uxSongList.Name = "uxSongList";
            this.uxSongList.Size = new System.Drawing.Size(402, 276);
            this.uxSongList.TabIndex = 6;
            // 
            // uxProducerList
            // 
            this.uxProducerList.FormattingEnabled = true;
            this.uxProducerList.ItemHeight = 16;
            this.uxProducerList.Location = new System.Drawing.Point(15, 286);
            this.uxProducerList.Name = "uxProducerList";
            this.uxProducerList.Size = new System.Drawing.Size(267, 132);
            this.uxProducerList.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 22);
            this.textBox2.TabIndex = 9;
            // 
            // uxCertificationCombo
            // 
            this.uxCertificationCombo.FormattingEnabled = true;
            this.uxCertificationCombo.Location = new System.Drawing.Point(104, 83);
            this.uxCertificationCombo.Name = "uxCertificationCombo";
            this.uxCertificationCombo.Size = new System.Drawing.Size(177, 24);
            this.uxCertificationCombo.TabIndex = 10;
            // 
            // uxProducerLabel
            // 
            this.uxProducerLabel.AutoSize = true;
            this.uxProducerLabel.Location = new System.Drawing.Point(13, 223);
            this.uxProducerLabel.Name = "uxProducerLabel";
            this.uxProducerLabel.Size = new System.Drawing.Size(77, 17);
            this.uxProducerLabel.TabIndex = 11;
            this.uxProducerLabel.Text = "Producers:";
            // 
            // uxFetchProducerText
            // 
            this.uxFetchProducerText.Location = new System.Drawing.Point(16, 249);
            this.uxFetchProducerText.Name = "uxFetchProducerText";
            this.uxFetchProducerText.Size = new System.Drawing.Size(266, 22);
            this.uxFetchProducerText.TabIndex = 12;
            this.uxFetchProducerText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uxFetchProducerText_HitEnter);
            // 
            // uxNewProducerButton
            // 
            this.uxNewProducerButton.Location = new System.Drawing.Point(151, 220);
            this.uxNewProducerButton.Name = "uxNewProducerButton";
            this.uxNewProducerButton.Size = new System.Drawing.Size(131, 23);
            this.uxNewProducerButton.TabIndex = 13;
            this.uxNewProducerButton.Text = "New Producer";
            this.uxNewProducerButton.UseVisualStyleBackColor = true;
            this.uxNewProducerButton.Click += new System.EventHandler(this.uxNewProducerButton_Click);
            // 
            // uxNewLabelButton
            // 
            this.uxNewLabelButton.Location = new System.Drawing.Point(10, 179);
            this.uxNewLabelButton.Name = "uxNewLabelButton";
            this.uxNewLabelButton.Size = new System.Drawing.Size(88, 23);
            this.uxNewLabelButton.TabIndex = 16;
            this.uxNewLabelButton.Text = "New Label";
            this.uxNewLabelButton.UseVisualStyleBackColor = true;
            this.uxNewLabelButton.Click += new System.EventHandler(this.uxNewRecordLabelButton_Click);
            // 
            // uxFetchLabelBox
            // 
            this.uxFetchLabelBox.Location = new System.Drawing.Point(114, 179);
            this.uxFetchLabelBox.Name = "uxFetchLabelBox";
            this.uxFetchLabelBox.Size = new System.Drawing.Size(168, 22);
            this.uxFetchLabelBox.TabIndex = 15;
            this.uxFetchLabelBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uxFetchRecordLabelText_HitEnter);
            // 
            // uxLabelLabel
            // 
            this.uxLabelLabel.AutoSize = true;
            this.uxLabelLabel.Location = new System.Drawing.Point(12, 159);
            this.uxLabelLabel.Name = "uxLabelLabel";
            this.uxLabelLabel.Size = new System.Drawing.Size(97, 17);
            this.uxLabelLabel.TabIndex = 14;
            this.uxLabelLabel.Text = "Record Label:";
            // 
            // uxNewSongButton
            // 
            this.uxNewSongButton.Location = new System.Drawing.Point(585, 12);
            this.uxNewSongButton.Name = "uxNewSongButton";
            this.uxNewSongButton.Size = new System.Drawing.Size(131, 28);
            this.uxNewSongButton.TabIndex = 19;
            this.uxNewSongButton.Text = "New Song";
            this.uxNewSongButton.UseVisualStyleBackColor = true;
            this.uxNewSongButton.Click += new System.EventHandler(this.uxNewSongButton_Click);
            // 
            // uxSongsLabel
            // 
            this.uxSongsLabel.AutoSize = true;
            this.uxSongsLabel.Location = new System.Drawing.Point(311, 20);
            this.uxSongsLabel.Name = "uxSongsLabel";
            this.uxSongsLabel.Size = new System.Drawing.Size(52, 17);
            this.uxSongsLabel.TabIndex = 17;
            this.uxSongsLabel.Text = "Songs:";
            // 
            // uxFinishButton
            // 
            this.uxFinishButton.Location = new System.Drawing.Point(451, 388);
            this.uxFinishButton.Name = "uxFinishButton";
            this.uxFinishButton.Size = new System.Drawing.Size(131, 30);
            this.uxFinishButton.TabIndex = 20;
            this.uxFinishButton.Text = "Finish Album";
            this.uxFinishButton.UseVisualStyleBackColor = true;
            this.uxFinishButton.Click += new System.EventHandler(this.uxFinishButton_Click);
            // 
            // AddAlbumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 435);
            this.Controls.Add(this.uxFinishButton);
            this.Controls.Add(this.uxNewSongButton);
            this.Controls.Add(this.uxSongsLabel);
            this.Controls.Add(this.uxNewLabelButton);
            this.Controls.Add(this.uxFetchLabelBox);
            this.Controls.Add(this.uxLabelLabel);
            this.Controls.Add(this.uxNewProducerButton);
            this.Controls.Add(this.uxFetchProducerText);
            this.Controls.Add(this.uxProducerLabel);
            this.Controls.Add(this.uxCertificationCombo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxProducerList);
            this.Controls.Add(this.uxSongList);
            this.Controls.Add(this.uxReleaseDateLabel);
            this.Controls.Add(this.uxCertificationLabel);
            this.Controls.Add(this.uxArtistLabel);
            this.Controls.Add(this.uxTitleLabel);
            this.Controls.Add(this.uxReleaseDate);
            this.Name = "AddAlbumView";
            this.Text = "AddAlbum";
            this.Load += new System.EventHandler(this.AddAlbumView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxReleaseDate;
        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.Label uxArtistLabel;
        private System.Windows.Forms.Label uxCertificationLabel;
        private System.Windows.Forms.Label uxReleaseDateLabel;
        private System.Windows.Forms.ListBox uxSongList;
        private System.Windows.Forms.ListBox uxProducerList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox uxCertificationCombo;
        private System.Windows.Forms.Label uxProducerLabel;
        private System.Windows.Forms.TextBox uxFetchProducerText;
        private System.Windows.Forms.Button uxNewProducerButton;
        private System.Windows.Forms.Button uxNewLabelButton;
        private System.Windows.Forms.TextBox uxFetchLabelBox;
        private System.Windows.Forms.Label uxLabelLabel;
        private System.Windows.Forms.Button uxNewSongButton;
        private System.Windows.Forms.Label uxSongsLabel;
        private System.Windows.Forms.Button uxFinishButton;
    }
}
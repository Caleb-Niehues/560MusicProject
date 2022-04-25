﻿namespace MusicProject.Views
{
    partial class MainView
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
            this.uxLogIn = new System.Windows.Forms.Button();
            this.uxGenreTimeline = new System.Windows.Forms.Button();
            this.uxArtistTimeline = new System.Windows.Forms.Button();
            this.uxRecordLabelRoster = new System.Windows.Forms.Button();
            this.uxUserLabel = new System.Windows.Forms.Label();
            this.uxLookUpText = new System.Windows.Forms.TextBox();
            this.uxGetArtistReviews = new System.Windows.Forms.Button();
            this.uxAddToDB = new System.Windows.Forms.Button();
            this.uxSongList = new System.Windows.Forms.ListBox();
            this.uxSongsLabel = new System.Windows.Forms.Label();
            this.uxProducerLabel = new System.Windows.Forms.Label();
            this.uxProducerList = new System.Windows.Forms.ListBox();
            this.uxRecordLabelList = new System.Windows.Forms.ListBox();
            this.uxPersonList = new System.Windows.Forms.ListBox();
            this.uxArtistListBox = new System.Windows.Forms.ListBox();
            this.uxRecordLabel = new System.Windows.Forms.Label();
            this.uxPersonLabel = new System.Windows.Forms.Label();
            this.uxArtistsLabel = new System.Windows.Forms.Label();
            this.uxLeaveReview = new System.Windows.Forms.Button();
            this.uxAlbumsLabel = new System.Windows.Forms.Label();
            this.uxAlbumListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxLogIn
            // 
            this.uxLogIn.Location = new System.Drawing.Point(17, 15);
            this.uxLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.uxLogIn.Name = "uxLogIn";
            this.uxLogIn.Size = new System.Drawing.Size(100, 28);
            this.uxLogIn.TabIndex = 0;
            this.uxLogIn.Text = "User Actions";
            this.uxLogIn.UseVisualStyleBackColor = true;
            this.uxLogIn.Click += new System.EventHandler(this.uxLogIn_Click);
            // 
            // uxGenreTimeline
            // 
            this.uxGenreTimeline.Location = new System.Drawing.Point(15, 104);
            this.uxGenreTimeline.Margin = new System.Windows.Forms.Padding(4);
            this.uxGenreTimeline.Name = "uxGenreTimeline";
            this.uxGenreTimeline.Size = new System.Drawing.Size(263, 28);
            this.uxGenreTimeline.TabIndex = 1;
            this.uxGenreTimeline.Text = "Show genre timeline";
            this.uxGenreTimeline.UseVisualStyleBackColor = true;
            // 
            // uxArtistTimeline
            // 
            this.uxArtistTimeline.Location = new System.Drawing.Point(17, 140);
            this.uxArtistTimeline.Margin = new System.Windows.Forms.Padding(4);
            this.uxArtistTimeline.Name = "uxArtistTimeline";
            this.uxArtistTimeline.Size = new System.Drawing.Size(263, 28);
            this.uxArtistTimeline.TabIndex = 2;
            this.uxArtistTimeline.Text = "Show artist timeline";
            this.uxArtistTimeline.UseVisualStyleBackColor = true;
            // 
            // uxRecordLabelRoster
            // 
            this.uxRecordLabelRoster.Location = new System.Drawing.Point(17, 174);
            this.uxRecordLabelRoster.Margin = new System.Windows.Forms.Padding(4);
            this.uxRecordLabelRoster.Name = "uxRecordLabelRoster";
            this.uxRecordLabelRoster.Size = new System.Drawing.Size(263, 28);
            this.uxRecordLabelRoster.TabIndex = 3;
            this.uxRecordLabelRoster.Text = "Get active roster";
            this.uxRecordLabelRoster.UseVisualStyleBackColor = true;
            // 
            // uxUserLabel
            // 
            this.uxUserLabel.AutoSize = true;
            this.uxUserLabel.Location = new System.Drawing.Point(186, 21);
            this.uxUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxUserLabel.Name = "uxUserLabel";
            this.uxUserLabel.Size = new System.Drawing.Size(92, 17);
            this.uxUserLabel.TabIndex = 4;
            this.uxUserLabel.Text = "Not logged in";
            // 
            // uxLookUpText
            // 
            this.uxLookUpText.Location = new System.Drawing.Point(17, 246);
            this.uxLookUpText.Margin = new System.Windows.Forms.Padding(4);
            this.uxLookUpText.Name = "uxLookUpText";
            this.uxLookUpText.Size = new System.Drawing.Size(261, 22);
            this.uxLookUpText.TabIndex = 5;
            this.uxLookUpText.Text = "Look up song/album/artist";
            this.uxLookUpText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxSearch_HitEnter);
            // 
            // uxGetArtistReviews
            // 
            this.uxGetArtistReviews.Location = new System.Drawing.Point(19, 210);
            this.uxGetArtistReviews.Margin = new System.Windows.Forms.Padding(4);
            this.uxGetArtistReviews.Name = "uxGetArtistReviews";
            this.uxGetArtistReviews.Size = new System.Drawing.Size(261, 28);
            this.uxGetArtistReviews.TabIndex = 6;
            this.uxGetArtistReviews.Text = "Get artist reviews";
            this.uxGetArtistReviews.UseVisualStyleBackColor = true;
            // 
            // uxAddToDB
            // 
            this.uxAddToDB.Location = new System.Drawing.Point(67, 313);
            this.uxAddToDB.Margin = new System.Windows.Forms.Padding(4);
            this.uxAddToDB.Name = "uxAddToDB";
            this.uxAddToDB.Size = new System.Drawing.Size(100, 28);
            this.uxAddToDB.TabIndex = 7;
            this.uxAddToDB.Text = "Add to DB";
            this.uxAddToDB.UseVisualStyleBackColor = true;
            // 
            // uxSongList
            // 
            this.uxSongList.FormattingEnabled = true;
            this.uxSongList.ItemHeight = 16;
            this.uxSongList.Location = new System.Drawing.Point(589, 71);
            this.uxSongList.Margin = new System.Windows.Forms.Padding(4);
            this.uxSongList.Name = "uxSongList";
            this.uxSongList.Size = new System.Drawing.Size(159, 116);
            this.uxSongList.TabIndex = 8;
            // 
            // uxSongsLabel
            // 
            this.uxSongsLabel.AutoSize = true;
            this.uxSongsLabel.Location = new System.Drawing.Point(589, 51);
            this.uxSongsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxSongsLabel.Name = "uxSongsLabel";
            this.uxSongsLabel.Size = new System.Drawing.Size(48, 17);
            this.uxSongsLabel.TabIndex = 9;
            this.uxSongsLabel.Text = "Songs";
            // 
            // uxProducerLabel
            // 
            this.uxProducerLabel.AutoSize = true;
            this.uxProducerLabel.Location = new System.Drawing.Point(589, 253);
            this.uxProducerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxProducerLabel.Name = "uxProducerLabel";
            this.uxProducerLabel.Size = new System.Drawing.Size(66, 17);
            this.uxProducerLabel.TabIndex = 10;
            this.uxProducerLabel.Text = "Producer";
            // 
            // uxProducerList
            // 
            this.uxProducerList.FormattingEnabled = true;
            this.uxProducerList.ItemHeight = 16;
            this.uxProducerList.Location = new System.Drawing.Point(589, 274);
            this.uxProducerList.Margin = new System.Windows.Forms.Padding(4);
            this.uxProducerList.Name = "uxProducerList";
            this.uxProducerList.Size = new System.Drawing.Size(159, 116);
            this.uxProducerList.TabIndex = 11;
            // 
            // uxRecordLabelList
            // 
            this.uxRecordLabelList.FormattingEnabled = true;
            this.uxRecordLabelList.ItemHeight = 16;
            this.uxRecordLabelList.Location = new System.Drawing.Point(834, 71);
            this.uxRecordLabelList.Margin = new System.Windows.Forms.Padding(4);
            this.uxRecordLabelList.Name = "uxRecordLabelList";
            this.uxRecordLabelList.Size = new System.Drawing.Size(159, 116);
            this.uxRecordLabelList.TabIndex = 12;
            // 
            // uxPersonList
            // 
            this.uxPersonList.FormattingEnabled = true;
            this.uxPersonList.ItemHeight = 16;
            this.uxPersonList.Location = new System.Drawing.Point(834, 274);
            this.uxPersonList.Margin = new System.Windows.Forms.Padding(4);
            this.uxPersonList.Name = "uxPersonList";
            this.uxPersonList.Size = new System.Drawing.Size(159, 116);
            this.uxPersonList.TabIndex = 13;
            // 
            // uxArtistListBox
            // 
            this.uxArtistListBox.FormattingEnabled = true;
            this.uxArtistListBox.ItemHeight = 16;
            this.uxArtistListBox.Location = new System.Drawing.Point(344, 274);
            this.uxArtistListBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxArtistListBox.Name = "uxArtistListBox";
            this.uxArtistListBox.Size = new System.Drawing.Size(159, 116);
            this.uxArtistListBox.TabIndex = 14;
            // 
            // uxRecordLabel
            // 
            this.uxRecordLabel.AutoSize = true;
            this.uxRecordLabel.Location = new System.Drawing.Point(834, 50);
            this.uxRecordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxRecordLabel.Name = "uxRecordLabel";
            this.uxRecordLabel.Size = new System.Drawing.Size(93, 17);
            this.uxRecordLabel.TabIndex = 15;
            this.uxRecordLabel.Text = "Record Label";
            // 
            // uxPersonLabel
            // 
            this.uxPersonLabel.AutoSize = true;
            this.uxPersonLabel.Location = new System.Drawing.Point(834, 253);
            this.uxPersonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPersonLabel.Name = "uxPersonLabel";
            this.uxPersonLabel.Size = new System.Drawing.Size(53, 17);
            this.uxPersonLabel.TabIndex = 16;
            this.uxPersonLabel.Text = "Person";
            // 
            // uxArtistsLabel
            // 
            this.uxArtistsLabel.AutoSize = true;
            this.uxArtistsLabel.Location = new System.Drawing.Point(341, 253);
            this.uxArtistsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxArtistsLabel.Name = "uxArtistsLabel";
            this.uxArtistsLabel.Size = new System.Drawing.Size(47, 17);
            this.uxArtistsLabel.TabIndex = 17;
            this.uxArtistsLabel.Text = "Artists";
            // 
            // uxLeaveReview
            // 
            this.uxLeaveReview.Location = new System.Drawing.Point(13, 57);
            this.uxLeaveReview.Margin = new System.Windows.Forms.Padding(4);
            this.uxLeaveReview.Name = "uxLeaveReview";
            this.uxLeaveReview.Size = new System.Drawing.Size(263, 28);
            this.uxLeaveReview.TabIndex = 18;
            this.uxLeaveReview.Text = "Leave Review";
            this.uxLeaveReview.UseVisualStyleBackColor = true;
            this.uxLeaveReview.Click += new System.EventHandler(this.uxLeaveReview_Click);
            // 
            // uxAlbumsLabel
            // 
            this.uxAlbumsLabel.AutoSize = true;
            this.uxAlbumsLabel.Location = new System.Drawing.Point(341, 50);
            this.uxAlbumsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxAlbumsLabel.Name = "uxAlbumsLabel";
            this.uxAlbumsLabel.Size = new System.Drawing.Size(54, 17);
            this.uxAlbumsLabel.TabIndex = 20;
            this.uxAlbumsLabel.Text = "Albums";
            // 
            // uxAlbumListBox
            // 
            this.uxAlbumListBox.FormattingEnabled = true;
            this.uxAlbumListBox.ItemHeight = 16;
            this.uxAlbumListBox.Location = new System.Drawing.Point(344, 71);
            this.uxAlbumListBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxAlbumListBox.Name = "uxAlbumListBox";
            this.uxAlbumListBox.Size = new System.Drawing.Size(159, 116);
            this.uxAlbumListBox.TabIndex = 19;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.uxAlbumsLabel);
            this.Controls.Add(this.uxAlbumListBox);
            this.Controls.Add(this.uxLeaveReview);
            this.Controls.Add(this.uxArtistsLabel);
            this.Controls.Add(this.uxPersonLabel);
            this.Controls.Add(this.uxRecordLabel);
            this.Controls.Add(this.uxArtistListBox);
            this.Controls.Add(this.uxPersonList);
            this.Controls.Add(this.uxRecordLabelList);
            this.Controls.Add(this.uxProducerList);
            this.Controls.Add(this.uxProducerLabel);
            this.Controls.Add(this.uxSongsLabel);
            this.Controls.Add(this.uxSongList);
            this.Controls.Add(this.uxAddToDB);
            this.Controls.Add(this.uxGetArtistReviews);
            this.Controls.Add(this.uxLookUpText);
            this.Controls.Add(this.uxUserLabel);
            this.Controls.Add(this.uxRecordLabelRoster);
            this.Controls.Add(this.uxArtistTimeline);
            this.Controls.Add(this.uxGenreTimeline);
            this.Controls.Add(this.uxLogIn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "GoodVibes.exe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxLogIn;
        private System.Windows.Forms.Button uxGenreTimeline;
        private System.Windows.Forms.Button uxArtistTimeline;
        private System.Windows.Forms.Button uxRecordLabelRoster;
        private System.Windows.Forms.Label uxUserLabel;
        private System.Windows.Forms.TextBox uxLookUpText;
        private System.Windows.Forms.Button uxGetArtistReviews;
        private System.Windows.Forms.Button uxAddToDB;
        private System.Windows.Forms.ListBox uxSongList;
        private System.Windows.Forms.Label uxSongsLabel;
        private System.Windows.Forms.Label uxProducerLabel;
        private System.Windows.Forms.ListBox uxProducerList;
        private System.Windows.Forms.ListBox uxRecordLabelList;
        private System.Windows.Forms.ListBox uxPersonList;
        private System.Windows.Forms.ListBox uxArtistListBox;
        private System.Windows.Forms.Label uxRecordLabel;
        private System.Windows.Forms.Label uxPersonLabel;
        private System.Windows.Forms.Label uxArtistsLabel;
        private System.Windows.Forms.Button uxLeaveReview;
        private System.Windows.Forms.Label uxAlbumsLabel;
        private System.Windows.Forms.ListBox uxAlbumListBox;
    }
}
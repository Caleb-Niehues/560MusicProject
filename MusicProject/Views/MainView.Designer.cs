namespace MusicProject.Views
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
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.uxRecordLabel = new System.Windows.Forms.Label();
            this.uxPersonLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxLogIn
            // 
            this.uxLogIn.Location = new System.Drawing.Point(134, 12);
            this.uxLogIn.Name = "uxLogIn";
            this.uxLogIn.Size = new System.Drawing.Size(75, 23);
            this.uxLogIn.TabIndex = 0;
            this.uxLogIn.Text = "Log in";
            this.uxLogIn.UseVisualStyleBackColor = true;
            this.uxLogIn.Click += new System.EventHandler(this.uxLogIn_Click);
            // 
            // uxGenreTimeline
            // 
            this.uxGenreTimeline.Location = new System.Drawing.Point(12, 72);
            this.uxGenreTimeline.Name = "uxGenreTimeline";
            this.uxGenreTimeline.Size = new System.Drawing.Size(197, 23);
            this.uxGenreTimeline.TabIndex = 1;
            this.uxGenreTimeline.Text = "Show genre timeline";
            this.uxGenreTimeline.UseVisualStyleBackColor = true;
            // 
            // uxArtistTimeline
            // 
            this.uxArtistTimeline.Location = new System.Drawing.Point(12, 101);
            this.uxArtistTimeline.Name = "uxArtistTimeline";
            this.uxArtistTimeline.Size = new System.Drawing.Size(197, 23);
            this.uxArtistTimeline.TabIndex = 2;
            this.uxArtistTimeline.Text = "Show artist timeline";
            this.uxArtistTimeline.UseVisualStyleBackColor = true;
            // 
            // uxRecordLabelRoster
            // 
            this.uxRecordLabelRoster.Location = new System.Drawing.Point(12, 130);
            this.uxRecordLabelRoster.Name = "uxRecordLabelRoster";
            this.uxRecordLabelRoster.Size = new System.Drawing.Size(197, 23);
            this.uxRecordLabelRoster.TabIndex = 3;
            this.uxRecordLabelRoster.Text = "Get active roster";
            this.uxRecordLabelRoster.UseVisualStyleBackColor = true;
            // 
            // uxUserLabel
            // 
            this.uxUserLabel.AutoSize = true;
            this.uxUserLabel.Location = new System.Drawing.Point(9, 17);
            this.uxUserLabel.Name = "uxUserLabel";
            this.uxUserLabel.Size = new System.Drawing.Size(70, 13);
            this.uxUserLabel.TabIndex = 4;
            this.uxUserLabel.Text = "Not logged in";
            // 
            // uxLookUpText
            // 
            this.uxLookUpText.Location = new System.Drawing.Point(12, 46);
            this.uxLookUpText.Name = "uxLookUpText";
            this.uxLookUpText.Size = new System.Drawing.Size(197, 20);
            this.uxLookUpText.TabIndex = 5;
            this.uxLookUpText.Text = "Look up song/album/artist";
            this.uxLookUpText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxLookUpText_KeyDown);
            // 
            // uxGetArtistReviews
            // 
            this.uxGetArtistReviews.Location = new System.Drawing.Point(13, 160);
            this.uxGetArtistReviews.Name = "uxGetArtistReviews";
            this.uxGetArtistReviews.Size = new System.Drawing.Size(196, 23);
            this.uxGetArtistReviews.TabIndex = 6;
            this.uxGetArtistReviews.Text = "Get artist reviews";
            this.uxGetArtistReviews.UseVisualStyleBackColor = true;
            // 
            // uxAddToDB
            // 
            this.uxAddToDB.Location = new System.Drawing.Point(50, 254);
            this.uxAddToDB.Name = "uxAddToDB";
            this.uxAddToDB.Size = new System.Drawing.Size(75, 23);
            this.uxAddToDB.TabIndex = 7;
            this.uxAddToDB.Text = "Add to DB";
            this.uxAddToDB.UseVisualStyleBackColor = true;
            // 
            // uxSongList
            // 
            this.uxSongList.FormattingEnabled = true;
            this.uxSongList.Location = new System.Drawing.Point(258, 46);
            this.uxSongList.Name = "uxSongList";
            this.uxSongList.Size = new System.Drawing.Size(120, 95);
            this.uxSongList.TabIndex = 8;
            // 
            // uxSongsLabel
            // 
            this.uxSongsLabel.AutoSize = true;
            this.uxSongsLabel.Location = new System.Drawing.Point(258, 30);
            this.uxSongsLabel.Name = "uxSongsLabel";
            this.uxSongsLabel.Size = new System.Drawing.Size(37, 13);
            this.uxSongsLabel.TabIndex = 9;
            this.uxSongsLabel.Text = "Songs";
            // 
            // uxProducerLabel
            // 
            this.uxProducerLabel.AutoSize = true;
            this.uxProducerLabel.Location = new System.Drawing.Point(258, 204);
            this.uxProducerLabel.Name = "uxProducerLabel";
            this.uxProducerLabel.Size = new System.Drawing.Size(50, 13);
            this.uxProducerLabel.TabIndex = 10;
            this.uxProducerLabel.Text = "Producer";
            // 
            // uxProducerList
            // 
            this.uxProducerList.FormattingEnabled = true;
            this.uxProducerList.Location = new System.Drawing.Point(258, 221);
            this.uxProducerList.Name = "uxProducerList";
            this.uxProducerList.Size = new System.Drawing.Size(120, 95);
            this.uxProducerList.TabIndex = 11;
            // 
            // uxRecordLabelList
            // 
            this.uxRecordLabelList.FormattingEnabled = true;
            this.uxRecordLabelList.Location = new System.Drawing.Point(442, 46);
            this.uxRecordLabelList.Name = "uxRecordLabelList";
            this.uxRecordLabelList.Size = new System.Drawing.Size(120, 95);
            this.uxRecordLabelList.TabIndex = 12;
            // 
            // uxPersonList
            // 
            this.uxPersonList.FormattingEnabled = true;
            this.uxPersonList.Location = new System.Drawing.Point(442, 221);
            this.uxPersonList.Name = "uxPersonList";
            this.uxPersonList.Size = new System.Drawing.Size(120, 95);
            this.uxPersonList.TabIndex = 13;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(614, 130);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 14;
            // 
            // uxRecordLabel
            // 
            this.uxRecordLabel.AutoSize = true;
            this.uxRecordLabel.Location = new System.Drawing.Point(442, 29);
            this.uxRecordLabel.Name = "uxRecordLabel";
            this.uxRecordLabel.Size = new System.Drawing.Size(71, 13);
            this.uxRecordLabel.TabIndex = 15;
            this.uxRecordLabel.Text = "Record Label";
            // 
            // uxPersonLabel
            // 
            this.uxPersonLabel.AutoSize = true;
            this.uxPersonLabel.Location = new System.Drawing.Point(442, 204);
            this.uxPersonLabel.Name = "uxPersonLabel";
            this.uxPersonLabel.Size = new System.Drawing.Size(40, 13);
            this.uxPersonLabel.TabIndex = 16;
            this.uxPersonLabel.Text = "Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxPersonLabel);
            this.Controls.Add(this.uxRecordLabel);
            this.Controls.Add(this.listBox3);
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
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label uxRecordLabel;
        private System.Windows.Forms.Label uxPersonLabel;
        private System.Windows.Forms.Label label3;
    }
}
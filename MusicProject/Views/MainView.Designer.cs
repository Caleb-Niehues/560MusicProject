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
            this.uxTopGenres = new System.Windows.Forms.Button();
            this.uxArtistAlbums = new System.Windows.Forms.Button();
            this.uxSuperFans = new System.Windows.Forms.Button();
            this.uxUserLabel = new System.Windows.Forms.Label();
            this.uxLookUpText = new System.Windows.Forms.TextBox();
            this.uxRecordLabelAlbums = new System.Windows.Forms.Button();
            this.uxAddProducer = new System.Windows.Forms.Button();
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
            this.uxAddAlbum = new System.Windows.Forms.Button();
            this.uxAddArtist = new System.Windows.Forms.Button();
            this.uxAddRecordLabel = new System.Windows.Forms.Button();
            this.uxAddPerson = new System.Windows.Forms.Button();
            this.uxFocusedList = new System.Windows.Forms.ListBox();
            this.uxFocus = new System.Windows.Forms.Label();
            this.uxFocusButtons = new System.Windows.Forms.GroupBox();
            this.uxPeopleFocus = new System.Windows.Forms.RadioButton();
            this.uxProducersFocus = new System.Windows.Forms.RadioButton();
            this.uxLabelsFocus = new System.Windows.Forms.RadioButton();
            this.uxArtistsFocus = new System.Windows.Forms.RadioButton();
            this.uxSongsFocus = new System.Windows.Forms.RadioButton();
            this.uxAlbumsFocus = new System.Windows.Forms.RadioButton();
            this.uxAggQueryName = new System.Windows.Forms.TextBox();
            this.uxStartDate = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxEndDate = new System.Windows.Forms.DateTimePicker();
            this.uxTopGenreInput = new System.Windows.Forms.NumericUpDown();
            this.uxFocusButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxTopGenreInput)).BeginInit();
            this.SuspendLayout();
            // 
            // uxLogIn
            // 
            this.uxLogIn.Location = new System.Drawing.Point(13, 467);
            this.uxLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.uxLogIn.Name = "uxLogIn";
            this.uxLogIn.Size = new System.Drawing.Size(100, 28);
            this.uxLogIn.TabIndex = 0;
            this.uxLogIn.Text = "User Actions";
            this.uxLogIn.UseVisualStyleBackColor = true;
            this.uxLogIn.Click += new System.EventHandler(this.uxLogIn_Click);
            // 
            // uxTopGenres
            // 
            this.uxTopGenres.Location = new System.Drawing.Point(11, 159);
            this.uxTopGenres.Margin = new System.Windows.Forms.Padding(4);
            this.uxTopGenres.Name = "uxTopGenres";
            this.uxTopGenres.Size = new System.Drawing.Size(236, 28);
            this.uxTopGenres.TabIndex = 1;
            this.uxTopGenres.Text = "Top Performing Genres in Timeline";
            this.uxTopGenres.UseVisualStyleBackColor = true;
            this.uxTopGenres.Click += new System.EventHandler(this.uxTopGenres_Click);
            // 
            // uxArtistAlbums
            // 
            this.uxArtistAlbums.Location = new System.Drawing.Point(11, 195);
            this.uxArtistAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.uxArtistAlbums.Name = "uxArtistAlbums";
            this.uxArtistAlbums.Size = new System.Drawing.Size(261, 28);
            this.uxArtistAlbums.TabIndex = 2;
            this.uxArtistAlbums.Text = "Artist\'s Top Albums";
            this.uxArtistAlbums.UseVisualStyleBackColor = true;
            this.uxArtistAlbums.Click += new System.EventHandler(this.uxArtistAlbums_Click);
            // 
            // uxSuperFans
            // 
            this.uxSuperFans.Location = new System.Drawing.Point(11, 229);
            this.uxSuperFans.Margin = new System.Windows.Forms.Padding(4);
            this.uxSuperFans.Name = "uxSuperFans";
            this.uxSuperFans.Size = new System.Drawing.Size(261, 28);
            this.uxSuperFans.TabIndex = 3;
            this.uxSuperFans.Text = "Artist\'s Super Fans";
            this.uxSuperFans.UseVisualStyleBackColor = true;
            this.uxSuperFans.Click += new System.EventHandler(this.uxSuperFans_Click);
            // 
            // uxUserLabel
            // 
            this.uxUserLabel.AutoSize = true;
            this.uxUserLabel.Location = new System.Drawing.Point(93, 440);
            this.uxUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxUserLabel.Name = "uxUserLabel";
            this.uxUserLabel.Size = new System.Drawing.Size(92, 17);
            this.uxUserLabel.TabIndex = 4;
            this.uxUserLabel.Text = "Not logged in";
            this.uxUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxLookUpText
            // 
            this.uxLookUpText.Location = new System.Drawing.Point(11, 23);
            this.uxLookUpText.Margin = new System.Windows.Forms.Padding(4);
            this.uxLookUpText.Name = "uxLookUpText";
            this.uxLookUpText.Size = new System.Drawing.Size(261, 22);
            this.uxLookUpText.TabIndex = 5;
            this.uxLookUpText.Text = "Look up song/album/artist";
            this.uxLookUpText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxSearch_HitEnter);
            // 
            // uxRecordLabelAlbums
            // 
            this.uxRecordLabelAlbums.Location = new System.Drawing.Point(13, 265);
            this.uxRecordLabelAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.uxRecordLabelAlbums.Name = "uxRecordLabelAlbums";
            this.uxRecordLabelAlbums.Size = new System.Drawing.Size(259, 28);
            this.uxRecordLabelAlbums.TabIndex = 6;
            this.uxRecordLabelAlbums.Text = "Record Label\'s Albums in Timeline";
            this.uxRecordLabelAlbums.UseVisualStyleBackColor = true;
            this.uxRecordLabelAlbums.Click += new System.EventHandler(this.uxRecordLabelAlbums_Click);
            // 
            // uxAddProducer
            // 
            this.uxAddProducer.Location = new System.Drawing.Point(147, 81);
            this.uxAddProducer.Name = "uxAddProducer";
            this.uxAddProducer.Size = new System.Drawing.Size(125, 23);
            this.uxAddProducer.TabIndex = 7;
            this.uxAddProducer.Text = "Add Producer";
            this.uxAddProducer.UseVisualStyleBackColor = true;
            this.uxAddProducer.Click += new System.EventHandler(this.uxAddProducer_Click);
            // 
            // uxSongList
            // 
            this.uxSongList.FormattingEnabled = true;
            this.uxSongList.ItemHeight = 16;
            this.uxSongList.Location = new System.Drawing.Point(500, 381);
            this.uxSongList.Margin = new System.Windows.Forms.Padding(4);
            this.uxSongList.Name = "uxSongList";
            this.uxSongList.Size = new System.Drawing.Size(159, 116);
            this.uxSongList.TabIndex = 8;
            // 
            // uxSongsLabel
            // 
            this.uxSongsLabel.AutoSize = true;
            this.uxSongsLabel.Location = new System.Drawing.Point(497, 360);
            this.uxSongsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxSongsLabel.Name = "uxSongsLabel";
            this.uxSongsLabel.Size = new System.Drawing.Size(48, 17);
            this.uxSongsLabel.TabIndex = 9;
            this.uxSongsLabel.Text = "Songs";
            // 
            // uxProducerLabel
            // 
            this.uxProducerLabel.AutoSize = true;
            this.uxProducerLabel.Location = new System.Drawing.Point(878, 206);
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
            this.uxProducerList.Location = new System.Drawing.Point(878, 227);
            this.uxProducerList.Margin = new System.Windows.Forms.Padding(4);
            this.uxProducerList.Name = "uxProducerList";
            this.uxProducerList.Size = new System.Drawing.Size(159, 116);
            this.uxProducerList.TabIndex = 11;
            // 
            // uxRecordLabelList
            // 
            this.uxRecordLabelList.FormattingEnabled = true;
            this.uxRecordLabelList.ItemHeight = 16;
            this.uxRecordLabelList.Location = new System.Drawing.Point(878, 51);
            this.uxRecordLabelList.Margin = new System.Windows.Forms.Padding(4);
            this.uxRecordLabelList.Name = "uxRecordLabelList";
            this.uxRecordLabelList.Size = new System.Drawing.Size(159, 116);
            this.uxRecordLabelList.TabIndex = 12;
            // 
            // uxPersonList
            // 
            this.uxPersonList.FormattingEnabled = true;
            this.uxPersonList.ItemHeight = 16;
            this.uxPersonList.Location = new System.Drawing.Point(878, 381);
            this.uxPersonList.Margin = new System.Windows.Forms.Padding(4);
            this.uxPersonList.Name = "uxPersonList";
            this.uxPersonList.Size = new System.Drawing.Size(159, 116);
            this.uxPersonList.TabIndex = 13;
            this.uxPersonList.Visible = false;
            // 
            // uxArtistListBox
            // 
            this.uxArtistListBox.FormattingEnabled = true;
            this.uxArtistListBox.ItemHeight = 16;
            this.uxArtistListBox.Location = new System.Drawing.Point(695, 381);
            this.uxArtistListBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxArtistListBox.Name = "uxArtistListBox";
            this.uxArtistListBox.Size = new System.Drawing.Size(159, 116);
            this.uxArtistListBox.TabIndex = 14;
            // 
            // uxRecordLabel
            // 
            this.uxRecordLabel.AutoSize = true;
            this.uxRecordLabel.Location = new System.Drawing.Point(878, 30);
            this.uxRecordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxRecordLabel.Name = "uxRecordLabel";
            this.uxRecordLabel.Size = new System.Drawing.Size(93, 17);
            this.uxRecordLabel.TabIndex = 15;
            this.uxRecordLabel.Text = "Record Label";
            // 
            // uxPersonLabel
            // 
            this.uxPersonLabel.AutoSize = true;
            this.uxPersonLabel.Location = new System.Drawing.Point(878, 360);
            this.uxPersonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPersonLabel.Name = "uxPersonLabel";
            this.uxPersonLabel.Size = new System.Drawing.Size(53, 17);
            this.uxPersonLabel.TabIndex = 16;
            this.uxPersonLabel.Text = "Person";
            this.uxPersonLabel.Visible = false;
            // 
            // uxArtistsLabel
            // 
            this.uxArtistsLabel.AutoSize = true;
            this.uxArtistsLabel.Location = new System.Drawing.Point(692, 360);
            this.uxArtistsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxArtistsLabel.Name = "uxArtistsLabel";
            this.uxArtistsLabel.Size = new System.Drawing.Size(47, 17);
            this.uxArtistsLabel.TabIndex = 17;
            this.uxArtistsLabel.Text = "Artists";
            // 
            // uxLeaveReview
            // 
            this.uxLeaveReview.Enabled = false;
            this.uxLeaveReview.Location = new System.Drawing.Point(172, 467);
            this.uxLeaveReview.Margin = new System.Windows.Forms.Padding(4);
            this.uxLeaveReview.Name = "uxLeaveReview";
            this.uxLeaveReview.Size = new System.Drawing.Size(100, 28);
            this.uxLeaveReview.TabIndex = 18;
            this.uxLeaveReview.Text = "Reviews";
            this.uxLeaveReview.UseVisualStyleBackColor = true;
            this.uxLeaveReview.Click += new System.EventHandler(this.uxLeaveReview_Click);
            // 
            // uxAlbumsLabel
            // 
            this.uxAlbumsLabel.AutoSize = true;
            this.uxAlbumsLabel.Location = new System.Drawing.Point(296, 360);
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
            this.uxAlbumListBox.Location = new System.Drawing.Point(299, 381);
            this.uxAlbumListBox.Margin = new System.Windows.Forms.Padding(4);
            this.uxAlbumListBox.Name = "uxAlbumListBox";
            this.uxAlbumListBox.Size = new System.Drawing.Size(159, 116);
            this.uxAlbumListBox.TabIndex = 19;
            // 
            // uxAddAlbum
            // 
            this.uxAddAlbum.Location = new System.Drawing.Point(11, 52);
            this.uxAddAlbum.Name = "uxAddAlbum";
            this.uxAddAlbum.Size = new System.Drawing.Size(125, 23);
            this.uxAddAlbum.TabIndex = 21;
            this.uxAddAlbum.Text = "Add/Edit Album";
            this.uxAddAlbum.UseVisualStyleBackColor = true;
            this.uxAddAlbum.Click += new System.EventHandler(this.uxAddAlbum_Click);
            // 
            // uxAddArtist
            // 
            this.uxAddArtist.Location = new System.Drawing.Point(147, 52);
            this.uxAddArtist.Name = "uxAddArtist";
            this.uxAddArtist.Size = new System.Drawing.Size(125, 23);
            this.uxAddArtist.TabIndex = 22;
            this.uxAddArtist.Text = "Add Artist";
            this.uxAddArtist.UseVisualStyleBackColor = true;
            this.uxAddArtist.Click += new System.EventHandler(this.uxAddArtist_Click);
            // 
            // uxAddRecordLabel
            // 
            this.uxAddRecordLabel.Location = new System.Drawing.Point(11, 81);
            this.uxAddRecordLabel.Name = "uxAddRecordLabel";
            this.uxAddRecordLabel.Size = new System.Drawing.Size(125, 23);
            this.uxAddRecordLabel.TabIndex = 23;
            this.uxAddRecordLabel.Text = "Add Label";
            this.uxAddRecordLabel.UseVisualStyleBackColor = true;
            this.uxAddRecordLabel.Click += new System.EventHandler(this.uxAddRecordLabel_Click);
            // 
            // uxAddPerson
            // 
            this.uxAddPerson.Location = new System.Drawing.Point(76, 110);
            this.uxAddPerson.Name = "uxAddPerson";
            this.uxAddPerson.Size = new System.Drawing.Size(125, 23);
            this.uxAddPerson.TabIndex = 24;
            this.uxAddPerson.Text = "Add Person";
            this.uxAddPerson.UseVisualStyleBackColor = true;
            this.uxAddPerson.Visible = false;
            this.uxAddPerson.Click += new System.EventHandler(this.uxAddPerson_Click);
            // 
            // uxFocusedList
            // 
            this.uxFocusedList.FormattingEnabled = true;
            this.uxFocusedList.ItemHeight = 16;
            this.uxFocusedList.Location = new System.Drawing.Point(299, 51);
            this.uxFocusedList.Margin = new System.Windows.Forms.Padding(4);
            this.uxFocusedList.Name = "uxFocusedList";
            this.uxFocusedList.Size = new System.Drawing.Size(555, 292);
            this.uxFocusedList.TabIndex = 25;
            // 
            // uxFocus
            // 
            this.uxFocus.AutoSize = true;
            this.uxFocus.Location = new System.Drawing.Point(296, 23);
            this.uxFocus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxFocus.Name = "uxFocus";
            this.uxFocus.Size = new System.Drawing.Size(46, 17);
            this.uxFocus.TabIndex = 26;
            this.uxFocus.Text = "Focus";
            // 
            // uxFocusButtons
            // 
            this.uxFocusButtons.Controls.Add(this.uxPeopleFocus);
            this.uxFocusButtons.Controls.Add(this.uxProducersFocus);
            this.uxFocusButtons.Controls.Add(this.uxLabelsFocus);
            this.uxFocusButtons.Controls.Add(this.uxArtistsFocus);
            this.uxFocusButtons.Controls.Add(this.uxSongsFocus);
            this.uxFocusButtons.Controls.Add(this.uxAlbumsFocus);
            this.uxFocusButtons.Location = new System.Drawing.Point(349, 12);
            this.uxFocusButtons.Name = "uxFocusButtons";
            this.uxFocusButtons.Size = new System.Drawing.Size(505, 32);
            this.uxFocusButtons.TabIndex = 28;
            this.uxFocusButtons.TabStop = false;
            // 
            // uxPeopleFocus
            // 
            this.uxPeopleFocus.AutoSize = true;
            this.uxPeopleFocus.Location = new System.Drawing.Point(432, 6);
            this.uxPeopleFocus.Name = "uxPeopleFocus";
            this.uxPeopleFocus.Size = new System.Drawing.Size(73, 21);
            this.uxPeopleFocus.TabIndex = 5;
            this.uxPeopleFocus.Text = "People";
            this.uxPeopleFocus.UseVisualStyleBackColor = true;
            this.uxPeopleFocus.CheckedChanged += new System.EventHandler(this.uxPeopleFocus_CheckedChanged);
            // 
            // uxProducersFocus
            // 
            this.uxProducersFocus.AutoSize = true;
            this.uxProducersFocus.Location = new System.Drawing.Point(332, 6);
            this.uxProducersFocus.Name = "uxProducersFocus";
            this.uxProducersFocus.Size = new System.Drawing.Size(94, 21);
            this.uxProducersFocus.TabIndex = 4;
            this.uxProducersFocus.Text = "Producers";
            this.uxProducersFocus.UseVisualStyleBackColor = true;
            this.uxProducersFocus.CheckedChanged += new System.EventHandler(this.uxProducersFocus_CheckedChanged);
            // 
            // uxLabelsFocus
            // 
            this.uxLabelsFocus.AutoSize = true;
            this.uxLabelsFocus.Location = new System.Drawing.Point(255, 6);
            this.uxLabelsFocus.Name = "uxLabelsFocus";
            this.uxLabelsFocus.Size = new System.Drawing.Size(71, 21);
            this.uxLabelsFocus.TabIndex = 3;
            this.uxLabelsFocus.Text = "Labels";
            this.uxLabelsFocus.UseVisualStyleBackColor = true;
            this.uxLabelsFocus.CheckedChanged += new System.EventHandler(this.uxLabelsFocus_CheckedChanged);
            // 
            // uxArtistsFocus
            // 
            this.uxArtistsFocus.AutoSize = true;
            this.uxArtistsFocus.Location = new System.Drawing.Point(181, 6);
            this.uxArtistsFocus.Name = "uxArtistsFocus";
            this.uxArtistsFocus.Size = new System.Drawing.Size(68, 21);
            this.uxArtistsFocus.TabIndex = 2;
            this.uxArtistsFocus.Text = "Artists";
            this.uxArtistsFocus.UseVisualStyleBackColor = true;
            this.uxArtistsFocus.CheckedChanged += new System.EventHandler(this.uxArtistsFocus_CheckedChanged);
            // 
            // uxSongsFocus
            // 
            this.uxSongsFocus.AutoSize = true;
            this.uxSongsFocus.Location = new System.Drawing.Point(106, 6);
            this.uxSongsFocus.Name = "uxSongsFocus";
            this.uxSongsFocus.Size = new System.Drawing.Size(69, 21);
            this.uxSongsFocus.TabIndex = 1;
            this.uxSongsFocus.Text = "Songs";
            this.uxSongsFocus.UseVisualStyleBackColor = true;
            this.uxSongsFocus.CheckedChanged += new System.EventHandler(this.uxSongsFocus_CheckedChanged);
            // 
            // uxAlbumsFocus
            // 
            this.uxAlbumsFocus.AutoSize = true;
            this.uxAlbumsFocus.Location = new System.Drawing.Point(25, 6);
            this.uxAlbumsFocus.Name = "uxAlbumsFocus";
            this.uxAlbumsFocus.Size = new System.Drawing.Size(75, 21);
            this.uxAlbumsFocus.TabIndex = 0;
            this.uxAlbumsFocus.Text = "Albums";
            this.uxAlbumsFocus.UseVisualStyleBackColor = true;
            this.uxAlbumsFocus.CheckedChanged += new System.EventHandler(this.uxAlbumsFocus_CheckedChanged);
            // 
            // uxAggQueryName
            // 
            this.uxAggQueryName.Location = new System.Drawing.Point(13, 316);
            this.uxAggQueryName.Margin = new System.Windows.Forms.Padding(4);
            this.uxAggQueryName.Name = "uxAggQueryName";
            this.uxAggQueryName.Size = new System.Drawing.Size(261, 22);
            this.uxAggQueryName.TabIndex = 29;
            this.uxAggQueryName.Text = "Look up name";
            // 
            // uxStartDate
            // 
            this.uxStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxStartDate.Location = new System.Drawing.Point(13, 377);
            this.uxStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.uxStartDate.Name = "uxStartDate";
            this.uxStartDate.Size = new System.Drawing.Size(102, 22);
            this.uxStartDate.TabIndex = 30;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 355);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 17);
            this.label.TabIndex = 31;
            this.label.Text = "Start Date:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "End Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxEndDate
            // 
            this.uxEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxEndDate.Location = new System.Drawing.Point(146, 376);
            this.uxEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.uxEndDate.Name = "uxEndDate";
            this.uxEndDate.Size = new System.Drawing.Size(102, 22);
            this.uxEndDate.TabIndex = 33;
            // 
            // uxTopGenreInput
            // 
            this.uxTopGenreInput.Location = new System.Drawing.Point(252, 164);
            this.uxTopGenreInput.Margin = new System.Windows.Forms.Padding(2);
            this.uxTopGenreInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.uxTopGenreInput.Name = "uxTopGenreInput";
            this.uxTopGenreInput.Size = new System.Drawing.Size(40, 22);
            this.uxTopGenreInput.TabIndex = 34;
            this.uxTopGenreInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 507);
            this.Controls.Add(this.uxTopGenreInput);
            this.Controls.Add(this.uxEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.uxStartDate);
            this.Controls.Add(this.uxAggQueryName);
            this.Controls.Add(this.uxFocusButtons);
            this.Controls.Add(this.uxFocus);
            this.Controls.Add(this.uxFocusedList);
            this.Controls.Add(this.uxAddPerson);
            this.Controls.Add(this.uxAddRecordLabel);
            this.Controls.Add(this.uxAddArtist);
            this.Controls.Add(this.uxAddAlbum);
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
            this.Controls.Add(this.uxAddProducer);
            this.Controls.Add(this.uxRecordLabelAlbums);
            this.Controls.Add(this.uxLookUpText);
            this.Controls.Add(this.uxUserLabel);
            this.Controls.Add(this.uxSuperFans);
            this.Controls.Add(this.uxArtistAlbums);
            this.Controls.Add(this.uxTopGenres);
            this.Controls.Add(this.uxLogIn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Text = "GoodVibes.exe";
            this.uxFocusButtons.ResumeLayout(false);
            this.uxFocusButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxTopGenreInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxLogIn;
        private System.Windows.Forms.Button uxTopGenres;
        private System.Windows.Forms.Button uxArtistAlbums;
        private System.Windows.Forms.Button uxSuperFans;
        private System.Windows.Forms.Label uxUserLabel;
        private System.Windows.Forms.TextBox uxLookUpText;
        private System.Windows.Forms.Button uxRecordLabelAlbums;
        private System.Windows.Forms.Button uxAddProducer;
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
        private System.Windows.Forms.Button uxAddAlbum;
        private System.Windows.Forms.Button uxAddArtist;
        private System.Windows.Forms.Button uxAddRecordLabel;
        private System.Windows.Forms.Button uxAddPerson;
        private System.Windows.Forms.ListBox uxFocusedList;
        private System.Windows.Forms.Label uxFocus;
        private System.Windows.Forms.GroupBox uxFocusButtons;
        private System.Windows.Forms.RadioButton uxPeopleFocus;
        private System.Windows.Forms.RadioButton uxProducersFocus;
        private System.Windows.Forms.RadioButton uxLabelsFocus;
        private System.Windows.Forms.RadioButton uxArtistsFocus;
        private System.Windows.Forms.RadioButton uxSongsFocus;
        private System.Windows.Forms.RadioButton uxAlbumsFocus;
        private System.Windows.Forms.TextBox uxAggQueryName;
        private System.Windows.Forms.DateTimePicker uxStartDate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker uxEndDate;
        private System.Windows.Forms.NumericUpDown uxTopGenreInput;
    }
}
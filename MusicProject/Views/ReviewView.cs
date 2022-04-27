using MusicProject.Models;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace MusicProject.Views
{
    public partial class ReviewView : Form
    {
        private static GetReviews get;
        private static FetchReview fetch;
        private static CreateOrSaveReview save;

        AlbumModel album;
        UserModel user;
        ReviewModel activeReview;

        public ReviewView(AlbumModel album, UserModel user)
        {
            InitializeComponent();
            this.album = album;
            this.user = user;
            uxReviewsForLabel.Text = "Reviews for " + album.Title;
            uxReviewsList.DataSource = get(album);
        }
        public static void InitializeDelegates(GetReviews getRev, FetchReview fetchRev, CreateOrSaveReview saveRev)
        {
            get = getRev;
            fetch = fetchRev;
            save = saveRev;
        }

        private void uxReviewsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeReview = (ReviewModel)uxReviewsList.SelectedItem;
            uxIndividualTextLabel.Text = "Review by " + activeReview.UserName;
            uxComment.Text = activeReview.Comment;
            uxRatingText.Text = activeReview.Rating.ToString();
            if (activeReview.UserName.Equals(user.Name))
            {
                uxSaveButton.Enabled = true;
                uxComment.ReadOnly = false;
                uxRatingText.ReadOnly = false;
            }
            else
            {
                uxSaveButton.Enabled = false;
                uxComment.ReadOnly = true;
                uxRatingText.ReadOnly = true;
            }
        }

        private void uxGetReviewButton_Click(object sender, EventArgs e)
        {
            activeReview = fetch(user.Name);
            uxIndividualTextLabel.Text = "Review by " + user.Name;

            if (activeReview != null)
            {
                uxComment.Text = activeReview.Comment;
                uxRatingText.Text = activeReview.Rating.ToString();
            }
            else
            {
                uxComment.Text = "";
                uxRatingText.Text = "5.0";
            }

            uxSaveButton.Enabled = true;
            uxComment.ReadOnly = false;
            uxRatingText.ReadOnly = false;
        }

        private void uxSaveButton_Click(object sender, EventArgs e)
        {
            bool newRev = false;
            if (activeReview == null && fetch(user.Name) == null)
            {
                var temp = DateTime.Now;
                if(Decimal.TryParse(uxRatingText.Text, out var temp2))
                activeReview = new ReviewModel(user.Name, album.Title, uxComment.Text, temp2, temp);
                newRev = true;
            }
            
            save(activeReview, newRev);
            uxReviewsList.DataSource = get(album);
        }

        private void uxCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

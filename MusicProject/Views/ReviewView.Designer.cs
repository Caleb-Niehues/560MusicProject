
namespace MusicProject.Views
{
    partial class ReviewView
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
            this.uxReviewsForLabel = new System.Windows.Forms.Label();
            this.uxReviewsList = new System.Windows.Forms.ListBox();
            this.uxComment = new System.Windows.Forms.TextBox();
            this.uxIndividualTextLabel = new System.Windows.Forms.Label();
            this.uxGetReviewButton = new System.Windows.Forms.Button();
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.uxCloseButton = new System.Windows.Forms.Button();
            this.uxRatingText = new System.Windows.Forms.TextBox();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxReviewsForLabel
            // 
            this.uxReviewsForLabel.AutoSize = true;
            this.uxReviewsForLabel.Location = new System.Drawing.Point(12, 17);
            this.uxReviewsForLabel.Name = "uxReviewsForLabel";
            this.uxReviewsForLabel.Size = new System.Drawing.Size(85, 17);
            this.uxReviewsForLabel.TabIndex = 0;
            this.uxReviewsForLabel.Text = "Reviews for:";
            // 
            // uxReviewsList
            // 
            this.uxReviewsList.FormattingEnabled = true;
            this.uxReviewsList.ItemHeight = 16;
            this.uxReviewsList.Location = new System.Drawing.Point(15, 44);
            this.uxReviewsList.Name = "uxReviewsList";
            this.uxReviewsList.Size = new System.Drawing.Size(305, 340);
            this.uxReviewsList.TabIndex = 1;
            this.uxReviewsList.SelectedIndexChanged += new System.EventHandler(this.uxReviewsList_SelectedIndexChanged);
            // 
            // uxComment
            // 
            this.uxComment.Location = new System.Drawing.Point(344, 44);
            this.uxComment.Multiline = true;
            this.uxComment.Name = "uxComment";
            this.uxComment.ReadOnly = true;
            this.uxComment.Size = new System.Drawing.Size(417, 340);
            this.uxComment.TabIndex = 2;
            // 
            // uxIndividualTextLabel
            // 
            this.uxIndividualTextLabel.AutoSize = true;
            this.uxIndividualTextLabel.Location = new System.Drawing.Point(341, 17);
            this.uxIndividualTextLabel.Name = "uxIndividualTextLabel";
            this.uxIndividualTextLabel.Size = new System.Drawing.Size(120, 17);
            this.uxIndividualTextLabel.TabIndex = 3;
            this.uxIndividualTextLabel.Text = "Review by [NULL]";
            // 
            // uxGetReviewButton
            // 
            this.uxGetReviewButton.Location = new System.Drawing.Point(344, 390);
            this.uxGetReviewButton.Name = "uxGetReviewButton";
            this.uxGetReviewButton.Size = new System.Drawing.Size(137, 40);
            this.uxGetReviewButton.TabIndex = 4;
            this.uxGetReviewButton.Text = "Get Your Review";
            this.uxGetReviewButton.UseVisualStyleBackColor = true;
            this.uxGetReviewButton.Click += new System.EventHandler(this.uxGetReviewButton_Click);
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Enabled = false;
            this.uxSaveButton.Location = new System.Drawing.Point(487, 390);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(131, 40);
            this.uxSaveButton.TabIndex = 5;
            this.uxSaveButton.Text = "Save Changes";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // uxCloseButton
            // 
            this.uxCloseButton.Enabled = false;
            this.uxCloseButton.Location = new System.Drawing.Point(624, 390);
            this.uxCloseButton.Name = "uxCloseButton";
            this.uxCloseButton.Size = new System.Drawing.Size(137, 40);
            this.uxCloseButton.TabIndex = 6;
            this.uxCloseButton.Text = "Close Page";
            this.uxCloseButton.UseVisualStyleBackColor = true;
            this.uxCloseButton.Click += new System.EventHandler(this.uxCloseButton_Click);
            // 
            // uxRatingText
            // 
            this.uxRatingText.Location = new System.Drawing.Point(727, 17);
            this.uxRatingText.Name = "uxRatingText";
            this.uxRatingText.Size = new System.Drawing.Size(34, 22);
            this.uxRatingText.TabIndex = 7;
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Location = new System.Drawing.Point(672, 17);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(53, 17);
            this.uxRatingLabel.TabIndex = 8;
            this.uxRatingLabel.Text = "Rating:";
            // 
            // ReviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.uxRatingText);
            this.Controls.Add(this.uxCloseButton);
            this.Controls.Add(this.uxSaveButton);
            this.Controls.Add(this.uxGetReviewButton);
            this.Controls.Add(this.uxIndividualTextLabel);
            this.Controls.Add(this.uxComment);
            this.Controls.Add(this.uxReviewsList);
            this.Controls.Add(this.uxReviewsForLabel);
            this.Name = "ReviewView";
            this.Text = "ReviewView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxReviewsForLabel;
        private System.Windows.Forms.ListBox uxReviewsList;
        private System.Windows.Forms.TextBox uxComment;
        private System.Windows.Forms.Label uxIndividualTextLabel;
        private System.Windows.Forms.Button uxGetReviewButton;
        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.Button uxCloseButton;
        private System.Windows.Forms.TextBox uxRatingText;
        private System.Windows.Forms.Label uxRatingLabel;
    }
}
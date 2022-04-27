using System;

namespace MusicProject.Models
{
    /// <summary>
    /// Model of a album review
    /// </summary>
    public class ReviewModel
    {
        #region Basic Fields
        /// <summary>
        /// 
        /// </summary>
        private string _userName;

        /// <summary>
        /// user of the review
        /// </summary>
        public string UserName => _userName;

        /// <summary>
        /// 
        /// </summary>
        private string _albumTitle;

        /// <summary>
        /// album that is being reviewed
        /// </summary>
        public string AlbumTitle => _albumTitle;

        /// <summary>
        /// 
        /// </summary>
        private string _comment;//needs to be nullable - though the empty string could suffice

        /// <summary>
        /// comments made on the review by the user
        /// </summary>
        public string Comment => _comment;

        /// <summary>
        /// 
        /// </summary>
        private decimal _rating;

        /// <summary>
        /// rating of the album by the user
        /// </summary>
        public decimal Rating => _rating;

        /// <summary>
        /// 
        /// </summary>
        private DateTime _dateAdded;

        /// <summary>
        /// time and date of when the review was added
        /// </summary>
        public DateTime DateAdded => _dateAdded;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _dateDeleted;

        /// <summary>
        /// time and date of when the review was deleted
        /// </summary>
        public DateTime? DateDeleted => _dateDeleted;
        #endregion

        public ReviewModel(string userName, string albumTitle, string comment, decimal rating, DateTime dateAdded)
        {
            this._userName = userName;
            this._albumTitle = albumTitle;
            this._comment = comment;
            this._rating = rating;
            this._dateAdded = dateAdded;
        }

        public override string ToString()
        {
            return Rating.ToString() + " - " + UserName + " - " + DateAdded.ToString();
        }
    }
}

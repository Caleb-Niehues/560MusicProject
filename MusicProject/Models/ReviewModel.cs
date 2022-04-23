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
        private int _ID;

        /// <summary>
        /// Id number of the review
        /// </summary>
        public int ID => _ID;

        /// <summary>
        /// 
        /// </summary>
        private UserModel _user;

        /// <summary>
        /// user of the review
        /// </summary>
        public UserModel User => _user;

        /// <summary>
        /// 
        /// </summary>
        private AlbumModel _album;

        /// <summary>
        /// album that is being reviewed
        /// </summary>
        public AlbumModel Album => _album;

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

        public ReviewModel(UserModel user, AlbumModel album, string comment, decimal rating, DateTime dateAdded)
        {
            this._user = user;
            this._album = album;
            this._comment = comment;
            this._rating = rating;
            this._dateAdded = dateAdded;
        }
    }
}

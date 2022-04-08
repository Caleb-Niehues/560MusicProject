using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    /// <summary>
    /// Model of a album review
    /// </summary>
    public class ReviewModel
    {
        /// <summary>
        /// Id number of the review
        /// </summary>
        private int _ID;

        /// <summary>
        /// user of the review
        /// </summary>
        private UserModel _user;

        /// <summary>
        /// album that is being reviewed
        /// </summary>
        private AlbumModel _album;

        /// <summary>
        /// comments made on the review by the user
        /// </summary>
        private string _comment;//needs to be nullable - though the empty string could suffice

        /// <summary>
        /// rating of the album by the user
        /// </summary>
        private decimal _Rating;

        /// <summary>
        /// time and date of when the review was added
        /// </summary>
        private DateTime _dateAdded;

        /// <summary>
        /// time and date of when the review was deleted
        /// </summary>
        private DateTime? _dateDeleted;
    }
}

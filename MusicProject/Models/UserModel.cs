using System;

namespace MusicProject.Models
{
    /// <summary>
    /// model for the user
    /// </summary>
    public class UserModel
    {
        #region Basic Fields
        /// <summary>
        /// 
        /// </summary>
        private int _ID;

        /// <summary>
        /// ID number of the user
        /// </summary>
        public int ID => _ID;

        /// <summary>
        /// 
        /// </summary>
        private int _weight;

        /// <summary>
        /// how important the user is to the industry, bigger the number the more important they are
        /// </summary>
        public int Weight => _weight;

        /// <summary>
        /// 
        /// </summary>
        private string _name;

        /// <summary>
        /// username of the user
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 
        /// </summary>
        private string _password;

        /// <summary>
        /// The user's password - not at all how it actually should be done, this would only be server-side hash info in practice
        /// </summary>
        public string Password => Password;

        /// <summary>
        /// 
        /// </summary>
        private DateTime _dateAdded;

        /// <summary>
        /// date an time a post was added by the user
        /// </summary>
        public DateTime DateAdded => _dateAdded;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _dateDeleted;

        /// <summary>
        /// date and time a post was deleted by the user, hasn't been deleted if null
        /// </summary>
        public DateTime? DateDeleted => _dateDeleted;
        #endregion
    }
}

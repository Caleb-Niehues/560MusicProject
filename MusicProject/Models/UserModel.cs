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
        private string _name;

        /// <summary>
        /// username of the user
        /// </summary>
        public string Name => _name;

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
        private DateTime _dateAdded;

        /// <summary>
        /// date an time a post was added by the user
        /// </summary>
        public DateTime DateAdded => _dateAdded;
        #endregion

        public UserModel(string name, int weight, DateTime dateAdded)
        {
            this._name = name;
            this._weight = weight;
            this._dateAdded = dateAdded;
        }
    }
}

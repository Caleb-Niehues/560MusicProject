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
        protected string _name;

        /// <summary>
        /// username of the user
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 
        /// </summary>
        protected int _weight;

        /// <summary>
        /// how important the user is to the industry, bigger the number the more important they are
        /// </summary>
        public int Weight => _weight;

        /// <summary>
        /// 
        /// </summary>
        protected DateTime _dateAdded;

        /// <summary>
        /// date an time a post was added by the user
        /// </summary>
        public DateTime DateAdded => _dateAdded;
        #endregion

        /// <summary>
        /// The constructor used in CreateUser
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        public UserModel(string name, int weight)
        {
            this._name = name;
            this._weight = weight;
            this._dateAdded = DateTime.Now;
        }

        /// <summary>
        /// The constructor used in FetchUser - date time is prepopulated
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="dateAdded"></param>
        public UserModel(string name, int weight, DateTime dateAdded)
        {
            this._name = name;
            this._weight = weight;
            this._dateAdded = dateAdded;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

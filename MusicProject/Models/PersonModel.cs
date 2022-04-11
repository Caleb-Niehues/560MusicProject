using System;

namespace MusicProject.Models
{
    /// <summary>
    /// Model class for a person
    /// </summary>
    public class PersonModel
    {
        #region Basic Fields
        /// <summary>
        /// 
        /// </summary>
        private int _ID;

        /// <summary>
        /// ID number of the person
        /// </summary>
        public int ID => _ID;

        /// <summary>
        /// 
        /// </summary>
        private string _name;

        /// <summary>
        /// name of the person
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 
        /// </summary>
        private DateTime _birthDate;

        /// <summary>
        /// birthday of the artist
        /// </summary>
        public DateTime BirthDate => _birthDate;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _deathDate;

        /// <summary>
        /// death date of the artist (nullable)
        /// </summary>
        public DateTime? DeathDate => _deathDate;

        /// <summary>
        /// 
        /// </summary>
        private string _homeRegion;

        /// <summary>
        /// hometown/home region of the artist
        /// </summary>
        public string HomeRegion => _homeRegion;
        #endregion
    }
}

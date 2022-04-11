using System.Collections.Generic;

namespace MusicProject.Models
{
    /// <summary>
    /// model class for an artist
    /// </summary>
    public class ArtistModel
    {
        /// <summary>
        /// 
        /// </summary>
        private int _ID;

        /// <summary>
        /// ID number for an artist
        /// </summary>
        public int ID => _ID;

        /// <summary>
        /// 
        /// </summary>
        private string _name;

        /// <summary>
        /// name of an artist
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 
        /// </summary>
        private List<PersonModel> _members;

        /// <summary>
        /// the members in the artist group or the artist person himself
        /// </summary>
        public List<PersonModel> Members => _members;
    }
}

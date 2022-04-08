using System.Collections.Generic;

namespace MusicProject.Models
{
    /// <summary>
    /// model class for an artist
    /// </summary>
    public class ArtistModel
    {
        /// <summary>
        /// ID number for an artist
        /// </summary>
        private int _ID;

        /// <summary>
        /// name of an artist
        /// </summary>
        private string _name;

        /// <summary>
        /// the members in the artist group or the artist person himself
        /// </summary>
        private List<PersonModel> _members;
    }
}

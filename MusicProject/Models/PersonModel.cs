using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    /// <summary>
    /// Model class for a person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// ID number of the person
        /// </summary>
        private int _ID;

        /// <summary>
        /// name of the person
        /// </summary>
        private string _name;

        /// <summary>
        /// birthday of the artist
        /// </summary>
        private DateTime _birthDate;

        /// <summary>
        /// death date of the artist (nullable)
        /// </summary>
        private DateTime? _deathDate;

        /// <summary>
        /// hometown/home region of the artist
        /// </summary>
        private string HomeRegion;
    }
}

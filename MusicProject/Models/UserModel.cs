using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    /// <summary>
    /// model for the user
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// ID number of the user
        /// </summary>

        private int _ID;

        /// <summary>
        /// how important the user is to the industry, bigger the number the more important they are
        /// </summary>

        private int _weight;

        /// <summary>
        /// username of the user
        /// </summary>
        private string _name;

        /// <summary>
        /// password of the user
        /// </summary>
        private string _password;

        /// <summary>
        /// date an time a post was added by the user
        /// </summary>
        private DateTime _dateAdded;

        /// <summary>
        /// date and time a post was deleted by the user
        /// </summary>
        private DateTime? _dateDeleted;
    }
}

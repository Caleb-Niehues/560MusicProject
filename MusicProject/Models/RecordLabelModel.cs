using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    /// <summary>
    /// model of a record label
    /// </summary>
    public class RecordLabelModel
    {
        /// <summary>
        /// ID number of a record label
        /// </summary>
        private int _ID;

        /// <summary>
        /// name of the record label
        /// </summary>
        private string _name;

        /// <summary>
        /// founding date of the record label
        /// </summary>
        private DateTime _dateFounded;

        /// <summary>
        /// closing time of the record label, could be nullable
        /// </summary>
        private DateTime? _dateClosed;

        /// <summary>
        /// location of the record label
        /// </summary>
        private string _location;
    }
}

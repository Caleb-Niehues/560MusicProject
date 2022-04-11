using System;

namespace MusicProject.Models
{
    /// <summary>
    /// model of a record label
    /// </summary>
    public class RecordLabelModel
    {
        /// <summary>
        /// 
        /// </summary>
        private int _ID;

        /// <summary>
        /// ID number of a record label
        /// </summary>
        public int ID => _ID;

        /// <summary>
        /// 
        /// </summary>
        private string _name;

        /// <summary>
        /// name of the record label
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 
        /// </summary>
        private DateTime _dateFounded;

        /// <summary>
        /// founding date of the record label
        /// </summary>
        public DateTime DateFounded => _dateFounded;

        /// <summary>
        /// 
        /// </summary>
        private DateTime? _dateClosed;

        /// <summary>
        /// closing time of the record label, could be nullable
        /// </summary>
        public DateTime? DateClosed => _dateClosed;

        /// <summary>
        /// 
        /// </summary>
        private string _location;

        /// <summary>
        /// location of the record label, might turn into a home region model and refactor this and person homeregion
        /// </summary>
        public string Location => _location;
    }
}

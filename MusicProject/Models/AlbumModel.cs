using System;
using System.Collections.Generic;

namespace MusicProject.Models
{
    /// <summary>
    /// model class for an album
    /// </summary>
    public class AlbumModel
    {
        #region Basic Fields
        /// <summary>
        /// backing field for ID
        /// </summary>
        private int _ID;

        /// <summary>
        /// ID number of the album
        /// </summary>
        public int ID => _ID;

        /// <summary>
        /// 
        /// </summary>
        private string _title;

        /// <summary>
        /// title of the album
        /// </summary>
        public string Title => _title;

        /// <summary>
        /// 
        /// </summary>
        private DateTime _releaseDate;

        /// <summary>
        /// release date of an album
        /// </summary>
        public DateTime ReleaseDate => _releaseDate;

        /// <summary>
        /// 
        /// </summary>
        private ArtistModel _artist;

        /// <summary>
        /// artist of the album
        /// </summary>
        public ArtistModel Artist => _artist;

        /// <summary>
        /// 
        /// </summary>
        private List<ProducerModel> _producers;

        /// <summary>
        /// list of all producers involved in the album
        /// </summary>
        public List<ProducerModel> Producers => _producers;

        /// <summary>
        /// 
        /// </summary>
        private Certification _certification; //might become an enum

        /// <summary>
        /// certification of the album
        /// </summary>
        public Certification Certification => _certification;
        #endregion

        public AlbumModel()
        {
            
        }
    }
}

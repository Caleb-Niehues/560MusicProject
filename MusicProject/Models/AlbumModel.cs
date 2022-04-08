using System;
using System.Collections.Generic;

namespace MusicProject.Models
{
    /// <summary>
    /// model class for an album
    /// </summary>
    public class AlbumModel
    {
        /// <summary>
        /// ID number of the album
        /// </summary>
        private int _ID;

        /// <summary>
        /// title of the album
        /// </summary>
        private string _title;

        /// <summary>
        /// release date of an album
        /// </summary>
        private DateTime _releaseDate;

        /// <summary>
        /// artist of the album
        /// </summary>
        private ArtistModel _artist;

        /// <summary>
        /// list of all producers involved in the album
        /// </summary>
        private List<ProducerModel> _producers;

        /// <summary>
        /// certification of the album
        /// </summary>
        private CertificationModel certification; //might become an enum
        
    }
}

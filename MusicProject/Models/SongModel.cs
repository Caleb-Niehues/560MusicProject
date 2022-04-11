using System;

namespace MusicProject.Models
{
    /// <summary>
    /// model class of the song
    /// </summary>
    public class SongModel
    {
        #region Basic Fields
        /// <summary>
        /// 
        /// </summary>
        private int _ID;

        /// <summary>
        /// ID number for the song
        /// </summary>
        public int ID => _ID;

        /// <summary>
        /// 
        /// </summary>
        private string _name;

        /// <summary>
        /// name of the song
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// 
        /// </summary>
        private AlbumModel _album;

        /// <summary>
        /// album from where the song comes from, perhaps have a list of songs in the album class instead?
        /// </summary>
        public AlbumModel Album => _album;

        /// <summary>
        /// 
        /// </summary>
        private Genre _genre; //might end up being enum

        /// <summary>
        /// genre from where the song comes from
        /// </summary>
        public Genre Genre => _genre;

        /// <summary>
        /// 
        /// </summary>
        private TimeSpan _length;

        /// <summary>
        /// time length of the song
        /// </summary>
        public TimeSpan Length => _length;

        /// <summary>
        /// 
        /// </summary>
        private int _trackNumber;

        /// <summary>
        /// number of the song on the album, possibly redundant with a procedurally generated ID
        /// </summary>
        public int TrackNumber => _trackNumber;
        #endregion
    }
}

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
        private string _artist;

        /// <summary>
        /// artist of the song
        /// </summary>
        public string Artist => _artist;

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
        private string _albumName;

        /// <summary>
        /// album from where the song comes from, perhaps have a list of songs in the album class instead?
        /// </summary>
        public string AlbumName => _albumName;

        /// <summary>
        /// 
        /// </summary>
        private Genre _genre;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="album"></param>
        /// <param name="genre"></param>
        /// <param name="length"></param>
        public SongModel(string name, string album, string artist, Genre genre, TimeSpan length)
        {
            this._name = name;
            this._albumName = album;
            this._artist = artist;
            this._genre = genre;
            this._length = length;
        }

        public override string ToString()
        {
            return $"{Name} - {AlbumName} - " +
                $"{Artist} - {Enum.GetName(typeof(Genre), this.Genre)} - {Length}";
        }
    }
}

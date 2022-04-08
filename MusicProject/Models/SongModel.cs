using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    /// <summary>
    /// model class of the song
    /// </summary>
    public class SongModel
    {
        /// <summary>
        /// ID number for the song
        /// </summary>
        private int _ID;

        /// <summary>
        /// name of the song
        /// </summary>
        private string _name;

        /// <summary>
        /// album from where the song comes from
        /// </summary>
        private AlbumModel _album;

        /// <summary>
        /// genre from where the song comes from
        /// </summary>
        private GenreModel _genre; //might end up being enum

        /// <summary>
        /// time length of the song
        /// </summary>
        private TimeSpan _length;

        /// <summary>
        /// number of the song on the album
        /// </summary>
        private int _trackNumber;
    }
}

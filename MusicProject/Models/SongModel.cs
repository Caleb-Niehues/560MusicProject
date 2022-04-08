using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    public class SongModel
    {
        private int _songID;

        private string _songName;

        private AlbumModel _album;

        private GenreModel _genre; //might end up being enum

        private TimeSpan _length;

        private int _trackNumber;
    }
}

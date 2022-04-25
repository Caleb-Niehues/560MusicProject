using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface ISongRepo
    {
        IReadOnlyList<SongModel> FetchSong(string name);

        /// <summary>
        /// maybe have an override that retrieves all for an artist?
        /// </summary>
        /// <param name="albumName"></param>
        /// <returns></returns>
        IReadOnlyList<SongModel> RetrieveSongs(string albumName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="album"></param>
        /// <param name="genre"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        SongModel CreateSong(string name, string album, Genre genre, TimeSpan length, int trackNumber);
    }
}

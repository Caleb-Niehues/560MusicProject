﻿using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public class SqlSongRepo : ISongRepo
    {
        public SongModel CreateSong(string name, AlbumModel album, Genre genre, TimeSpan length)
        {
            throw new NotImplementedException();
        }

        public SongModel FetchSong(string name)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<SongModel> RetrieveSongs(string albumName)
        {
            throw new NotImplementedException();
        }
    }
}

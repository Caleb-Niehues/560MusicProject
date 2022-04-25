using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace MusicProject.Repositories
{
    public class SqlAlbumRepo : IAlbumRepo
    {
        private readonly string connectionString;

        public SqlAlbumRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public AlbumModel CreateAlbum(string title, DateTime releaseDate, ArtistModel artist, List<SongModel> songs, TimeSpan length, List<ProducerModel> producers, List<RecordLabelModel> recordLabels, Certification certification)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(title));

            throw new NotImplementedException();
            //FINISH
        }

        public AlbumModel FetchAlbum(string name)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<AlbumModel> GetBestPerforming(DateTime startYear, DateTime endYear, int number)
        {
            throw new NotImplementedException();
        }
    }
}

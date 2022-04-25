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
            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.FetchAlbum", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateFetchAlbum(reader);
                    }
                }
            }
        }

        private AlbumModel TranslateFetchAlbum(SqlDataReader reader)
        {
            var albumTitleOrdinal = reader.GetOrdinal("AlbumTitle");
            var releaseDateOrdinal = reader.GetOrdinal("ReleaseDate");
            var artistNameOrdinal = reader.GetOrdinal("ArtistName");
            var songNameOrdinal = reader.GetOrdinal("SongName");
            var songLengthOrdinal = reader.GetOrdinal("Length");
            var producerNameOrdinal = reader.GetOrdinal("ProducerName");
            var recordLabelNameOrdinal = reader.GetOrdinal("RecordLabelName");
            var certificationOrdinal = reader.GetOrdinal("CertificationName");
            var genreNameOrdinal = reader.GetOrdinal("GenreName");
            var labelDateFoundedOrdinal = reader.GetOrdinal("DateFounded");
            var labelDateClosedOrdinal = reader.GetOrdinal("DateClosed"); 
            var labelLocationOrdinal = reader.GetOrdinal("RecordLabelLocation"); 

            List<SongModel> songs = new List<SongModel>();
            TimeSpan length = new TimeSpan();
            List<ProducerModel> producers = new List<ProducerModel>();
            List<RecordLabelModel> recordLabels = new List<RecordLabelModel>();
            while (reader.Read())
            {
                songs.Add(new SongModel(reader.GetString(songNameOrdinal), reader.GetString(albumTitleOrdinal),
                    reader.GetString(artistNameOrdinal), (Genre)Enum.Parse(typeof(Genre), reader.GetString(genreNameOrdinal)),
                    reader.GetTimeSpan(songLengthOrdinal)));
                length += reader.GetTimeSpan(songLengthOrdinal);
                producers.Add(new ProducerModel(reader.GetString(producerNameOrdinal)));
                recordLabels.Add(new RecordLabelModel(reader.GetString(recordLabelNameOrdinal), reader.GetDateTime(labelDateFoundedOrdinal),
                    reader.GetDateTime(labelDateClosedOrdinal), reader.GetString(labelLocationOrdinal)));
            }

            return new AlbumModel(reader.GetString(albumTitleOrdinal), reader.GetDateTime(releaseDateOrdinal), new ArtistModel(reader.GetString(artistNameOrdinal), null),
                songs, length, producers, recordLabels, (Certification)Enum.Parse(typeof(Certification), reader.GetString(certificationOrdinal)));
        }

        public IReadOnlyList<AlbumModel> GetBestPerforming(DateTime startYear, DateTime endYear, int number)
        {
            throw new NotImplementedException();
        }
    }
}

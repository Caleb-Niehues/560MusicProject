using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        public IReadOnlyList<AlbumModel> FetchAlbum(string name)
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

        private IReadOnlyList<AlbumModel> TranslateFetchAlbum(SqlDataReader reader)
        {
            var albums = new Dictionary<string, AlbumModel>();
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
            Dictionary<string, ProducerModel> producers = new Dictionary<string, ProducerModel>();
            Dictionary<string, RecordLabelModel> recordLabels = new Dictionary<string, RecordLabelModel>();
            string title = null;
            DateTime releaseDate = DateTime.Now;
            ArtistModel artist = null;
            Certification certification = Certification.None;

            while (reader.Read())
            {
                title = reader.GetString(albumTitleOrdinal);
                releaseDate = reader.GetDateTime(releaseDateOrdinal);
                artist = new ArtistModel(reader.GetString(artistNameOrdinal), null);
                certification = (Certification)Enum.Parse(typeof(Certification), reader.GetString(certificationOrdinal));
                string producer = reader.GetString(producerNameOrdinal);
                string recordLabel = reader.GetString(recordLabelNameOrdinal);

                songs.Add(new SongModel(reader.GetString(songNameOrdinal), title,
                    artist.ToString(), (Genre)Enum.Parse(typeof(Genre), reader.GetString(genreNameOrdinal)),
                    reader.GetTimeSpan(songLengthOrdinal)));
                length += reader.GetTimeSpan(songLengthOrdinal);

                if (!producers.ContainsKey(producer)) producers.Add(producer, new ProducerModel(producer));

                if (!recordLabels.ContainsKey(recordLabel)) 
                {
                    recordLabels.Add(recordLabel, new RecordLabelModel(recordLabel, reader.GetDateTime(labelDateFoundedOrdinal),
                        reader.GetDateTime(labelDateClosedOrdinal), reader.GetString(labelLocationOrdinal)));
                }
                
                if (!albums.ContainsKey(title))
                {
                    albums.Add(title, new AlbumModel(title, releaseDate, artist, songs, length, 
                        producers.Values.ToList<ProducerModel>(), recordLabels.Values.ToList<RecordLabelModel>(), certification));

                }
            }
            return albums.Values.ToList<AlbumModel>();
           }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startYear">can be left null to see best seller since earliest time </param>
        /// <param name="endYear">can be left null to count as this year</param>
        /// <param name="number">number of albums displayed</param>
        /// <returns></returns>
        public IReadOnlyList<AlbumModel> GetBestPerforming(DateTime startYear, DateTime endYear, int number)
        {
            throw new NotImplementedException();
        }
    }
}

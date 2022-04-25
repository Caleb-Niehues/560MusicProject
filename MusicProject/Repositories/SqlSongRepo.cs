using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace MusicProject.Repositories
{
    public class SqlSongRepo : ISongRepo
    {
        private readonly string connectionString;

        public SqlSongRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SongModel CreateSong(string name, AlbumModel album, Genre genre, TimeSpan length, int trackNumber)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));
            if (CheckAlbumExists(album.Title))
            {

            }
            else //create new album and insert song
            {

            }

            //FINISH 
            throw new NotImplementedException();
        }

        public bool CheckAlbumExists(string albumName)
        {
             return (RetrieveSongs(albumName) == null);
        }

        public IReadOnlyList<SongModel> FetchSong(string name)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.FetchSong", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateFetchSongs(reader);
                    }
                }
            }
        }

        private List<SongModel> TranslateFetchSongs(SqlDataReader reader)
        {
            var songs = new List<SongModel>();

            var songNameOrdinal = reader.GetOrdinal("SongName");
            var albumTitleOrdinal = reader.GetOrdinal("AlbumTitle");
            var artistNameOrdinal = reader.GetOrdinal("ArtistName");
            var genreNameOrdinal = reader.GetOrdinal("GenreName");
            var songLengthOrdinal = reader.GetOrdinal("Length");

            while (reader.Read())
            {
                songs.Add(new SongModel(reader.GetString(songNameOrdinal), reader.GetString(albumTitleOrdinal),
                            reader.GetString(artistNameOrdinal), (Genre)Enum.Parse(typeof(Genre), reader.GetString(genreNameOrdinal)), 
                            reader.GetTimeSpan(songLengthOrdinal)));
            }

            return songs;
        }

        public IReadOnlyList<SongModel> RetrieveSongs(string albumName)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(albumName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(albumName));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.RetrieveSongs", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", albumName);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateRetrieveSongs(reader);
                    }
                }
            }
        }

        private List<SongModel> TranslateRetrieveSongs(SqlDataReader reader)
        {
            var songs = new List<SongModel>();

            var songNameOrdinal = reader.GetOrdinal("SongName");
            var albumTitleOrdinal = reader.GetOrdinal("AlbumTitle");
            var artistNameOrdinal = reader.GetOrdinal("ArtistName");
            var genreNameOrdinal = reader.GetOrdinal("GenreName");
            var songLengthOrdinal = reader.GetOrdinal("Length");

            while (reader.Read())
            {
                songs.Add(new SongModel(reader.GetString(songNameOrdinal), reader.GetString(albumTitleOrdinal),
                            reader.GetString(artistNameOrdinal), (Genre)Enum.Parse(typeof(Genre), reader.GetString(genreNameOrdinal)),
                            reader.GetTimeSpan(songLengthOrdinal)));
            }

            return songs;
        }
    }
}

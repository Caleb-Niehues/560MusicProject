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

            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.CreateSong", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("SongName", name);
                        command.Parameters.AddWithValue("AlbumName", album.Title);
                        command.Parameters.AddWithValue("GenreName", Enum.GetName(typeof(Genre), genre));
                        command.Parameters.AddWithValue("Length", length);
                        command.Parameters.AddWithValue("TrackNumber", trackNumber);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        //var personId = (int)command.Parameters["PersonId"].Value;

                        return new SongModel(name, album.Title, album.Artist.Name, genre, length);
                    }
                }

            }
        }

        public string CheckAlbumExists(string albumName)
        {
            IReadOnlyList<SongModel> s = RetrieveSongsByName(albumName);
            if (s.Count > 0)
            {
                return s[0].Artist;
            }
            return null;
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

        public IReadOnlyList<SongModel> RetrieveSongsByName(string name)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.RetrieveSongsByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("Name", name);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateRetrieveSongs(reader);
                    }
                }
            }
        }

        public IReadOnlyList<SongModel> RetrieveSongsByAlbum(string albumTitle)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(albumTitle))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(albumTitle));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.RetrieveSongsByAlbum", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("AlbumTitle", albumTitle);

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

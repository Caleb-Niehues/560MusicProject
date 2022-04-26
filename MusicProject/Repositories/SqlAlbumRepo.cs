﻿using MusicProject.Models;
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

        public AlbumModel CreateAlbum(string title, DateTime releaseDate, ArtistModel artist, List<SongModel> songs,
                   TimeSpan length, List<ProducerModel> producers, RecordLabelModel recordLabel, Certification certification)
        {
            // Verify parameters.
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(title));

            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.CreateAlbum", connection))
                    {
                        //check for param existence
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("AlbumTitle", title);
                        command.Parameters.AddWithValue("ReleaseDate", releaseDate);
                        command.Parameters.AddWithValue("ArtistName", artist.Name);
                        command.Parameters.AddWithValue("RecordLabelName", recordLabel.Name);
                        command.Parameters.AddWithValue("CertificationName", Enum.GetName(typeof(Certification), certification));

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        AlbumModel currAlbum = new AlbumModel(title, releaseDate, artist, new List<SongModel>(),
                            new TimeSpan(0), producers, recordLabel, certification);


                        SqlSongRepo songRepo = new SqlSongRepo(connectionString);
                        TimeSpan albumLength = new TimeSpan();
                        foreach (var song in songs)
                        {
                            songRepo.CreateSong(song.Name, currAlbum, song.Genre, song.Length, song.TrackNumber);
                            albumLength += song.Length;
                        }

                        SqlProducerRepo producerRepo = new SqlProducerRepo(connectionString);
                        foreach (var producer in producers)
                        {
                            producerRepo.CreateProducer(producer.Name);
                        }

                        //var personId = (int)command.Parameters["PersonId"].Value;

                        return new AlbumModel(title, releaseDate, artist, songs, albumLength, producers, recordLabel, certification);
                    }
                }
            }
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
            //Dictionary<string, RecordLabelModel> recordLabels = new Dictionary<string, RecordLabelModel>();
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

                /*if (!recordLabels.ContainsKey(recordLabel)) 
                {
                    recordLabels.Add(recordLabel, new RecordLabelModel(recordLabel, reader.GetDateTime(labelDateFoundedOrdinal),
                        reader.GetDateTime(labelDateClosedOrdinal), reader.GetString(labelLocationOrdinal)));
                }*/
                
                if (!albums.ContainsKey(title))
                {
                    albums.Add(title, new AlbumModel(title, releaseDate, artist, songs, length,
                        producers.Values.ToList<ProducerModel>(),
                        new RecordLabelModel(recordLabel, reader.GetDateTime(labelDateFoundedOrdinal),
                        reader.GetDateTime(labelDateClosedOrdinal), reader.GetString(labelLocationOrdinal)),
                        certification));

                }
            }
            return albums.Values.ToList<AlbumModel>();
           }

        /// <summary>
        /// Gets the best performing album(s) of a given artist. That is,
        /// an album that has received at least a Platinum Certification
        /// and has an average rating from users of at least 3.0.
        /// </summary>
        /// <param name="artistName">Artist name to query.</param>
        /// <returns></returns>
        public IReadOnlyList<BestPerformingAlbumModel> GetBestPerforming(string artistName)
        {
            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.TopPerformingAlbums", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("ArtistName", artistName);

                        //var p = command.Parameters.Add("PersonId", SqlDbType.Int);
                        //p.Direction = ParameterDirection.Output;

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                            return TranslateGetBestPerforming(reader);
                    }
                }
            }
        }

        private IReadOnlyList<BestPerformingAlbumModel> TranslateGetBestPerforming(SqlDataReader reader)
        {
            var albums = new List<BestPerformingAlbumModel>();

            var artistNameOrdinal = reader.GetOrdinal("ArtistName");
            var albumTitleOrdinal = reader.GetOrdinal("AlbumTitle");
            var averageRatingOrdinal = reader.GetOrdinal("AverageRating");
            var certificationNameOrdinal = reader.GetOrdinal("CertificationName");

           
            while (reader.Read())
            {
                albums.Add(new BestPerformingAlbumModel(reader.GetString(artistNameOrdinal), reader.GetString(albumTitleOrdinal),
                    reader.GetDecimal(averageRatingOrdinal), 
                    (Certification)Enum.Parse(typeof(Certification), reader.GetString(certificationNameOrdinal))));
            }
            return albums;
        }
    }
}

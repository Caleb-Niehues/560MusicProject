using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace MusicProject.Repositories
{
    public class SqlReviewRepo : IReviewRepo
    {
        private readonly string connectionString;

        public SqlReviewRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ReviewModel CreateReview(string userName, string albumTitle, string comment, decimal rating)
        {
            // Verify parameters. Need to call fetch album and user to check real
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(userName));

            if (string.IsNullOrWhiteSpace(albumTitle))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(albumTitle));

            if (string.IsNullOrWhiteSpace(comment))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(comment));

            if (rating < 0 || rating > 5)
                throw new ArgumentException("The parameter must be between 0 and 5.", nameof(rating));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.CreateReview", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("UserName", userName);
                        command.Parameters.AddWithValue("AlbumTitle", albumTitle);
                        command.Parameters.AddWithValue("Comment", comment);
                        command.Parameters.AddWithValue("Rating", rating);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        return new ReviewModel(userName, albumTitle, comment, rating, DateTime.Now);
                    }
                }
            }
        }

        public void DeleteReview(string userName)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.DeleteReview", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("UserName", userName);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();
                    }
                }
            }
        }

        public IReadOnlyList<ReviewModel> RetrieveReviews(string albumTitle)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("MusicProject.RetrieveReviewsByAlbum", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("AlbumTitle", albumTitle);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateReviews(reader);
                }
            }
        }

        public ReviewModel FetchReview(string userName, string albumTitle)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("MusicProject.FetchReview", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("UserName", userName);
                    command.Parameters.AddWithValue("AlbumTitle", albumTitle);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        var temp = TranslateReviews(reader);
                        if (temp.Count > 0) return temp[0];
                        return null;
                    }
                }
            }
        }

        private IReadOnlyList<ReviewModel> TranslateReviews(SqlDataReader reader)
        {
            var reviews = new List<ReviewModel>();

            var userNameOrdinal = reader.GetOrdinal("UserName");
            var AlbumTitleOrdinal = reader.GetOrdinal("AlbumTitle");
            var commentOrdinal = reader.GetOrdinal("AlbumComment");
            var ratingOrdinal = reader.GetOrdinal("AlbumRating");
            var dateAddedOrdinal = reader.GetOrdinal("DateAdded");

            while (reader.Read())
            {
                reviews.Add(new ReviewModel(
                    reader.GetString(userNameOrdinal),
                    reader.GetString(AlbumTitleOrdinal),
                    reader.GetString(commentOrdinal),
                    reader.GetDecimal(ratingOrdinal),
                    reader.GetDateTime(dateAddedOrdinal)
                    ));
            }
            return reviews;
        }

        public ReviewModel SaveReview(string userName, string albumTitle, string comment, decimal rating)
        {
            // Verify parameters. Need to call fetch album and user to check real
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(userName));

            if (string.IsNullOrWhiteSpace(albumTitle))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(albumTitle));

            if (string.IsNullOrWhiteSpace(comment))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(comment));

            if (rating < 0 || rating > 5)
                throw new ArgumentException("The parameter must be between 0 and 5.", nameof(rating));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.SaveReview", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("UserName", userName);
                        command.Parameters.AddWithValue("AlbumTitle", albumTitle);
                        command.Parameters.AddWithValue("Comment", comment);
                        command.Parameters.AddWithValue("Rating", rating);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        return new ReviewModel(userName, albumTitle, comment, rating, DateTime.Now);
                    }
                }
            }
        }
    }
}

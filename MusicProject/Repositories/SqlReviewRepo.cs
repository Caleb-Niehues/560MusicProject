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

        public ReviewModel CreateReview(UserModel user, AlbumModel album, string comment, decimal rating)
        {
            // Verify parameters. Need to call fetch album and user to check real
            if (user == null)
                throw new ArgumentException("The parameter cannot be null.", nameof(user));

            if (album == null)
                throw new ArgumentException("The parameter cannot be null.", nameof(album));

            if (string.IsNullOrWhiteSpace(comment))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(comment));

            if(rating < 0 || rating > 5)
                throw new ArgumentException("The parameter must be between 0 and 100.", nameof(rating));

            // Save to database.
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.CreateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("UserName", user.Name);
                        command.Parameters.AddWithValue("AlbumName", album.Title);
                        command.Parameters.AddWithValue("Comment", comment);
                        command.Parameters.AddWithValue("Rating", rating);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        return new ReviewModel(user.Name, album.Title, comment, rating, DateTime.Now);
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


        public IReadOnlyList<ReviewModel> RetrieveReviews(string albumName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("MusicProject.RetrieveReviewsByAlbum", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                        return TranslateReviews(reader);
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
            //var dateAddedOrdinal = reader.GetOrdinal("DateAdded");

            while (reader.Read())
            {
                reviews.Add(new ReviewModel(
                    reader.GetString(userNameOrdinal),
                    reader.GetString(AlbumTitleOrdinal),
                    reader.GetString(commentOrdinal),
                    reader.GetDecimal(ratingOrdinal),
                    DateTime.Now //reader.GetDateTime(dateAddedOrdinal)
                    ));
            }

            return reviews;
        }

        public ReviewModel SaveReview(ReviewModel review)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("MusicProject.SaveReview", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("UserName", review.UserName);
                        command.Parameters.AddWithValue("AlbumName", review.AlbumTitle);
                        command.Parameters.AddWithValue("Comment", review.Comment);
                        command.Parameters.AddWithValue("Rating", review.Rating);
                        //command.Parameters.AddWithValue("DateAdded", review.DateAdded);

                        connection.Open();

                        command.ExecuteNonQuery();

                        transaction.Complete();

                        return review;
                    }
                }
            }
        }
    }
}

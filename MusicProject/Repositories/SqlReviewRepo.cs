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

        public ReviewModel CreateReview(UserModel user, AlbumModel album, string comment, decimal rating, DateTime dateAdded)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(string userName)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<ReviewModel> RetrieveReviews(string albumName)
        {
            throw new NotImplementedException();
        }

        public ReviewModel SaveReview(ReviewModel review)
        {
            throw new NotImplementedException();
        }
    }
}

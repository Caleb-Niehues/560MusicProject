using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface IReviewRepo
    {
        /// <summary>
        /// maybe have one that does this for all reviews a user has left?
        /// </summary>
        /// <param name="albumName"></param>
        /// <returns></returns>
        IReadOnlyList<ReviewModel> RetrieveReviews(string albumName);

        void EditReview(ReviewModel review);
    }
}

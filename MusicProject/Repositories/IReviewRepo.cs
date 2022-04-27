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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="albumTitle"></param>
        /// <param name="comment"></param>
        /// <param name="rating"></param>
        /// <returns></returns>
        ReviewModel CreateReview(string userName, string albumTitle, string comment, decimal rating);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="albumTitle"></param>
        /// <param name="comment"></param>
        /// <param name="rating"></param>
        /// <returns></returns>
        ReviewModel SaveReview(string userName, string albumTitle, string comment, decimal rating);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        void DeleteReview(string userName);
    }
}

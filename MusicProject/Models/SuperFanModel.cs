using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
     public class SuperFanModel 
    {
        #region Basic Fields
        /// <summary>
        /// 
        /// </summary>
        private int _weight;

        /// <summary>
        /// how important the user is to the industry, bigger the number the more important they are
        /// </summary>
        public int Weight => _weight;

        /// <summary>
        /// 
        /// </summary>
        private int _score;

        /// <summary>
        /// User score
        /// </summary>
        public int Score => _score;

        /// <summary>
        /// 
        /// </summary>
        private int _commentCount;

        /// <summary>
        /// Number of comments from this user in a given context
        /// </summary>
        public int CommentCount => _commentCount;

        private UserModel _user;

        public UserModel User;
        #endregion


        public SuperFanModel(UserModel user, int score, int commentCount)
        {
            _user = user;
            _score = score;
            _commentCount = commentCount;

        }
    }
}

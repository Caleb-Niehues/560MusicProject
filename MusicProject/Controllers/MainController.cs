using MusicProject.Models;
using System.Collections.Generic;
using MusicProject.Repositories;
using System.Configuration;

namespace MusicProject.Controllers
{
    /// <summary>
    /// A class to control the main operations of the program - very vague and likely needs broken up
    /// </summary>
    public class MainController
    {
        #region Load Order
        private string connectionString = ConfigurationManager.ConnectionStrings["configConnectionJordan"].ConnectionString;
        private SqlUserRepo SqlUser;
        private SqlReviewRepo SqlReview;
        private SqlPersonRepo SqlPerson;
        private SqlArtistRepo SqlArtist;
        private SqlSongRepo SqlSong;
        private SqlProducerRepo SqlProducer;
        private SqlRecordLabelRepo SqlRecordLabel;
        private SqlAlbumRepo SqlAlbum;

        private UpdateSearch update;

        private UserModel _activeUser = null;
        public UserModel ActiveUser => _activeUser;

        private IReadOnlyList<ReviewModel> _reviews = new List<ReviewModel>();

        private IReadOnlyList<PersonModel> _people = new List<PersonModel>();

        private IReadOnlyList<ArtistModel> _artists = new List<ArtistModel>();

        private IReadOnlyList<SongModel> _songs = new List<SongModel>();
        public IReadOnlyList<SongModel> Songs => _songs;

        private IReadOnlyList<ProducerModel> _producers = new List<ProducerModel>();

        private IReadOnlyList<RecordLabelModel> _recordLabels = new List<RecordLabelModel>();

        private IReadOnlyList<AlbumModel> _albums = new List<AlbumModel>();

        #endregion

        public MainController()
        {
            SqlUser = new SqlUserRepo(connectionString);
            SqlReview = new SqlReviewRepo(connectionString);
            SqlPerson = new SqlPersonRepo(connectionString);
            SqlArtist = new SqlArtistRepo(connectionString);
            SqlSong = new SqlSongRepo(connectionString);
            SqlProducer = new SqlProducerRepo(connectionString);
            SqlRecordLabel = new SqlRecordLabelRepo(connectionString);
            SqlAlbum = new SqlAlbumRepo(connectionString);
        }

        public void InitializeDelegates(UpdateSearch update)
        {
            this.update = update;
        }

        #region Login        
        public UserModel CredentialCheck(string userName, string password)
        {
            bool temp = SqlUser.FetchUser(userName, password, out _activeUser);
            return _activeUser;
        }

        public UserModel CreateUser(string userName, string password, int weight)
        {
            _activeUser = SqlUser.CreateUser(userName, password, weight);
            return _activeUser;
        }

        public bool DeleteUser(string userName, string password)
        {
            if (SqlUser.DeleteUser(userName, password))
            {
                _activeUser = null;
                return true;
            }
            return false;
        }
        #endregion

        #region Reviews
        public IReadOnlyList<ReviewModel> GetReviews(AlbumModel album)
        {
            _reviews = SqlReview.RetrieveReviews(album.Title);
            return _reviews;
        }

        public ReviewModel FetchReview(string userName, string albumTitle)
        {
            return SqlReview.FetchReview(userName, albumTitle);
        }

        public ReviewModel CreateOrSaveReview(ReviewModel review, bool newRev)
        {
            if(newRev) return SqlReview.CreateReview(review.UserName, review.AlbumTitle, review.Comment, review.Rating);
            else return SqlReview.SaveReview(review.UserName, review.AlbumTitle, review.Comment, review.Rating);
        }
        #endregion

        #region Search Bar
        public bool Search(string name)
        {
            bool success = false;

            _albums = SqlAlbum.FetchAlbum(name);
            success = success || _albums.Count > 0;

            _artists = SqlArtist.FetchArtist(name);
            success = success || _artists.Count > 0;

            _songs = SqlSong.FetchSong(name);
            success = success || _songs.Count > 0;

            //_people = SqlPerson.FetchPerson(name);
            success = success || _people.Count > 0;

            _producers = SqlProducer.FetchProducer(name);
            success = success || _producers.Count > 0;

            _recordLabels = SqlRecordLabel.FetchRecordLabel(name);
            success = success || _recordLabels.Count > 0;

            if (success) update(_albums, _artists, _songs, _people, _producers, _recordLabels);

            return success;
        }


        #endregion
    }
}

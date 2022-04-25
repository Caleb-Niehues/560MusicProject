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
        private string connectionString = ConfigurationManager.ConnectionStrings["configConnectionCaleb"].ConnectionString;
        private SqlUserRepo SqlUser;
        private SqlReviewRepo SqlReview;
        private SqlPersonRepo SqlPerson;
        private SqlArtistRepo SqlArtist;
        private SqlSongRepo SqlSong;
        private SqlProducerRepo SqlProducer;
        private SqlRecordLabelRepo SqlRecordLabel;
        private SqlAlbumRepo SqlAlbum;

        #region Load Order
        private UserModel _activeUser = null;
        public UserModel ActiveUser => _activeUser;

        private ReviewModel _reviewModel = null;

        private List<PersonModel> _members = new List<PersonModel>();

        private ArtistModel _artistModel;

        private List<SongModel> _songs = new List<SongModel>();

        private List<ProducerModel> producerModels = new List<ProducerModel>();
        
        private List<RecordLabelModel> recordLabels = new List<RecordLabelModel>();

        private AlbumModel _album;

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


    }
}

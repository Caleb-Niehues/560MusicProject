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
        private string connectionString = ConfigurationManager.ConnectionStrings["configConnectionAshley"].ConnectionString;
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

        private ReviewModel _reviewModel = null;

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

            List<SongModel> songs = new List<SongModel>();
            songs.Add(new SongModel("100", "Gold Mouf", "Kanye West", Genre.Rap, new System.TimeSpan(0, 3, 50)));
            songs.Add(new SongModel("GED", "Gold Mouf", "Kanye West", Genre.Rap, new System.TimeSpan(0, 2, 34)));
            songs.Add(new SongModel("Myself", "Gold Mouf", "Kanye West", Genre.Rap, new System.TimeSpan(0, 2, 52)));

            List<ProducerModel> producers = new List<ProducerModel>();
            producers.Add(new ProducerModel("Abdul Keith"));
            producers.Add(new ProducerModel("Abigail Colon"));

            List<RecordLabelModel> recordLabels = new List<RecordLabelModel>();
            recordLabels.Add(new RecordLabelModel("Eu Limited", new System.DateTime(2010, 12, 01), null, "South Carolina"));

            //var test = SqlSong.RetrieveSongs("nonenenene");
            AlbumModel test = SqlAlbum.CreateAlbum("Gold Mouf", new System.DateTime(2021, 10, 04), new ArtistModel("Kanye West", null), 
                songs, new System.TimeSpan(43), producers, recordLabels[0], Certification.None);
            test.ToString();
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

        #region Search Bar
        public bool Search(string name)
        {
            bool success = false;

            //_albums = SqlAlbum.FetchAlbum(name);
            success = success || _albums.Count > 0;

            //_artists = SqlArtist.FetchArtist(name);
            success = success || _artists.Count > 0;

            _songs = SqlSong.FetchSong(name);
            success = success || _songs.Count > 0;

            //_people = SqlPerson.FetchPerson(name);
            success = success || _people.Count > 0;

            //_producers = SqlProducer.FetchProducer(name);
            success = success || _producers.Count > 0;

            //_recordLabels = SqlRecordLabel.FetchRecordLabel(name);
            success = success || _recordLabels.Count > 0;

            if (success) update(_albums, _artists, _songs, _people, _producers, _recordLabels);

            return success;
        }


        #endregion
    }
}

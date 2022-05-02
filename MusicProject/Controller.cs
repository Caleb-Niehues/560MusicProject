using MusicProject.Models;
using System.Collections.Generic;
using MusicProject.Repositories;
using System.Configuration;
using System;

namespace MusicProject
{
    /// <summary>
    /// A class to control the main operations of the program - very vague and likely needs broken up
    /// </summary>
    public class Controller
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

        private GetTopPerformingGenres Genres;

        private IReadOnlyList<ReviewModel> _reviews = new List<ReviewModel>();

        private IReadOnlyList<PersonModel> _people = new List<PersonModel>();

        private IReadOnlyList<ArtistModel> _artists = new List<ArtistModel>();

        private IReadOnlyList<SongModel> _songs = new List<SongModel>();
        public IReadOnlyList<SongModel> Songs => _songs;

        private IReadOnlyList<ProducerModel> _producers = new List<ProducerModel>();

        private IReadOnlyList<RecordLabelModel> _recordLabels = new List<RecordLabelModel>();

        private IReadOnlyList<AlbumModel> _albums = new List<AlbumModel>();
        #endregion

        public Controller()
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
        public UserModel FetchAndCheckUser(string userName, string password)
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
        public IReadOnlyList<ReviewModel> RetrieveReviewsByAlbum(AlbumModel album)
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

            _producers = SqlProducer.RetrieveProducersByName(name);
            success = success || _producers.Count > 0;

            _recordLabels = SqlRecordLabel.FetchRecordLabel(name);
            success = success || _recordLabels.Count > 0;

            if (success) update(_albums, _artists, _songs, _people, _producers, _recordLabels);

            return success;
        }


        #endregion

        #region Aggregating Queries
        public IReadOnlyList<BestPerformingGenreModel> GetGenres(System.DateTime start, System.DateTime end, int top)
        {
            return SqlAlbum.GetBestPerformingGenres(start, end, top);
        }

        public IReadOnlyList<BestPerformingAlbumModel> GetAlbums(string artistName)
        {
            return SqlAlbum.GetBestPerformingAlbum(artistName);
        }

        public IReadOnlyList<SuperFanModel> GetSuperFans(string artistName)
        {
            return SqlUser.RetrieveSuperFans(artistName);
        }

        public AlbumsWithRecordLabelModel GetAlbumsWithRecordLabel(string recordLabelName,
            System.DateTime start, System.DateTime end)
        {
            return SqlRecordLabel.GetAlbumsWithRecordLabel(recordLabelName, start, end);
        }
        #endregion

        #region Add and Fetch

        public ArtistModel CreateArtist(string name)
        {
            return SqlArtist.CreateArtist(name, new List<PersonModel>());
        }
        
        public ProducerModel FetchProducer(string name)
        {
            return SqlProducer.FetchProducer(name);
        }

        public ProducerModel CreateProducer(string name)
        {
            return SqlProducer.CreateProducer(name);
        }

        public RecordLabelModel CreateLabel(string name, DateTime founded, DateTime? ended, string location)
        {
            return SqlRecordLabel.CreateRecordLabel(name, founded, ended, location);
        }
        #endregion

        #region AlbumView
        public AlbumModel CreateAlbum(string title, DateTime releaseDate, ArtistModel artist, List<SongModel> songs,
            TimeSpan length, List<ProducerModel> producers, RecordLabelModel recordLabel, Certification certification)
        {
            return SqlAlbum.CreateAlbum(title, releaseDate, artist, songs, length, producers, recordLabel, certification);
        }

        public IReadOnlyList<ArtistModel> RetrieveArtistsByName(string name)
        {
            return SqlArtist.FetchArtist(name);
        }

        public IReadOnlyList<ProducerModel> RetrieveProducersByAlbum(string albumTitle)
        {
            return SqlProducer.RetrieveProducersByAlbum(albumTitle);
        }

        public IReadOnlyList<RecordLabelModel> RetrieveLabelsByAlbum(string albumTitle)
        {
            //return SqlRecordLabel.RetrieveRecordLabelsByAlbum(albumTitle);
            return null;
        }

        public IReadOnlyList<SongModel> RetrieveSongsByAlbum(string albumTitle)
        {
            return SqlSong.RetrieveSongsByAlbum(albumTitle);
        }

        public RecordLabelModel FetchLabel(string name)//, string location)
        {
            var temp = SqlRecordLabel.FetchRecordLabel(name);//, location);
            if (temp.Count > 0) return temp[0];
            return null;
        }
        #endregion
    }
}

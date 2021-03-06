using System;
using System.Collections.Generic;

namespace MusicProject.Models
{
    /// <summary>
    /// model class for an album
    /// </summary>
    public class AlbumModel
    {
        #region Basic Fields
        /// <summary>
        /// 
        /// </summary>
        private string _title;

        /// <summary>
        /// title of the album
        /// </summary>
        public string Title => _title;

        /// <summary>
        /// 
        /// </summary>
        private DateTime _releaseDate;

        /// <summary>
        /// release date of an album
        /// </summary>
        public DateTime ReleaseDate => _releaseDate;

        /// <summary>
        /// 
        /// </summary>
        private ArtistModel _artist;

        /// <summary>
        /// artist of the album
        /// </summary>
        public ArtistModel Artist => _artist;

        /// <summary>
        /// 
        /// </summary>
        private List<SongModel> _songs;

        /// <summary>
        /// 
        /// </summary>
        public List<SongModel> Songs => _songs;

        /// <summary>
        /// 
        /// </summary>
        private TimeSpan _length;

        /// <summary>
        /// The total span of all songs on the album - pretabulated from SQL query fort performance
        /// </summary>
        public TimeSpan Length => _length;

        /// <summary>
        /// 
        /// </summary>
        private List<ProducerModel> _producers;

        /// <summary>
        /// list of all producers involved in the album
        /// </summary>
        public List<ProducerModel> Producers => _producers;

        /// <summary>
        /// 
        /// </summary>
        private RecordLabelModel _recordLabel;

        /// <summary>
        /// 
        /// </summary>
        public RecordLabelModel RecordLabel => _recordLabel;

        /// <summary>
        /// 
        /// </summary>
        private Certification _certification; //might become an enum

        /// <summary>
        /// certification of the album
        /// </summary>
        public Certification Certification => _certification;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="releaseDate"></param>
        /// <param name="artist"></param>
        /// <param name="songs"></param>
        /// <param name="length"></param>
        /// <param name="producers"></param>
        /// <param name="recordLabels"></param>
        /// <param name="certification"></param>
        public AlbumModel(string title, DateTime releaseDate, ArtistModel artist, List<SongModel> songs, TimeSpan length, List<ProducerModel> producers, RecordLabelModel recordLabel, Certification certification)
        {
            this._title = title;
            this._releaseDate = releaseDate;
            this._artist = artist;
            this._songs = songs;
            this._length = length;
            this._producers = producers;
            this._recordLabel = recordLabel;
            this._certification = certification;
        }

        public override string ToString()
        {
            return $"{Title} - {Artist.Name} - {ReleaseDate.Year} - {RecordLabel.Name} - {Enum.GetName(typeof(Certification), this.Certification)} - {Length}";
        }
    }
}

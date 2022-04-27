using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface IAlbumRepo
    {
        /// <summary>
        /// Used to fetch an album with an exact match
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IReadOnlyList<AlbumModel> FetchAlbum(string name);

        /// <summary>
        /// Gets the best performing album(s) of a given artist. That is,
        /// an album that has received at least a Platinum Certification
        /// and has an average rating from users of at least 3.0.
        /// </summary>
        /// <param name="artistName">Artist name to query.</param>
        /// <returns></returns>
        /// </summary>
        IReadOnlyList<BestPerformingAlbumModel> GetBestPerformingAlbum(string artistName);

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
        /// <returns></returns>
        AlbumModel CreateAlbum(string title, DateTime releaseDate, ArtistModel artist, List<SongModel> songs, TimeSpan length, List<ProducerModel> producers, RecordLabelModel recordLabel, Certification certification);
    }
}

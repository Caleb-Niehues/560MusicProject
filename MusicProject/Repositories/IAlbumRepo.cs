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
        /// 
        /// </summary>
        /// <param name="startYear">can be left null to see best seller since earliest time </param>
        /// <param name="endYear">can be left null to count as this year</param>
        /// <param name="number">number of albums displayed</param>
        /// <returns></returns>
        IReadOnlyList<AlbumModel> GetBestPerforming(DateTime startYear, DateTime endYear, int number);

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

using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface IArtistRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IReadOnlyList<ArtistModel> FetchArtist(string name);

        /// <summary>
        /// Gets all artists that released an album with a given record label over a given time window - replaces GetActiveArtists
        /// </summary>
        /// <param name="labelName">The name of the record label</param>
        /// <param name="startYear">Starting point of window</param>
        /// <param name="endYear">Ending point of the window</param>
        /// <returns></returns>
        IReadOnlyList<ArtistModel> GetArtistsInWindow(string labelName, DateTime startYear, DateTime endYear);

        ArtistModel CreateArtist(string name, List<PersonModel> members);
    }
}

using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface IPersonRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        PersonModel FetchPerson(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ArtistName"></param>
        /// <returns></returns>
        IReadOnlyList<PersonModel> GetMembers(string ArtistName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthDate"></param>
        /// <param name="deathDate"></param>
        /// <param name="homeRegion"></param>
        /// <returns></returns>
        PersonModel CreatePerson(string name, DateTime birthDate, DateTime? deathDate, string homeRegion);
    }
}

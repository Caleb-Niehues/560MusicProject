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
        IReadOnlyList<PersonModel> FetchPerson(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="artistName"></param>
        /// <returns></returns>
        IReadOnlyList<PersonModel> GetMembers(string artistName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthDate"></param>
        /// <param name="deathDate"></param>
        /// <param name="homeRegion"></param>
        /// <returns></returns>
        PersonModel CreatePerson(string name, DateTime birthDate, DateTime? deathDate, string homeRegion);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <param name="birthDate"></param>
        /// <param name="deathDate"></param>
        /// <param name="homeRegion"></param>
        /// <returns></returns>
        PersonModel SavePerson(string oldName, string newName, DateTime birthDate, DateTime? deathDate, string homeRegion);
    }
}

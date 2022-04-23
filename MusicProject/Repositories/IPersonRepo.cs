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
        /// <returns></returns>
        PersonModel FetchPerson();
    }
}

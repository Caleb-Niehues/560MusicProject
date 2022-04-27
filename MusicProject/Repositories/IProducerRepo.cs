using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface IProducerRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ProducerModel FetchProducer(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="albumTitle"></param>
        /// <returns></returns>
        IReadOnlyList<ProducerModel> RetrieveProducersByAlbum(string albumTitle);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="albumTitle"></param>
        /// <returns></returns>
        IReadOnlyList<ProducerModel> RetrieveProducersByName(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ProducerModel CreateProducer(string name);
    }
}

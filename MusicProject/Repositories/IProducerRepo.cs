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
        /// <returns></returns>
        IReadOnlyList<ProducerModel> FetchProducer(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ProducerModel CreateProducer(string name);
    }
}

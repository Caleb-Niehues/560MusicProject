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
        ProducerModel FetchProducer();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ProducerModel CreateProducer(string name);
    }
}

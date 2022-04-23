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
    }
}

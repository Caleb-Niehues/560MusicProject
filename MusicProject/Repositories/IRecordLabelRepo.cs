using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public interface IRecordLabelRepo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        RecordLabelModel FetchRecordLabel(string name);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dateFounded"></param>
        /// <param name="dateClosed"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        RecordLabelModel CreateRecordLabel(string name, DateTime dateFounded, DateTime? dateClosed, string location);
    }
}

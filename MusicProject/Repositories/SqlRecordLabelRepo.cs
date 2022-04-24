﻿using MusicProject.Models;
using System;
using System.Collections.Generic;

namespace MusicProject.Repositories
{
    public class SqlRecordLabelRepo : IRecordLabelRepo
    {
        private readonly string connectionString;

        public SqlRecordLabelRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public RecordLabelModel CreateRecordLabel(string name, DateTime dateFounded, DateTime? dateClosed, string location)
        {
            throw new NotImplementedException();
        }

        public RecordLabelModel FetchRecordLabel(string name)
        {
            throw new NotImplementedException();
        }
    }
}

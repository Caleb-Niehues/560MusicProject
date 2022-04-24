using MusicProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace MusicProject.Repositories
{
    public class SqlProducerRepo : IProducerRepo
    {
        private readonly string connectionString;

        public SqlProducerRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ProducerModel CreateProducer(string name)
        {
            throw new NotImplementedException();
        }

        public ProducerModel FetchProducer()
        {
            throw new NotImplementedException();
        }
    }
}

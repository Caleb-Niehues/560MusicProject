using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;
using MusicProject.Models;

namespace MusicProject.Repositories
{
    /// <summary>
    /// don't know if this class is necessary
    /// </summary>
    public class SqlCertificationRepo : ICertificationRepo
    {
        private readonly string connectionString;

        public SqlCertificationRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}

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
    public class SqlGenreRepo: IGenreRepo
    {
        private readonly string connectionString;

        public SqlGenreRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}

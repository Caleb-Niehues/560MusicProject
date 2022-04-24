using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

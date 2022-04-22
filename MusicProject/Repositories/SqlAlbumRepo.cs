using System.Configuration;

namespace MusicProject.Repositories
{
    public class SqlAlbumRepo : IAlbumRepo
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["configConnection"].ConnectionString;//just one call in maincontroller and pass throughout in actual practice

        public SqlAlbumRepo(string connectionsString)
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["configConnection"].ConnectionString;
            //this.connectionString = connectionString;
        }
    }
}

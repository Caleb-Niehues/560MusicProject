namespace MusicProject.Repositories
{
    /// <summary>
    /// don't know if this class is necessary
    /// </summary>
    public interface IGenreRepo
    {
        //take start and end date in years and see top 5 performing genres in that span - major problem since we moved genre off of album
        //could be solved by using most minutes of song in that genre - though that likely has its holes
        //should replace with album timeline
        //IReadOnlyList<string> GetTopFive(DateTime startYear, DateTime endYear);
    }
}

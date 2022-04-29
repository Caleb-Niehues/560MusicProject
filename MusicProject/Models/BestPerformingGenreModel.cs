using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    public class BestPerformingGenreModel
    {
        private int _rank;
        public int Rank => _rank;

        private Genre _genre;
        public Genre Genre => _genre;

        public BestPerformingGenreModel(int rank, Genre genre)
        {
            _rank = rank;
            _genre = genre;
        }

        public override string ToString()
        {
            return $"{Rank}. {Genre}";
        }
    }
}

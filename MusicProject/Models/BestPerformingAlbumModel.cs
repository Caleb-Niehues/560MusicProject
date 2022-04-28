using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    public class BestPerformingAlbumModel
    {
        private string _title;
        public string Title => _title;

        private string _artist;
        public string Artist => _artist;

        private decimal _averageRating;
        public decimal AverageRating => _averageRating;

        private Certification _certification;
        public Certification Certification => _certification;

        public BestPerformingAlbumModel(string title, string artist, decimal averageRating, Certification certification)
        {
            _title = title;
            _artist = artist;
            _averageRating = averageRating;
            _certification = certification;
        }

        public override string ToString()
        {
            return $"{Title} - {Math.Round(AverageRating, 2)} average user rating - {Certification}";
        }
    }
}

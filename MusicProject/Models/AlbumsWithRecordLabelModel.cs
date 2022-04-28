using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    public class AlbumsWithRecordLabelModel
    {
        private string _recordLabelName;
        public string RecordLabelName => _recordLabelName;

        private int _albumCount;
        public int AlbumCount => _albumCount;

        private int _certificationCount;
        public int CertificationCount => _certificationCount;

        public AlbumsWithRecordLabelModel(string recordLabelName, int albumCount, int certificationCount)
        {
            _recordLabelName = recordLabelName;
            _albumCount = albumCount;
            _certificationCount = certificationCount;
        }

        public override string ToString()
        {
            return $"{AlbumCount} albums - {CertificationCount} certifications";
        }
    }
}

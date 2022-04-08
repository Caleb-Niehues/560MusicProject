using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    public class AlbumModel
    {
        private int _ID;

        private string _title;

        private DateTime _releaseDate;

        private ArtistModel _artist;

        private List<ProducerModel> _producers;

        private CertificationModel certification; //might become an enum
    }
}

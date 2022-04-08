using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicProject.Models
{
    public class ReviewModel
    {
        private int _ID;

        private UserModel _user;

        private AlbumModel _album;

        private string _comment;//needs to be nullable - though the empty string could suffice

        private decimal _Rating;

        private DateTime _dateAdded;

        private DateTime? _dateDeleted;
    }
}

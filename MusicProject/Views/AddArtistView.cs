using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicProject.Views
{
    public partial class AddArtistView : Form
    {
        private static CreateArtist create;

        public AddArtistView()
        {
            InitializeComponent();
        }

        public static void InitializeDelegates(CreateArtist createArtist)
        {
            create = createArtist;
        }


    }
}

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

        private void uxAddArtistButton_Click(object sender, EventArgs e)
        {
            string name = uxArtistName.Text;
            if (!string.IsNullOrWhiteSpace(name))
            {
                var artist = create(name);
                MessageBox.Show("Artist successfully added as: " + artist.Name);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please add a name!");
            }
        }
    }
}

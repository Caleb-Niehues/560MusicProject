using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicProject.Models;

namespace MusicProject.Views
{
    public partial class AddProducerView : Form
    {
        

        public AddProducerView()
        {
            InitializeComponent();
        }

        private void uxAddProducerButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(uxNameBox.Text))
            {
                string producerName = uxNameBox.Text;


                MessageBox.Show("Producer successfully added as: ");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please add a name!");
            }
        }
    }
}

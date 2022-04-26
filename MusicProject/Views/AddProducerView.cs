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
        public MainView MainView { get; set; }

        public ProducerModel producer;

        public AddProducerView()
        {
            InitializeComponent();
        }

        private void uxAddProducerButton_Click(object sender, EventArgs e)
        {
            if(uxNameBox.Text != null)
            {
                string producerName = uxNameBox.Text;
                //MainView.producerModels.Add(new ProducerModel(producerName));
            }
            else
            {
                MessageBox.Show("Please add a Name!");
            }
        }
    }
}

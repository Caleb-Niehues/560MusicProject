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
        private static CreateProducer create;
        private updateProducers update = null;

        public AddProducerView()
        {
            InitializeComponent();
        }

        public AddProducerView(updateProducers updateProd)
        {
            InitializeComponent();
            update = updateProd;
        }

        public static void InitializeDelegates(CreateProducer createProd)
        {
            create = createProd;
        }

        private void uxAddProducerButton_Click(object sender, EventArgs e)
        {
            string name = uxNameBox.Text;
            if (!string.IsNullOrWhiteSpace(name))
            {
                var producer = create(name);
                MessageBox.Show("Producer successfully added as: " + producer.Name);
                if (update != null) update(producer);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please add a name!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juna_aikataulut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bHae_Click(object sender, EventArgs e)
        {

            string lähtöasema = tbMistä.Text;
            string kohdeasema = tbMinne.Text;

            tbTulos.Text = (lähtöasema + " " + kohdeasema);

        }
    }
}

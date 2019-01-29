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
        private void tbTulos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbJunanKulku_TextChanged(object sender, EventArgs e)
        {
            

        }

        // Lähtöpäivämäärän asetus
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime pvm = dateTimePicker1.Value;
            this.tbJunanKulku.Text = dateTimePicker1.Value.ToString("HH:mm");
            string departureTime = tbJunanKulku.Text;       
            

        }

        private void bHae_Click(object sender, EventArgs e)
        {
            string juna = "175";
            this.tbTulos.Text = juna;
        }
    }
}

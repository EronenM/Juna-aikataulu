using RataDigiTraffic; // pitää lisätä tämä
using RataDigiTraffic.Model; // pitää lisätä tämä
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

            string[] tulostelista = tulostaJunatVälillä(lähtöasema, kohdeasema);

            foreach (var juna in tulostelista)
            {
                lbTulos.Items.Add(juna);
            }
        }

        private static string[] tulostaJunatVälillä(string lähtöasema, string kohdeasema)
        {
            APIUtil rata = new APIUtil();

            List<Juna> junat = rata.JunatVälillä(lähtöasema, kohdeasema);
            string s = string.Join(", ", junat.Select(j => j.trainNumber + " " + j.trainType + " " + j.departureDate.ToShortDateString()+ " " + j.timeTableRows[0].scheduledTime.ToLongTimeString()));
            string[] lista = s.Split(',');

            return lista;

        }


    }
}

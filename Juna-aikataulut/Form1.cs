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

        private void valitsenappi_Click(object sender, EventArgs e) // lbtulos boksista voidaan tällä valita tietty itemi ja siirtää toiseen listboxiin
        {
            try
            {
                if (lbTulos.Items.Count > 0)
                {
                    listBox1.Items.Add(lbTulos.SelectedItem.ToString());
                    lbTulos.Items.Remove(lbTulos.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  //exception handling, muokattavissa
            }
            //valitsee ensimmäisen itemin lbtuloksesta.
            if (lbTulos.Items.Count > 0)
                lbTulos.SelectedIndex = 0;
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  // tähän voidaan myös liittää nappi jolla saadaan poistettua valittu item
        }

        private void poistanappi_Click(object sender, EventArgs e) // poistaa listbox1:sta siihen viedyn tiedon
        {
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    lbTulos.Items.Add(listBox1.SelectedItem.ToString()); // katsotaan onko listbox1:sessä item vai ei, jos on niin toteutetaan
                    listBox1.Items.Remove(listBox1.SelectedItem);        //valittu item listbox1 --> lbtulos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
            lbTulos.SelectedIndex = lbTulos.Items.Count - 1;

        }
    }
    }

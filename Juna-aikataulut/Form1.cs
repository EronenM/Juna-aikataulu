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
            tulostaAsemat();
        }

        List<Liikennepaikka> paikat;

        private List<Liikennepaikka> tulostaAsemat()
        {
            //luodaan autocomplete olio acSource
            AutoCompleteStringCollection acSource = new AutoCompleteStringCollection();
            //luodaan APIUtil olio rata, jotta päästään APIUtil metodeihin käsiksi
            APIUtil rata = new APIUtil();
            //laitetaan paikka listaan rata-luokkainstanssin Liikennepaikat-metodilla kaikki mahdolliset asemaoliot
            paikat = rata.Liikennepaikat();
            //käydään paikat listaa läpi ja lisätään acSourseen kaikki itemit, joiden tyyppin on "STATION"
            foreach (var item in paikat.Where(p => p.type == "STATION"))
            {
                acSource.Add(item.stationName);
            }
            //näillä saadaan ennakoivateksti näkymään tbMistä ja tbMinne kenttiin
            tbMistä.AutoCompleteCustomSource = acSource;
            tbMinne.AutoCompleteCustomSource = acSource;
            //palautetaan paikat lista niin siihen päästää käsiksi myöhemmin
            return paikat;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bHae_Click(object sender, EventArgs e)
        {
            //asemiksi haetaan paikat listalta se asema, joka mätsää automaattisyötetyn nimen kanssa
            //selvitä vielä tuo First(), miksi se tarvitaan?
            string lähtöasema = paikat.Where(p => p.stationName == tbMistä.Text).First().stationShortCode;
            string kohdeasema = paikat.Where(p => p.stationName == tbMinne.Text).First().stationShortCode;

            string[] tulostelista = tulostaJunatVälillä(lähtöasema, kohdeasema);
                        
            foreach (var juna in tulostelista)
            {
                lbTulos.Items.Add(juna);
            }
        }

        private static string[] tulostaJunatVälillä(string lähtöasema, string kohdeasema)
        {
            APIUtil rata = new APIUtil();

            // tähän joku error -käsittely, jos junia ei löydy asemien välille
            List<Juna> junat = rata.JunatVälillä(lähtöasema, kohdeasema);

            //junat pitäisi ensin sortata jotenkin päivämäärän mukaan
            
            string s = string.Join(",", junat.Select(j => j.trainNumber + " " + j.trainType + " " + j.departureDate.ToShortDateString() + " " + j.timeTableRows[0].scheduledTime.ToLongTimeString()));
            string[] lista = s.Split(',');

            return lista;

        }
    }
}

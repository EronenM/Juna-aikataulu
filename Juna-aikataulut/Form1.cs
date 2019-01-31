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
using System.Globalization;

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

        // Lähtöpäivämäärän asetus
        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    DateTime pvm = dateTimePicker1.Value;
        //    this.lbJunanKulku.Text = dateTimePicker1.Value.ToString("HH:mm");
        //    string departureTime = lbJunanKulku.Text;


        //}
        

        
        
        private void bHae_Click(object sender, EventArgs e)
        {
            lbTulos.Items.Clear();
            //asemiksi haetaan paikat listalta se asema, joka mätsää automaattisyötetyn nimen kanssa
            //selvitä vielä tuo First(), miksi se tarvitaan?
            try
            {
                string lähtöasema = paikat.Where(p => p.stationName.ToLower() == tbMistä.Text.ToLower()).First().stationShortCode;
                string kohdeasema = paikat.Where(p => p.stationName.ToLower() == tbMinne.Text.ToLower()).First().stationShortCode;
                tulostaJunatVälillä(lähtöasema, kohdeasema);
                
            }
            catch (Exception)
            {
                lbTulos.Items.Add("Kirjoittamaasi asemaa ei ole");
                lbTulos.Items.Add("tai valitsemiesi asemien yhteyttä ei ole olemassa");
                
            }

        }
        
        private void tulostaJunatVälillä(string lähtöasema, string kohdeasema)
        {
            // string[] asemat = { lähtöasema, kohdeasema };
            APIUtil rata = new APIUtil();

            // tähän joku error -käsittely, jos junia ei löydy asemien välille
            List<Juna> junat = rata.JunatVälillä(lähtöasema, kohdeasema);

            int counter = 0;

            foreach (var j in junat)
            {
                while (j.timeTableRows[counter].stationShortCode != lähtöasema)
                {
                    counter++;
                }

                lbTulos.Items.Add(j.trainNumber + " " + j.trainType + " " +  " " + j.timeTableRows[counter].scheduledTime.ToString("yyyy-MM-dd HH:mm")/*.ToLongTimeString()*/);
                counter = 0;
            }

            // return asemat;
        }

        private void bSiirryJunat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.junat.net/fi/");
        }

        private void bVR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.vr.fi/");
        }

        private void bValitseJuna_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbTulos.Items.Count > 0)
                {
                    string valittuJuna = lbTulos.SelectedItem.ToString();
                    string [] junanSplit = valittuJuna.Split(' ');
                    string junanAika = junanSplit[3];/*"2019-01-30";*/
                    int junanNro = int.Parse(junanSplit[0]);
                   
                    juniaAsemalla( junanAika, junanNro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  //exception handling, muokattavissa
            }
            //valitsee ensimmäisen itemin lbtuloksesta.
            if (lbTulos.Items.Count > 0)
                lbTulos.SelectedIndex = 0;
            lbValittuJuna.SelectedIndex = lbValittuJuna.Items.Count - 1;  // tähän voidaan myös liittää nappi jolla saadaan poistettua valittu item

        }
        private void juniaAsemalla(string date, int nro)
        {
            APIUtil junanpysähdykset = new APIUtil();
            List<Juna> junat = junanpysähdykset.JunanAsemat(date, nro);

            int timeTableRowCounter = 0;

            foreach (var juna in junat)
            {
                for (int i = 1; i < juna.timeTableRows.Count; i++)
                {
                    //  Valitaan listasta Junat asemat joissa valittu juna pysähtyy
                    if (juna.timeTableRows[timeTableRowCounter].trainStopping == true)
                    {
                        DateTime saapumisAika = new DateTime();
                        DateTime lähtöAika = new DateTime();

                        //  Lähtöaseman tulostus
                        if (timeTableRowCounter == 0)
                        {
                            lbJunanKulku.Items.Add(juna.trainNumber + " Lähtöasema: " + juna.timeTableRows[0].stationShortCode);
                        }

                        //  Junan asemalle saapumisajan noukinta ja aseman tulostus
                        if (juna.timeTableRows[timeTableRowCounter].type == "ARRIVAL")
                        {
                            saapumisAika = juna.timeTableRows[timeTableRowCounter].scheduledTime;

                            //  Junan asemalta lähtöajan noukinta. 
                            //  Etsii ARRIVAL-kohdan stationShortCoden kanssa matchaavan DEPARTURE ajan 
                            for (int j = 0; j < juna.timeTableRows.Count; j++)
                            {

                                if (juna.timeTableRows[timeTableRowCounter].stationShortCode == juna.timeTableRows[j].stationShortCode)
                                {
                                    if (juna.timeTableRows[j].type == "DEPARTURE")
                                    {
                                        lähtöAika = juna.timeTableRows[j].scheduledTime;
                                    }
                                }
                            }

                            //  Asemakohtaisen odotusajan laskenta
                            TimeSpan pysähdysAika = lähtöAika - saapumisAika;

                            //  lb Tulostus. POISTA {juna.trainNumber} FINALISTA
                            lbJunanKulku.Items.Add($"{juna.trainNumber} Pysähtyy: {juna.timeTableRows[timeTableRowCounter].stationShortCode} Pysähdysaika: {pysähdysAika.TotalMinutes}min");
                        }
                    }

                    timeTableRowCounter++;
                }
                // Pääteaseman tulostus
                lbJunanKulku.Items.Add(juna.trainNumber + " Päätösasema: " + juna.timeTableRows[timeTableRowCounter].stationShortCode);
            }
        }
        //private void tbMistä_Leave(object sender, EventArgs e)
        //{
        //    if(tbMistä.Text.Length != 0)
        //    {
        //        if (paikat.  Contains(tbMistä.Text.ToLower()).First().stationShortCode)
        //        {

        //        }
        //    }
        //}
    }
}

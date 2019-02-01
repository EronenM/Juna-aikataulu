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

        // ominaisuus ei vielä saatavilla
        //List<Liikennepaikka> automaattisyöttöasemat;

            // Mistä ja minne kenttien automaattinen ennakoivateksti
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

        string[] junaMistäMinne = new string[2];
        public string[] MistäMinne()
        {

            string lähtöasema = paikat.Where(p => p.stationName.ToLower() == tbMistä.Text.ToLower()).First().stationShortCode;
            string kohdeasema = paikat.Where(p => p.stationName.ToLower() == tbMinne.Text.ToLower()).First().stationShortCode;

            tulostaJunatVälillä(lähtöasema, kohdeasema);

            junaMistäMinne[0] = lähtöasema;
            junaMistäMinne[1] = kohdeasema;


            return junaMistäMinne;
        }


        private void bHae_Click(object sender, EventArgs e)
        {

            lbTulos.Items.Clear();
            try
            {
                MistäMinne();
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
                DateTime muutettuAika = DateTime.UtcNow;
                muutettuAika = j.timeTableRows[counter].scheduledTime.AddHours(2);
                lbTulos.Items.Add(j.trainNumber + " " + j.trainType + "\t " + muutettuAika.ToString("yyyy-MM-dd \t HH:mm"));
                counter = 0;
            }

            // return asemat;
        }


        private void bVR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.vr.fi/");
        }

        private void bValitseJuna_Click(object sender, EventArgs e)
        {
            lbJunanKulku.Items.Clear();
            try
            {
                if (lbTulos.Items.Count > 0)
                {
                    string valittuJuna = lbTulos.SelectedItem.ToString();
                    string[] junanSplit = valittuJuna.Split(' ');
                    string junanAika = junanSplit[3];
                    int junanNro = int.Parse(junanSplit[0]);

                    juniaAsemalla(junanAika, junanNro);
                }
            }
            catch (Exception)
            {
                lbJunanKulku.Items.Add("Ei valittavia junia");
            }

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

                        //  Ensimmäisen aseman ja junan tulostus
                        if (timeTableRowCounter == 0)
                        {
                            lbJunanKulku.Items.Add("Junan Numero: " + juna.trainNumber + "\t Lähtöasema: " + juna.timeTableRows[0].stationShortCode);
                        }
                        //  Junan asemalle saapumisajan noukinta ja aseman tulostus
                        if (juna.timeTableRows[timeTableRowCounter].type == "ARRIVAL")
                        {
                           
                            


                            if (juna.timeTableRows[timeTableRowCounter].stationShortCode == junaMistäMinne[1])
                            {
                                lbJunanKulku.Items.Add($"Pysähtyy: {juna.timeTableRows[timeTableRowCounter].stationShortCode} \t Saapumisaika {juna.timeTableRows[timeTableRowCounter].scheduledTime.AddHours(2).ToString("HH:mm")}  <= Olet Perillä");

                            }
                            saapumisAika = juna.timeTableRows[timeTableRowCounter].scheduledTime.AddHours(2);

                            //  Junan asemalta lähtöajan noukinta. 
                            //  Etsii ARRIVAL-kohdan stationShortCoden kanssa matchaavan DEPARTURE ajan 
                            for (int j = 0; j < juna.timeTableRows.Count; j++)
                            {

                                if (juna.timeTableRows[timeTableRowCounter].stationShortCode == juna.timeTableRows[j].stationShortCode)
                                {
                                    if (juna.timeTableRows[j].type == "DEPARTURE")
                                    {
                                        if (juna.timeTableRows[timeTableRowCounter].stationShortCode == junaMistäMinne[0])
                                        {
                                            lbJunanKulku.Items.Add($"Pysähtyy: {juna.timeTableRows[timeTableRowCounter].stationShortCode} \t Saapumisaika {juna.timeTableRows[timeTableRowCounter].scheduledTime.AddHours(2).ToString("HH:mm")}  <= Nouse täältä kyytiin");
                                        }
                                        lähtöAika = juna.timeTableRows[j].scheduledTime.AddHours(2);
                                    }

                                }
                            }

                            //  Asemakohtaisen odotusajan laskenta
                            TimeSpan pysähdysAika = lähtöAika - saapumisAika;

                            //  lb Tulostus. POISTA {juna.trainNumber} FINALISTA
                            lbJunanKulku.Items.Add($"Pysähtyy: {juna.timeTableRows[timeTableRowCounter].stationShortCode} \t Pysähdysaika: {pysähdysAika.TotalMinutes}min");
                        }

                    }

                    timeTableRowCounter++;
                }
                // Pääteaseman tulostus
                lbJunanKulku.Items.Add("Päätösasema: " + juna.timeTableRows[timeTableRowCounter].stationShortCode);
            }
        }

        //// ei toimi vielä
        //private void tbMistä_Leave(object sender, EventArgs e)
        //{
        //    var asemalistaus = mistäAsemat();

        //}

        //// ei toimi vielä
        //private List<Liikennepaikka> mistäAsemat()
        //{
        //    automaattisyöttöasemat = new List<Liikennepaikka>();
        //    string inputLähtö = paikat.Where(p => p.stationName.ToLower() == tbMistä.Text.ToLower()).First().stationShortCode;

        //    APIUtil varaRata = new APIUtil();

        //    foreach (var asema in paikat)
        //    {
        //        string välimuuttuja = asema.stationShortCode;
        //        List<Juna> junat = varaRata.JunatVälillä(inputLähtö, välimuuttuja);
        //        // tähän joku error -käsittely, jos junia ei löydy asemien välille
        //        if (junat != null)
        //        {
        //            automaattisyöttöasemat.Add(asema);
        //        }

        //    }

        //    return automaattisyöttöasemat;
        //}
    }
}

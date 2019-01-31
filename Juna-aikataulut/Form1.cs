using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RataDigiTraffic;
using DigiTrafficTester;
using RataDigiTraffic.Model;
using System.Globalization;

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

        // Lähtöpäivämäärän asetus
        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    DateTime pvm = dateTimePicker1.Value;
        //    this.lbJunanKulku.Text = dateTimePicker1.Value.ToString("HH:mm");
        //    string departureTime = lbJunanKulku.Text;


        //}

        private void bHae_Click(object sender, EventArgs e)
        {
            //Testi arvot. POISTA FINALISTA
            string date = "2019-01-30";
            int nro = 265;

            // Siirretään junanvalitsin nappiin FINALISSA
            juniaAsemalla(date, nro);

        }
       
        // LisBox johon tulostetaan asemat joissa juna pysähtyy
        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                        //  Junan asemalle saapumisajan noukinta
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
    }
}

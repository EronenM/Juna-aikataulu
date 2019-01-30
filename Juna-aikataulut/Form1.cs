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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime pvm = dateTimePicker1.Value;
            this.lbJunanKulku.Text = dateTimePicker1.Value.ToString("HH:mm");
            string departureTime = lbJunanKulku.Text;


        }

        private void bHae_Click(object sender, EventArgs e)
        {
            //Testi arvot. Voi poistaa
            string date = "2019-01-30";
            int nro = 273;
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
                for (int i =01; i < juna.timeTableRows.Count; i++)
                {

                    if (juna.timeTableRows[timeTableRowCounter].trainStopping == true)
                    {
                        DateTime saapumisAika = new DateTime();
                        DateTime lähtöAika = new DateTime();
                        string lähtöAika1;
                        string saapumisAika1;

                        if (timeTableRowCounter == 0)
                        {
                            lbJunanKulku.Items.Add(juna.trainNumber + " Lähtöasema: " + juna.timeTableRows[0].stationShortCode );
                        }

                        if (juna.timeTableRows[timeTableRowCounter].type == "ARRIVAL")
                        {
                            
                            saapumisAika1 = juna.timeTableRows[timeTableRowCounter].scheduledTime.ToString("dd.MM.yyyy HH.mm");
                            saapumisAika = DateTime.ParseExact(saapumisAika1, "dd.MM.yyyy HH.mm", System.Globalization.CultureInfo.InvariantCulture);

                           

                            for (int j = 0; j < juna.timeTableRows.Count; j++)
                            {

                                if (juna.timeTableRows[timeTableRowCounter].stationShortCode == juna.timeTableRows[j].stationShortCode)
                                {

                                    if (juna.timeTableRows[j].type == "DEPARTURE")
                                    {
                                        lähtöAika1 = juna.timeTableRows[j].scheduledTime.ToString("dd.MM.yyyy HH.mm");
                                        lähtöAika = DateTime.ParseExact(lähtöAika1, "dd.MM.yyyy HH.mm", System.Globalization.CultureInfo.InvariantCulture);
                                    }

                                }
                            }                            

                        TimeSpan pysähdysAika = lähtöAika - saapumisAika;
                           /* pysähdysAika.ToString("HH.mm")*/;

                            lbJunanKulku.Items.Add(juna.trainNumber + " " + juna.timeTableRows[timeTableRowCounter].stationShortCode + " " + pysähdysAika);

                        }
                                                                      
                    }

                    timeTableRowCounter++;
                }
                
                    lbJunanKulku.Items.Add(juna.trainNumber + " Päätösasema: " + juna.timeTableRows[timeTableRowCounter].stationShortCode);                
            }

        }
    }
}

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
            string date = "2019-01-29";
            int nro = 175;
            string[] pysäkitLista = juniaAsemalla(date, nro);

            foreach (var juna in pysäkitLista)
            {
                lbJunanKulku.Items.Add(juna);
            }


        

        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private string[] juniaAsemalla(string date, int nro)
        {
            APIUtil junanpysähdykset = new APIUtil();
            List<Juna> junat = junanpysähdykset.JunanAsemat(date, nro);
            string s = string.Join(", ", junat.Select(j => j.trainNumber + j.trainType + " " + j.timeTableRows[0].scheduledTime.ToLongTimeString()));
            string[] lista = s.Split(',');
            return lista;
        }    
    }
}

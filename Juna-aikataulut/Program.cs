using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juna_aikataulut
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }


    //// Ajan esitys eriteltynä Pitää tehdä funktio?
    ///
    //string pysähdysSiistitty /*= String.Format( CultureInfo.CurrentCulture, "Pysähdysaika: {0} tuntia, {1} minuuttia",pysähdysAika.Hours, pysähdysAika.Minutes)*/;
    //if (pysähdysAika.TotalMinutes < 60)
    //{
    //    pysähdysSiistitty = String.Format("{0}min", pysähdysAika.Minutes);
    //}
    //else if(pysähdysAika.TotalMinutes > 60)
    //{
    //    pysähdysSiistitty = String.Format("{0}h {1}min", pysähdysAika.Hours, pysähdysAika.Minutes);
    //}
}

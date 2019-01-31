//using RataDigiTraffic.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DigiTrafficTester
//{
//    class ProgramREST
//    {
//        static void RESTAlku(string[] args)
//        {
//            if (args.Length == 0)
//            {
//                printUsage();
//                return;
//            }
//            if (args[0].ToLower().StartsWith("-a"))
//            {
//                string asema = "";
//                if (args.Length > 1)
//                {
//                    asema = args[1];
//                }
//                tulostaAsemat(asema);
//                return;    
//            }
//            if (args[0].ToLower().StartsWith("-j"))
//            {
//                string lähtöasema;
//                string kohdeasema;
//                if (args.Length < 3)
//                {
//                    printUsage();
//                    return;
//                }
//                lähtöasema = args[1];
//                kohdeasema = args[2];
//                tulostaJunatVälillä(lähtöasema, kohdeasema);
//            }
//        }

//        private static void tulostaJunatVälillä(string lähtöasema, string kohdeasema)
//        {
//            RataDigiTraffic.APIUtil rata = new RataDigiTraffic.APIUtil();

//            List<Juna> junat = rata.JunatVälillä(lähtöasema, kohdeasema);
//            string s =  string.Join(", ", junat.Select(j => j.trainNumber + " " + j.trainType));
//            Console.WriteLine($"Junat {lähtöasema} ==> {kohdeasema}: " + s);
//        }

//        private static void tulostaAsemat(string asema)
//        {
//            List<Liikennepaikka> paikat;
//            RataDigiTraffic.APIUtil rata = new RataDigiTraffic.APIUtil();
//            paikat = rata.Liikennepaikat();
//            foreach (var item in paikat.Where(p => p.type == "STATION"))
//            {
//                if (item.stationName.StartsWith(asema))
//                {
//                    Console.WriteLine(item.stationName + " - " + item.stationShortCode);
//                }
//            }
//        }

//        private static void printUsage()
//        {
//            Console.WriteLine();
//            Console.WriteLine("Ohje:");
//            Console.WriteLine("DigiTrafficTester -a[semat] <asemanAlkukirjain>");
//            Console.WriteLine("tai");
//            Console.WriteLine("DigiTrafficTester -j[unat] alkuasemaLyhenne loppuasemaLyhenne");
//            Console.WriteLine();
//        }


//    }
//}

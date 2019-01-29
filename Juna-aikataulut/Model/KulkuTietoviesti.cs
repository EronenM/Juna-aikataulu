using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RataDigiTraffic.Model
{
    public class Kulkutietoviesti
    {
        public int id; // positive integer  Kulkutietoviestin yksilöivä numero.
        public long version; // positive integer  Versionumero, jossa kulkutietoviesti on viimeksi muuttunut
        public string trainNumber; // string Junan numero.Esim junan "IC 59" junanumero on 59
        public DateTime departureDate; // date Junan ensimmäisen lähdön päivämäärä.Voi olla tyhjä tapauksissa, jossa junan aikataulua ei tunneta.
        public DateTime timestamp; // date Tapahtuman ajanhetki
        public string trackSection; // string Tapahtuman raideosuuden tunniste. Lista raideosuuksista löytyy täältä.
        public string nextTrackSection; // string Seuraava raideosuuden tunniste, jolle juna ajaa.
        public string previousTrackSection; // string Raideosuuden tunniste, jolta juna tuli.
        public string station; // string Liikennepaikan tunniste, jonka alueella raideosuus on. Lista liikennepaikoista löytyy täältä.
        public string nextStation; // string Liikennepaikan tunniste, jonka alueella juna aiemmin oli.
        public string previousStation; // string Liikennepaikan tunniste, jonka alueelle juna ajaa seuraavaksi.
        public string type; // string Tapahtuman tyyppi.OCCUPY tarkoittaa, että juna varasi raideosuuden. RELEASE tarkoittaa, että juna vapautti raideosuuden.


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juna_aikataulut
{
    class Liikennepaikka
    {
        public bool passengerTraffic;
        public string countryCode;
        public string stationName;
        public string stationShortCode;
        public int stationUICCode;
        public decimal latitude;
        public decimal longitude;
        public string type;

    }

    //    passengerTraffic: boolean Onko liikennepaikalla kaupallista matkustajaliikennettä
    //countryCode: string Liikennepaikan maatunnus
    //stationName: string Liikennepaikan nimi
    //stationShortCode: string Liikennepaikan lyhenne
    //stationUICCode: 1-9999   Liikennepaikan maakohtainen UIC-koodi
    //latitude: decimal Liikennepaikan latitude "WGS 84"-muodossa
    //longitude: decimal Liikennepaikan longitudi "WGS 84"-muodossa
    //type: string Liikennepaikan tyyppi.STATION = asema, STOPPING_POINT = seisake, TURNOUT_IN_THE_OPEN_LINE = linjavaihde

    //http://dev.solita.fi/2015/08/10/open-train-data.html
}

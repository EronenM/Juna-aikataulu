using Newtonsoft.Json;
using RataDigiTraffic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RataDigiTraffic
{
    public class APIUtil

    {
        //haku kaikille asemille
        public List<Liikennepaikka> Liikennepaikat()
        {
            string json = "";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync($"https://rata.digitraffic.fi/api/v1/metadata/stations").Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                json = responseString;
            }
            List<Liikennepaikka> res;
            res = JsonConvert.DeserializeObject<List<Liikennepaikka>>(json);
            return res;
        }

        //haku junille kahden aseman välillä
        public List<Juna> JunatVälillä(string mistä, string minne)
        {
            string json = "";
            string url = $"https://rata.digitraffic.fi/api/v1/schedules?departure_station={mistä}&arrival_station={minne}";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(url).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                json = responseString;
            }
            List<Juna> res;
            res = JsonConvert.DeserializeObject<List<Juna>>(json);
            return res;
        }
    }
}
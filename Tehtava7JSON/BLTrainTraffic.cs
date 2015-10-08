using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace Tehtava7JSON
{
    class BLTrainTraffic
    {
        public BLTrainTraffic()
        {
        }

        #region Methods
        
        public List<Train> GetTrains(String url)
        {
            try
            {
                // haetaan Json data webistä
                String json = GetJsonFromWeb(url);

                if (json == null) return null;

                try
                {
                    // muutetaan se Train-olioiksi
                    List<Train> junat = JsonConvert.DeserializeObject<List<Train>>(json);

                    return junat;
                }
                catch (JsonSerializationException ex)
                {
                    return null;
                }
            }
            catch (JsonReaderException ex)
            {
                return null;
            }
        }

        public List<Station> GetStations(String url)
        {
            try
            {
                // haetaan Json data webistä
                String json = GetJsonFromWeb(url);

                if (json == null) return null;

                try
                {
                    // muutetaan se Station-olioiksi
                    List<Station> stations = JsonConvert.DeserializeObject<List<Station>>(json);

                    return stations;
                }
                catch (JsonSerializationException ex)
                {
                    return null;
                }
            }
            catch (JsonReaderException ex)
            {
                return null;
            }
        }

        private String GetJsonFromWeb(String url)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    var retval = wc.DownloadString(String.Format(url));
                    return retval;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}

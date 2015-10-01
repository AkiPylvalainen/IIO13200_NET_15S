using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6TestBench
{
    class BLPlacebo
    {
        ObservableCollection<Customer> _customers;
        ObservableCollection<City>     _cities;

        public BLPlacebo(String cityDataDirectory)
        {
            _customers = new ObservableCollection<Customer>();
            _cities    = new ObservableCollection<City>();

            FillCities(cityDataDirectory);
        }

        public void GetTestCustomers()
        {
            _customers.Clear();

            AddCustomer(0, "Pertsi", "Kumpulainen", "Poralantie 7", "45678", "Jyväskylä");
            AddCustomer(1, "Kullervo", "Kolehmainen", "Hehkukuja 5", "23456", "Vantaa");
            AddCustomer(2, "Allu", "Virtanen", "Likusteriraitti 3", "97531", "Joensuu");
        }

        public void GetAllCustomers(String connectionString)
        {
            String table = "customer";

            DataTable dt = DBPlacebo.ExecuteSelectCommand(connectionString, table);

            FillCustomers(dt);
        }

        public void GetCustomersFrom(String connectionString, int selectedCity)
        {
            String cityName = _cities.ElementAt(selectedCity).Name;
            String table = "customer";
            String sql = "SELECT * FROM " + table + " where city = '" + cityName + "'";

            DataTable dt = DBPlacebo.ExecuteCommand(connectionString, table, sql);

            FillCustomers(dt);
        }

        private void FillCustomers(DataTable dt)
        {
            _customers.Clear();

            foreach (DataRow row in dt.Rows)
            {
                AddCustomer(
                    Int32.Parse(row.ItemArray[0].ToString()), row.ItemArray[1].ToString(),
                    row.ItemArray[2].ToString(), row.ItemArray[3].ToString(),
                    row.ItemArray[4].ToString(), row.ItemArray[5].ToString());
            }
        }

        private void FillCities(String cityDataDirectory)
        {
            _cities.Clear();

            String[] data = System.IO.File.ReadAllLines(cityDataDirectory);

            for (int i = 0; i < data.Length; i++)
            {
                _cities.Add(new City(data[i]));
            }
        }

        private void FillTestCities()
        {
            _cities.Clear();

            String[] data = new String[] {
                "Jyväskylä", "Vantaa", "Nyki", "Turku", "Juva",
                "Helsinki", "Ducktown", "Walhalla", "New York", "Los Angeles",
                "Oulu", "Urjala", "Joensuu", "Asikkala", "Tuonela",
                "South Park", "Mikkeli", "Stockholm", "Varkaus", "Söpölä"
            };

            for (int i = 0; i < data.Length; i++)
            {
                _cities.Add(new City(data[i]));
            }
        }

        public void AddCustomer(int id, String firstname, String lastname, String address, String zip, String city)
        {
            _customers.Add(new Customer(id, firstname, lastname, address, zip, city));
        }

        public ObservableCollection<Customer> CustomerCollection
        {
            get { return _customers; }
        }

        public ObservableCollection<City> CityCollection
        {
            get { return _cities; }
        }
    }
}

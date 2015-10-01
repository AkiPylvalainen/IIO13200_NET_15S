using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace Tehtava6TestBench
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BLPlacebo _bl;

        public MainWindow()
        {
            InitializeComponent();

            //lbMessages.Content = JAMK.ICT.Properties.Settings.Tietokanta;
            lbMessages.Content = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            _bl = new BLPlacebo(ConfigurationManager.AppSettings.Get("txtDataDirectory"));
            
            dgCustomers.ItemsSource = _bl.CustomerCollection;
            cbCities.ItemsSource = _bl.CityCollection;
        }

        private void BtnGet3_Click(object sender, RoutedEventArgs e)
        {
            _bl.GetTestCustomers();
        }

        private void BtnGetAll_Click(object sender, RoutedEventArgs e)
        {
            String connStr = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            _bl.GetAllCustomers(connStr);
        }

        private void BtnGetFrom_Click(object sender, RoutedEventArgs e)
        {
            String connStr = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            _bl.GetCustomersFrom(connStr, cbCities.SelectedIndex);
        }
    }
}

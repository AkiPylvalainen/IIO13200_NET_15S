using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Tehtava7JSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BLTrainTraffic _bl;

        String trainUrl = "http://rata.digitraffic.fi/api/v1/live-trains";
        String stationUrl = "http://rata.digitraffic.fi/api/v1/metadata/station";

        public MainWindow()
        {
            InitializeComponent();

            _bl = new BLTrainTraffic();

            // asemien hakeminen verkosta saattaa kestää jonkin aikaa
            cbStations.ItemsSource = _bl.GetStations(stationUrl);
        }

        private async void btnTrains_Click(object sender, RoutedEventArgs e)
        {
            dgTrains.DataContext = null;
            
            Label1.Content = "Working...";
            dgTrains.DataContext = await GetTrainsAsync();
            Label1.Content = String.Empty;
        }

        private async Task<List<Train>> GetTrainsAsync()
        {
            return await Task.Run<List<Train>>(() => _bl.GetTrains(trainUrl));
        }
    }
}

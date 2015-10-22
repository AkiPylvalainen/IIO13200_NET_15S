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

namespace Tehtava8Palaute
{
    /// <summary>
    /// Interaction logic for FeedbackResultPage.xaml
    /// </summary>
    public partial class FeedbackReportPage : Page
    {
        public FeedbackReportPage()
        {
            InitializeComponent();
        }

        private void btnGetFeedbacks_Click(object sender, RoutedEventArgs e)
        {
            String path = Tehtava8Palaute.Properties.Settings.Default.FeedbackFile;

            XmlDataProvider xmldp = (XmlDataProvider)feedbackGrid.Resources["feedbackData"];
            xmldp.Source = new Uri(path);
        }
    }
}

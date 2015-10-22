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
using System.Xml;

namespace Tehtava8Palaute
{
    /// <summary>
    /// Interaction logic for FeedbackHomePage.xaml
    /// </summary>
    public partial class FeedbackHomePage : Page
    {
        public FeedbackHomePage()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (!IsOkay(txtDate.Text, txtDate)) return;
            if (!IsOkay(txtName.Text, txtName)) return;
            if (!IsOkay(txtLearnt.Text, txtLearnt)) return;
            if (!IsOkay(txtWantLearn.Text, txtWantLearn)) return;
            if (!IsOkay(txtGood.Text, txtGood)) return;
            if (!IsOkay(txtBad.Text, txtBad)) return;
            if (!IsOkay(txtExtra.Text, txtExtra)) return;

            String date = txtDate.Text;
            String name = txtName.Text;
            String learnt = txtLearnt.Text;
            String wantLearn = txtWantLearn.Text;
            String good = txtGood.Text;
            String bad = txtBad.Text;
            String extra = txtExtra.Text;
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            FeedbackReportPage feedbackReportPage = new FeedbackReportPage();
            NavigationService.Navigate(feedbackReportPage);
        }

        private bool IsOkay(String input, TextBox sender)
        {
            if (input.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Tarkista syöte.");
                sender.Focus();
                sender.SelectAll();
                return false;
            }
        }
    }
}

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

namespace Tehtava5lasnaolo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BLDemoxOy _bl;

        public MainWindow()
        {
            InitializeComponent();

            _bl = new BLDemoxOy();

            dgStudents.ItemsSource = _bl.StudentCollection;
        }

        private void BtnStudentsDT_Click(object sender, RoutedEventArgs e)
        {
            String connStr = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            _bl.GetAllStudents(connStr);
        }

        private void BtnStudentDV_Click(object sender, RoutedEventArgs e)
        {
            if(!IsOkay(txtAsio.Text.ToString(), txtAsio))
            {
                return;
            }
            String connStr = ConfigurationManager.ConnectionStrings[1].ConnectionString;
            _bl.GetStudent(connStr, txtAsio.Text.ToString());
        }

        private void BtnStudentsDS_Click(object sender, RoutedEventArgs e)
        {

        }

        private bool IsOkay(String input, TextBox sender)
        {
            if (input.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Check the input.");
                sender.Focus();
                sender.SelectAll();
                return false;
            }
        }
    }
}

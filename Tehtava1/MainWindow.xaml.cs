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

namespace Tehtava1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculation(object sender, RoutedEventArgs e)
        {
            double windowWidth = 0;
            double windowHeight = 0;
            double frameWidth = 0;

            if (IsOkay(txtL.Text, txtL))
            {
                windowWidth = Double.Parse(txtL.Text);
            }
            else return;

            if (IsOkay(txtH.Text, txtH))
            {
                windowHeight = Double.Parse(txtH.Text);
            }
            else return;

            if (IsOkay(txtW.Text, txtW))
            {
                frameWidth = Double.Parse(txtW.Text);
            }
            else return;

            double windowArea = windowWidth * windowHeight;

            double framePerimeter = ((windowWidth + frameWidth * 2)) * 2 + ((windowHeight + frameWidth * 2) * 2);

            double frameVertical   = (frameWidth * windowHeight) * 2;
            double frameHorizontal = (frameWidth * (windowWidth - frameWidth * 2)) * 2;
            double frameArea       = frameVertical + frameHorizontal;

            this.rsltWindowArea.Text     = windowArea.ToString()     + " mm2";
            this.rsltFrameArea.Text      = frameArea.ToString()      + " mm2";
            this.rsltFramePerimeter.Text = framePerimeter.ToString() + " mm";
        }

        private bool IsOkay(String input, TextBox sender)
        {
            double number = 0;
            if (input.Length > 0 && Double.TryParse(input, out number))
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

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

namespace Tehtava2Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BLLotto Lotto;
        

        public MainWindow()
        {
            InitializeComponent();
            Lotto = new BLLotto();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtLottoRows.Text = "";
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            int amount = 0;

            if (IsOkay(txtRows.Text, txtRows))
            {
                amount = Int32.Parse(txtRows.Text);
            }
            else return;

            Lotto.Tyyppi = cmbLotto.SelectionBoxItem.ToString();

            for (int i = 0; i < amount; i++)
            {
                List<int> NumeroLista = Lotto.ArvoRivi(Lotto.Tyyppi);

                if (NumeroLista != null)
                {
                    PrintLottoRow(NumeroLista);
                }
            }
        }

        private void PrintLottoRow(List<int> NumeroLista)
        {
            int[] taulukko = NumeroLista.ToArray();

            for (int j = 0; j < taulukko.Length; j++)
            {
                txtLottoRows.Text += taulukko[j] + " ";
            }
            txtLottoRows.Text += "\n";
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

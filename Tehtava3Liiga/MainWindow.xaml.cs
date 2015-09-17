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
using System.Collections.ObjectModel;
using System.Xml;
using Microsoft.Win32;

namespace Tehtava3Liiga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL_Liiga liiga;

        public MainWindow()
        {
            InitializeComponent();
            liiga = new BL_Liiga();

            listPlayerList.ItemsSource = liiga.PlayerList;
            cmbTeam.ItemsSource        = liiga.TeamList;

            String cfgDataDirectory = System.Configuration.ConfigurationSettings.AppSettings.Get("cfgDataDirectory");

            String[] data = System.IO.File.ReadAllLines(cfgDataDirectory);

            liiga.WritePlayersToArray(data);
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (!IsInputValid())
            {
                return;
            }

            if(!liiga.AddNewPlayer(txtFirstName.Text, txtSurname.Text, Int32.Parse(txtTransferPrice.Text), (Seura)cmbTeam.SelectionBoxItem))
            {
                MessageBox.Show("Pelaaja " + txtFirstName.Text + " " + txtSurname.Text + " on jo listassa.");
                return;
            }

            txtFirstName.Text     = String.Empty;
            txtSurname.Text       = String.Empty;
            txtTransferPrice.Text = String.Empty;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Pelaaja p = (Pelaaja)listPlayerList.SelectedItem;

            if (p != null)
            {
                if (!IsInputValid())
                {
                    return;
                }

                p.Etunimi     = txtFirstName.Text;
                p.Sukunimi    = txtSurname.Text;
                p.Siirtohinta = Int32.Parse(txtTransferPrice.Text);
                p.Seura       = (Seura)cmbTeam.SelectionBoxItem;
            }
            else
            {
                MessageBox.Show("Pelaajaa ei ole valittu.");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Pelaaja p = (Pelaaja)listPlayerList.SelectedItem;

            if (p != null)
            {
                liiga.RemovePlayer(p);

                txtFirstName.Text     = String.Empty;
                txtSurname.Text       = String.Empty;
                txtTransferPrice.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Pelaajaa ei ole valittu.");
            }
        }

        private void listPlayerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pelaaja p = (Pelaaja)listPlayerList.SelectedItem;

            if (p != null)
            {
                txtFirstName.Text     = p.Etunimi;
                txtSurname.Text       = p.Sukunimi;
                txtTransferPrice.Text = p.Siirtohinta.ToString();
                cmbTeam.SelectedIndex = p.Seura.ID;
            }
        }

        private void btnWriteAll_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.FileName = "playerdata";
            dialog.DefaultExt = ".cfg";
            dialog.Filter = "Config files (.cfg)|*.cfg";

            if(dialog.ShowDialog() == true)
            {
                foreach(Pelaaja p in liiga.PlayerList)
                {
                    String[] data = new String[liiga.GetPlayerCount()];
                    for (int i = 0; i < liiga.GetPlayerCount(); i++)
                    {
                        data[i] = liiga.GetPlayer(i).Etunimi +"," + liiga.GetPlayer(i).Sukunimi + "," + liiga.GetPlayer(i).Siirtohinta + "," + liiga.GetPlayer(i).Seura.ID;
                    }

                    System.IO.File.WriteAllLines(dialog.FileName, data);
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private bool IsInputValid()
        {
            if (!(txtFirstName.Text.Length > 0))
            {
                MessageBox.Show("Tarkista syöte.");
                txtFirstName.Focus();
                txtFirstName.SelectAll();
                return false;
            }
            if (!(txtSurname.Text.Length > 0))
            {
                MessageBox.Show("Tarkista syöte.");
                txtSurname.Focus();
                txtSurname.SelectAll();
                return false;
            }

            int transferPrice = 0;
            if (!(txtTransferPrice.Text.Length > 0 && Int32.TryParse(txtTransferPrice.Text, out transferPrice)))
            {
                MessageBox.Show("Tarkista syöte.");
                txtTransferPrice.Focus();
                txtTransferPrice.SelectAll();
                return false;
            }

            return true;
        }
    }
}

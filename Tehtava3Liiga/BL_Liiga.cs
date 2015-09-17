using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Tehtava3Liiga
{
    class BL_Liiga
    {
        ObservableCollection<Pelaaja> pelaajaLista;
        ObservableCollection<Seura> seuraLista;

        public BL_Liiga()
        {
            pelaajaLista = new ObservableCollection<Pelaaja>();
            seuraLista   = new ObservableCollection<Seura>();

            String[] joukkueet = new String[] {
                "JYP", "Jokerit", "Ilves",
                "KalPa", "Kärpät", "HPK",
                "Tappara", "TPS", "Lukko",
                "Blues", "HIFK", "Ässät",
                "SaiPa", "Pelicans", "KooKoo"
            };

            for (int i = 0; i < joukkueet.Length; i++)
            {
                Seura s = new Seura(joukkueet[i], i);
                seuraLista.Add(s);
            }
        }
        
        public void WritePlayersToArray(String[] data)
        {
            char delim = ',';

            for (int i = 0; i < data.Length; i++)
            {
                String[] token = data[i].Split(delim);

                AddNewPlayer(token[0], token[1], Int32.Parse(token[2]), GetTeam(Int32.Parse(token[3])));
            }
        }

        private bool CheckNoSamePlayer(Pelaaja p)
        {
            for (int i = 0; i < pelaajaLista.Count(); i++)
            {
                Pelaaja temp = pelaajaLista.ElementAt(i);
                if (temp.Etunimi.Equals(p.Etunimi) && temp.Sukunimi.Equals(p.Sukunimi))
                {
                    return false;
                }
            }

            return true;
        }

        public bool AddPlayer(Pelaaja p)
        {
            if(!CheckNoSamePlayer(p))
            {
                return false;
            }

            pelaajaLista.Add(p);

            return true;
        }

        public bool AddNewPlayer(String etunimi, String sukunimi, int siirtohinta, Seura seura)
        {
            Pelaaja p = new Pelaaja()
            {
                Etunimi     = etunimi,
                Sukunimi    = sukunimi,
                Siirtohinta = siirtohinta,
                Seura       = seura
            };

            if(!CheckNoSamePlayer(p))
            {
                return false;
            }

            pelaajaLista.Add(p);

            return true;
        }

        public void RemovePlayer(Pelaaja p)
        {
            pelaajaLista.Remove(p);
        }

        public void RemovePlayerAt(int index)
        {
            pelaajaLista.RemoveAt(index);
        }

        public Pelaaja GetPlayer(int index)
        {
            return pelaajaLista.ElementAt(index);
        }

        public Seura GetTeam(int index)
        {
            return seuraLista.ElementAt(index);
        }

        public int GetPlayerCount()
        {
            return pelaajaLista.Count;
        }

        public int GetTeamCount()
        {
            return seuraLista.Count;
        }
        
        public ObservableCollection<Pelaaja> PlayerList
        {
            get { return pelaajaLista; }
        }

        public ObservableCollection<Seura> TeamList
        {
            get { return seuraLista; }
        }
    }
}

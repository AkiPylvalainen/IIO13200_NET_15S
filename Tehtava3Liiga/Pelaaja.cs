using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3Liiga
{
    class Pelaaja
    {
        private String _etunimi;
        private String _sukunimi;
        private int _siirtohinta;
        private Seura _seura;

        public Pelaaja()
        {
            this._etunimi     = String.Empty;
            this._sukunimi    = String.Empty;
            this._siirtohinta = 0;
            this._seura       = null;
        }

        public Pelaaja(String etunimi, String sukunimi, int siirtohinta, Seura seura)
        {
            this._etunimi     = etunimi;
            this._sukunimi    = sukunimi;
            this._siirtohinta = siirtohinta;
            this._seura       = seura;
        }

        public String KokoNimi
        {
            get { return _etunimi + " " + _sukunimi + ", " + _seura.Nimi; }
        }

        public String Etunimi
        {
            get { return _etunimi;  }
            set { _etunimi = value; }
        }

        public String Sukunimi
        {
            get { return _sukunimi;  }
            set { _sukunimi = value; }
        }

        public int Siirtohinta
        {
            get { return _siirtohinta;  }
            set { _siirtohinta = value; }
        }

        public Seura Seura
        {
            get { return _seura; }
            set { _seura = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3Liiga
{
    class Seura
    {
        private String _nimi;
        private int _id;

        public Seura(String nimi, int id)
        {
            this._nimi = nimi;
            this._id   = id;
        }

        public String Nimi
        {
            get { return _nimi; }
            set { this._nimi = value; }
        }

        public int ID
        {
            get { return _id; }
            set { this._id = value; }
        }
    }
}

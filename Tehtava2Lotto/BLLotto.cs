using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2Lotto
{
    class BLLotto
    {
        private String tyyppi;
        private int suurinNro;
        private int numeroLkm;

        public BLLotto()
        {
            this.tyyppi    = "";
            this.suurinNro = 0;
            this.numeroLkm = 0;
        }

        public List<int> ArvoRivi()
        {
            if (this.tyyppi == null)
                return null;

            if (this.tyyppi.Equals("Suomi"))
            {
                this.suurinNro = 39;
                this.numeroLkm = 7;
            }
            else if (this.tyyppi.Equals("VikingLotto"))
            {
                this.suurinNro = 48;
                this.numeroLkm = 6;
            }
            else if (this.tyyppi.Equals("Eurojackpot"))
            {
                this.suurinNro = 50;
                this.numeroLkm = 5;
            }
            else return null;

            Random rand = new Random();
            List<int> lista = new List<int>();

            int[] lotto = new int[this.suurinNro + 1];

            int x;
            for (int i = 1; i <= this.numeroLkm; i++)
            {
                do
                {
                    x = 1 + (int)(rand.NextDouble() * this.suurinNro);
                }
                while (lotto[x] != 0);

                lotto[x] = 1;
            }
            if (this.tyyppi.Equals("Eurojackpot"))
            {
                for (int i = 1; i <= 2; i++)
                {
                    do
                    {
                        x = 1 + (int)(rand.NextDouble() * 8);
                    }
                    while (lotto[x] != 0);

                    lotto[x] = 2;
                }
            }

            for (int i = 1; i <= this.suurinNro; i++)
            {
                if (lotto[i] == 1)
                {
                    lista.Add(i);
                }
            }

            if (this.tyyppi.Equals("Eurojackpot"))
            {
                for (int i = 1; i <= this.suurinNro; i++)
                {
                    if (lotto[i] == 2)
                    {
                        lista.Add(i);
                    }
                }
            }

            return lista;
        }

        public List<int> ArvoRivi(String tyyppi)
        {
            if (tyyppi == null)
                return null;

            if (tyyppi.Equals("Suomi"))
            {
                this.suurinNro = 39;
                this.numeroLkm = 7;
            }
            else if (tyyppi.Equals("VikingLotto"))
            {
                this.suurinNro = 48;
                this.numeroLkm = 6;
            }
            else if (tyyppi.Equals("Eurojackpot"))
            {
                this.suurinNro = 50;
                this.numeroLkm = 5;
            }
            else return null;

            Random rand = new Random();
            List<int> lista = new List<int>();

            int[] lotto = new int[this.suurinNro + 1];

            int x;
            for (int i = 1; i <= this.numeroLkm; i++)
            {
                do
                {
                    x = 1 + (int)(rand.NextDouble() * this.suurinNro);
                }
                while (lotto[x] != 0);

                lotto[x] = 1;
            }
            if (tyyppi.Equals("Eurojackpot"))
            {
                for (int i = 1; i <= 2; i++)
                {
                    do
                    {
                        x = 1 + (int)(rand.NextDouble() * 8);
                    }
                    while (lotto[x] != 0);

                    lotto[x] = 2;
                }
            }

            for (int i = 1; i <= this.suurinNro; i++)
            {
                if (lotto[i] == 1)
                {
                    lista.Add(i);
                }
            }

            if (tyyppi.Equals("Eurojackpot"))
            {
                for (int i = 1; i <= this.suurinNro; i++)
                {
                    if (lotto[i] == 2)
                    {
                        lista.Add(i);
                    }
                }
            }

            return lista;
        }

        public String Tyyppi
        {
            get { return tyyppi; }
            set { tyyppi = value; }
        }

        /*
        public int SuurinNro
        {
            get { return suurinNro; }
            set { suurinNro = value; }
        }

        public int NumeroLkm
        {
            get { return numeroLkm; }
            set { numeroLkm = value; }
        }*/
    }
}

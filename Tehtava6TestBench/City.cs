using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6TestBench
{
    class City
    {
        private String _name;

        public City(String name)
        {
            _name = name;
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}

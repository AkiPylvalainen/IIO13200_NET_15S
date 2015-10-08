using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7JSON
{
    class Station
    {
        private String _stationName;
        private int _stationUICCode;

        public Station()
        {
            _stationName = String.Empty;
            _stationUICCode = 0;
        }

        public String StationName
        {
            get { return _stationName; }
            set { _stationName = value; }
        }

        public int StationUICCode
        {
            get { return _stationUICCode; }
            set { _stationUICCode = value; }
        }
    }
}

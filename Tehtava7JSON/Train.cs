using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7JSON
{
    class Train
    {
        private int _trainNumber;
        private bool _cancelled;
        private DateTime _departureDate;
        
        public Train()
        {
            _trainNumber = 0;
            _cancelled = false;
            _departureDate = DateTime.MinValue;
        }

        public int TrainNumber
        {
            get { return _trainNumber; }
            set { _trainNumber = value; }
        }

        public bool Cancelled
        {
            get { return _cancelled; }
            set { _cancelled = value; }
        }

        public DateTime DepartureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; }
        }
    }
}

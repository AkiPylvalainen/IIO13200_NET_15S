using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6TestBench
{
    class Customer
    {
        private int    _id;
        private String _firstname;
        private String _lastname;
        private String _address;
        private String _zip;
        private String _city;

        public Customer()
        {
            _id        = 0;
            _firstname = String.Empty;
            _lastname  = String.Empty;
            _address   = String.Empty;
            _zip       = String.Empty;
            _city      = String.Empty;
        }

        public Customer(int id, String firstname, String lastname, String address, String zip, String city)
        {
            _id = id;
            _firstname = firstname;
            _lastname = lastname;
            _address = address;
            _zip = zip;
            _city = city;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public String FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public String LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public String Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }
    }
}

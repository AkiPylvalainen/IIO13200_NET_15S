using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5lasnaolo
{
    class Student
    {
        private String _asioid;
        private String _lastname;
        private String _firstname;
        private String _date;

        public Student()
        {
            _asioid    = String.Empty;
            _lastname  = String.Empty;
            _firstname = String.Empty;
            _date      = String.Empty;
        }

        public Student(String asioid, String lastname, String firstname, String date)
        {
            _asioid    = asioid;
            _lastname  = lastname;
            _firstname = firstname;
            _date      = date;
        }

        public String AsioID
        {
            get { return _asioid; }
            set { _asioid = value; }
        }

        public String LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public String FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public String Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}

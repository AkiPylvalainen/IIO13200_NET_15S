using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Tehtava5lasnaolo
{
    class BLDemoxOy
    {
        ObservableCollection<Student> _students;

        public BLDemoxOy()
        {
            _students = new ObservableCollection<Student>();
        }

        public void GetAllStudents(String connectionString)
        {
            String table = "lasnaolot";

            DataTable dt = DBDemoxOy.GetDataTable(connectionString, table);

            FillStudents(dt);
        }

        public void GetStudent(String connectionString, String asioid)
        {
            String table = "lasnaolot";

            DataView dv = DBDemoxOy.GetDataView(connectionString, table, asioid);

            FillStudents(dv);
        }

        private void FillStudents(DataTable dt)
        {
            _students.Clear();

            foreach (DataRow row in dt.Rows)
            {
                AddStudent(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString());
            }
        }

        private void FillStudents(DataView dv)
        {
            _students.Clear();

            // TODO
        }

        public void AddStudent(String asioid, String lastname, String firstname, String date)
        {
            _students.Add(new Student(asioid, lastname, firstname, date));
        }

        public ObservableCollection<Student> StudentCollection
        {
            get { return _students; }
        }
    }
}

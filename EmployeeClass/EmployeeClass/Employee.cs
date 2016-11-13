using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Employee: INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private string _idNumber;
        public string IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; OnPropertyChanged(); }
        }

        private string _department;
        public string Department
        {
            get { return _department; }
            set { _department = value; OnPropertyChanged(); }
        }

        private string _position;
        public string Position
        {
            get { return _position; }
            set { _position = value; OnPropertyChanged(); }
        }
        
        //Overload constructor 1
        public Employee(string name, string idNumber, string department, string position)
        {
            name = _name;
            idNumber = _idNumber;
            department = _department;
            position = _position;
        }

        //Overload constructor 2
        public Employee(string name, string idNumber)
        {
            name = _name;
            idNumber = _idNumber;
            Department = "";
            Position = "";
        }

        //Overload constructor 3
        public Employee()
        {
            Name = "";
            IdNumber = "";
            Department = "";
            Position = "";
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string caller = null)
        {

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class VM: INotifyPropertyChanged
    {
        private Employee _firstEmployee = new Employee("David", 4, "First Department", "Dishwasher");
        public string FirstEName
        {
            get
            {
                return _firstEmployee.Name;
            }
            set
            {
                if (_firstEmployee.Name != value)
                {
                    _firstEmployee.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public int FirstEID
        {
            get
            {
                return _firstEmployee.idNumber;
            }
            set
            {
                if (_firstEmployee.idNumber != value)
                {
                    _firstEmployee.idNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string FirstEPosition
        {
            get
            {
                return _firstEmployee.Position;
            }
            set
            {
                if (_firstEmployee.Position != value)
                {
                    _firstEmployee.Position = value;
                    OnPropertyChanged();
                }
            }
        }

        public string FirstEDepartment
        {
            get
            {
                return _firstEmployee.Department;
            }
            set
            {
                if (_firstEmployee.Department != value)
                {
                    _firstEmployee.Department = value;
                    OnPropertyChanged();
                }
            }
        }

        private Employee _secondEmployee = new Employee("Maxim", 1);

        public string SecondEName
        {
            get
            {
                return _secondEmployee.Name;
            }
            set
            {
                if (_secondEmployee.Name != value)
                {
                    _secondEmployee.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public int SecondEID
        {
            get
            {
                return _secondEmployee.idNumber;
            }
            set
            {
                if (_secondEmployee.idNumber != value)
                {
                    _secondEmployee.idNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string SecondEPosition
        {
            get
            {
                return _secondEmployee.Position;
            }
            set
            {
                if (_secondEmployee.Position != value)
                {
                    _secondEmployee.Position = value;
                    OnPropertyChanged();
                }
            }
        }

        public string SecondEDepartment
        {
            get
            {
                return _secondEmployee.Department;
            }
            set
            {
                if (_secondEmployee.Department != value)
                {
                    _secondEmployee.Department = value;
                    OnPropertyChanged();
                }
            }
        }

        private Employee _thirdEmployee = new Employee();

        public string ThirdEName
        {
            get
            {
                return _thirdEmployee.Name;
            }
            set
            {
                if (_thirdEmployee.Name != value)
                {
                    _thirdEmployee.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ThirdEID
        {
            get
            {
                return _thirdEmployee.idNumber;
            }
            set
            {
                if (_thirdEmployee.idNumber != value)
                {
                    _thirdEmployee.idNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ThirdEPosition
        {
            get
            {
                return _thirdEmployee.Position;
            }
            set
            {
                if (_thirdEmployee.Position != value)
                {
                    _thirdEmployee.Position = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ThirdEDepartment
        {
            get
            {
                return _thirdEmployee.Department;
            }
            set
            {
                if (_thirdEmployee.Department != value)
                {
                    _thirdEmployee.Department = value;
                    OnPropertyChanged();
                }
            }
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

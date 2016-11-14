using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Employee
    {
        public string Name;
        public int idNumber;
        public string Department;
        public string Position;

        public Employee(string name, int IDNumber, string department, string position)
        {
            this.Name = name;
            this.idNumber = IDNumber;
            this.Department = department;
            this.Position = position;
        }

        public Employee(string name, int IDNumber)
        {
            this.Name = name;
            this.idNumber = IDNumber;
            this.Department = "";
            this.Position = "";
        }
        
        public Employee()
        {
            this.Name = "";
            this.idNumber = 0;
            this.Department = "";
            this.Position = "";
        }
    }
}

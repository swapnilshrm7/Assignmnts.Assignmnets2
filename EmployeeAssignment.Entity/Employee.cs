using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment.Entity
{
    public class Employee
    {
        private string _name;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int MyProperty { get; set; }


    }
}

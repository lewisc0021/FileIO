using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFile__IO
{
    class Employee
    {
        private string Name;
        private float Salary;

        #region Constructor
        public Employee(string name, float salary)
        {
            Name1 = name;
            Salary1 = salary;
        }
        #endregion

        #region Properties
        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public float Salary1
        {
            get
            {
                return Salary;
            }

            set
            {
                Salary = value;
            }
        }
        #endregion

    } }//END---------

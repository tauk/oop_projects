using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    abstract class AbstractEmployee
    {
        //attributes
        protected string empId;
        protected string empName;

        //Get for empId
        public string GetEmpId()
        {
            return empId;
        }

        //get for empName
        public string GetEmpName()
        {
            return empName;
        }

        //override the the ToString()
        public override string ToString()
        {
            return empId + " " + empName;
        }

        //the abstract method to calculate salary
        public abstract double CalcSalary();
    }
}

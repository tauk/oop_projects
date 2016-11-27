using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    class FullTimeEmployee : AbstractEmployee
    {
        //specific attributes for this class
        double BasicSalary;
        double Allowances;

        public FullTimeEmployee(string id, string name, double basic, double allowances)
        {
            //set the common attributes in the base 
            base.empId = id;
            base.empName = name;
            //set the specific attributes for the class

            //basic salary must be at least 5000 or above
            if (basic < 5000 || basic > 30000)
                throw new PaymentOutOfRange("Basic salary out of range");
            BasicSalary = basic;

            //basic salary must be at least 5000 or above
            if (allowances < 3000 || allowances > 1000)
                throw new PaymentOutOfRange("Allowances out of range");
            Allowances = allowances;
        }

        //get for the basic salary
        public double GetBasicSalary()
        {
            return BasicSalary;
        }

        //Get for allowances
        public double GetAllowances()
        {
            return Allowances;
        }

        //override the ToString() 
        public override string ToString()
        {
            return base.ToString() +" "+ BasicSalary + " " + Allowances; 
        }

        //override the Equals()
        public override bool Equals(object otherObject)
        {
            //try to convert obj to FullTimeEmployee
            FullTimeEmployee otherFullTimeObj = otherObject as FullTimeEmployee;

            //if it is null return false
            if (otherFullTimeObj == null)
                return false;

            //otherwise check the obj 
            bool isEqual = (base.empId == otherFullTimeObj.empId
                            && base.empName == otherFullTimeObj.empName);

            return isEqual;
        }

        //overrides the GetHashCode()
        public override int GetHashCode()
        {
            return base.empId.GetHashCode();
        }

        //override the CalcSalary from the abstract base class
        public override double CalcSalary()
        {
            return BasicSalary + Allowances;
        }
    }
}

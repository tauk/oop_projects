using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    class PartTimeEmployee : AbstractEmployee
    {
        //specific attributes for PartTimeEmployee
        double HourlyRate;
        int HoursWorked;

        public PartTimeEmployee(string id, string name, double rate, int hours)
        {
            base.empId = id;
            base.empName = name;

            //set specific attributes
            HourlyRate = rate;
            HoursWorked = hours;
        }

        //Get for hourly rate
        public double GetHourlyRate()
        {
            return HourlyRate;
        }

        //Get for hours worked
        public int GetHoursWorked()
        {
            return HoursWorked;
        }

        //override the ToString() 
        public override string ToString()
        {
            return base.ToString() + " " + HourlyRate.ToString("N") 
                + " " + HoursWorked;
        }

        //override the Equals()
        public override bool Equals(object otherObject)
        {
            //try to convert obj to PartTimeEmployee
            PartTimeEmployee otherPartTimeObj = otherObject as PartTimeEmployee;

            //if it is null return false
            if (otherPartTimeObj == null)
                return false;

            //otherwise check the obj 
            bool isEqual = (base.empId == otherPartTimeObj.empId
                            && base.empName == otherPartTimeObj.empName);

            return isEqual;
        }

        //overrides the GetHashCode()
        public override int GetHashCode()
        {
            return base.empId.GetHashCode();
        }

        //override the CalcSalary from the abstract base
        public override double CalcSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}

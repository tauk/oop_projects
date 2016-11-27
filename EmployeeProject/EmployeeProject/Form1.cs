using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeProject
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }

        //the list which holds data about all the employees
        List<AbstractEmployee> empList = new List<AbstractEmployee>();

        private void btnAddFullTime_Click(object sender, EventArgs e)
        {
            //get the info from the form
            string id = txtEmpID.Text;
            string name = txtEmpName.Text;
            string basic = txtBasicSalary.Text;
            string allowances = txtAllowances.Text;

            //validations for empty text boxes
            if (id == "" || name == "" || basic == "" || allowances == "")
            {
                MessageBox.Show("Fill all data for Full Time Employee!");
                return;
            }

            double basicSal;
            double dAllowances;

            //try to parse and the values from text box to numeric types
            bool basicIsDouble = Double.TryParse(basic, out basicSal);
            bool allowancesIsDouble = Double.TryParse(allowances, out dAllowances);

            //if values from text boxes could not be converted to numeric - show error message
            if (basicIsDouble == false )
            {
                MessageBox.Show("Enter a number for basic Salary");
                return;
            }

            if (allowancesIsDouble == false)
            {
                MessageBox.Show("Enter a number for allowances");
                return;
            }

            //check of empId already exist
            if (DoesEmpIdExist(id))
            {
                MessageBox.Show("Emp Id " +id+ " already exist");
                txtEmpID.Focus();
                return;
            }

            try
            {
                //create a new object and add it to the empList
                FullTimeEmployee ft = new FullTimeEmployee(id, name, basicSal, dAllowances);
                empList.Add(ft);

                //show status in the status label
                lblStatus.Text = "Record added for " + name;

                DisplayEmployees(empList);
            }
            catch(PaymentOutOfRange payException)
            {
                MessageBox.Show("Incorrect values: " + payException.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayEmployees(empList);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            //delete all employees in the empList
            empList.Clear();

            //clear the list box also
            listBoxData.Items.Clear();
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            //get the info from the form
            string id = txtEmpID.Text;

            //validations for empty text box for empId
            if (id == "")
            {
                MessageBox.Show("Enter an employee ID to search!");
                return;
            }

            //search the list of the employee
            var employees = (from emp in empList
                            where emp.GetEmpId() == id
                            select emp).ToList();

            lblStatus.Text = string.Format("Found {0} records ", employees.Count);

            DisplayEmployees(employees);
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            //get the info from the form
            string name = txtEmpName.Text;

            //validations for empty text box for empId
            if (name == "")
            {
                MessageBox.Show("Enter an employee name to search!");
                return;
            }

            //search the list of the employee
            var employees = (from emp in empList
                             where emp.GetEmpName() == name
                             select emp).ToList();

            lblStatus.Text = string.Format("Found {0} records ", employees.Count);

            DisplayEmployees(employees);
        }

        private void btnAddPartTime_Click(object sender, EventArgs e)
        {
            //get the info from the form
            string id = txtEmpID.Text;
            string name = txtEmpName.Text;
            string rate = txtHourlyRate.Text;
            string hours = txtHoursWorked.Text;

            //validations for empty text boxes
            if (id == "" || name == "" || rate == "" || hours == "")
            {
                MessageBox.Show("Fill all data for Part Time Employee!");
                return;
            }

            double hourlyRate;
            int  hoursWorked;

            //try to parse and the values from text box to numeric types
            bool rateIsDouble = Double.TryParse(rate, out hourlyRate);
            bool hoursIsInt = Int32.TryParse(hours, out hoursWorked);

            //values from textbox are not numeric - show error message
            if (rateIsDouble == false)
            {
                MessageBox.Show("Enter a number for hourly rate!");
                txtHourlyRate.Focus();
                return;
            }

            if (hoursIsInt == false)
            {
                MessageBox.Show("Enter a number for hours worked!");
                txtHoursWorked.Focus();
                return;
            }

            //check of empId already exist
            if (DoesEmpIdExist(id))
            {
                MessageBox.Show("Emp Id "+id+ " already exists!");
                txtEmpID.Focus();
                return;
            }

            //create a new object and add it to the empList
            PartTimeEmployee pt = new PartTimeEmployee(id, name, hourlyRate, hoursWorked);
            empList.Add(pt);

            //show status in the status label
            lblStatus.Text = "Record added for " + name;

            DisplayEmployees(empList);
        }

        private void btnDeleteById_Click(object sender, EventArgs e)
        {
            //get the info from the form
            string id = txtEmpID.Text;

            //validations for empty text box for empId
            if (id == "")
            {
                MessageBox.Show("Enter an employee ID to delete!");
                return;
            }

            //check of empId already exist
            if (!DoesEmpIdExist(id))
            {
                MessageBox.Show("Emp Id "+id+ " does NOT exist!");
                txtEmpID.Focus();
                return;
            }

            //Get the employee records as employees
            var employees = (from emp in empList
                             where emp.GetEmpId() == id
                             select emp).ToList();

            //remove the first employee which is first record
            empList.Remove(employees[0]);

            lblStatus.Text = string.Format("Deleted record for EmpId {0} ", id);
            DisplayEmployees(empList);
        }

        //check for duplicate empId - validation when adding new employee
        private bool DoesEmpIdExist(string empId)
        {
            //search the list of the employee
            var employees = (from emp in empList
                             where emp.GetEmpId() == empId
                             select emp).ToList();

            return (employees.Count > 0);
        }

        private void DisplayEmployees(IList<AbstractEmployee> employees)
        {
            //clear the listBoxData first
            listBoxData.Items.Clear();

            //display the employees
            foreach (var employee in employees)
            {
                listBoxData.Items.Add(employee.GetType().Name + " " + employee);
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {

        }

        private void btnShowSalaries_Click(object sender, EventArgs e)
        {
            foreach (var emp in empList)
            {
                listBoxData.Items.Clear();

                string empData = emp.GetType().Name + " " 
                                + emp.GetEmpId() + " "
                                + emp.GetEmpName() + " " 
                                + emp.CalcSalary().ToString("N");
                listBoxData.Items.Add(empData);
            }
        }
    }
}

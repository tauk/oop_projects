using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamesListProject
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        List<string> namesList = new List<string>();


        private void button1_Click(object sender, EventArgs e)
        {
            //first do validation
            string name = txtName.Text;

            //check if the name is empty
            if (name == "") {
                MessageBox.Show("Enter a name to add");
                txtName.Focus();
                return;
            }

            //check if name already exist
            if (DoesNameExist(name) == true)
            {
                MessageBox.Show(name +" already exists!");
                txtName.Focus();
                return;
            }
           
            //name is not empty add to the list
            namesList.Add(name);

            //show the name in the list box
            DisplayNames(namesList);
        }

        private void DisplayNames(IList<string> list)
        {
            lBoxNames.Items.Clear();

            foreach (var name in list)
                lBoxNames.Items.Add(name);
        }

        private bool DoesNameExist(string name)
        {
            var names = (from n in namesList
                         where n == name
                         select n).ToList();

            return (names.Count > 0);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            //first do validation
            string name = txtName.Text;

            //check if the name is empty
            if (name == "")
            {
                MessageBox.Show("Enter a name to delete");
                txtName.Focus();
                return;
            }

            //check if name exists
            if (DoesNameExist(name) == false)
            {
                MessageBox.Show(name + " does not exist!");
                txtName.Focus();
                return;
            }

            //name exists - delete the name
            namesList.Remove(name);

            //refresh the list box
            DisplayNames(namesList);
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            //first do validation
            string name = txtName.Text;

            //check if the name is empty
            if (name == "")
            {
                MessageBox.Show("Enter a name to Find");
                txtName.Focus();
                return;
            }

            //find the names
            var namesFound = (from n in namesList
                         where n.Contains(name)
                         select n).ToList();

            if (namesFound.Count == 0)
            {
                MessageBox.Show("No name found with " + name);
                return;
            }

            //we have names - display in the listBox
            DisplayNames(namesFound);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayNames(namesList);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainersClasses;

namespace TrainersBackOffice
{
	public partial class frmCustomers : Form
	{
		public frmCustomers()
		{
			InitializeComponent();
		}

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //call the display customers function
            lblError.Text = DisplayCustomers() + " customers found";
            
            
        }

        Int32 DisplayCustomers()
        {
            //create an instance of the customer collection
            clsCustomerCollection MyCustomers = new clsCustomerCollection();
            //find all customers
            lstCustomers.DataSource = MyCustomers.CustomersList;
            //set the text to be displayed
            lstCustomers.DisplayMember = "Email";
            lstCustomers.ValueMember = "CustomerID";
            //return the count of the records in the list
            return MyCustomers.Count;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        void Add()
        {
            //create an instance ofthe collection class
            clsCustomerCollection CustomerCollection = new clsCustomerCollection();
            //validate the data on the web form
            String Error = CustomerCollection.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtDateOfBirth.Text, txtEmail.Text, txtPassword.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostCode.Text);
            //if the data is ok the add it to the object
            if (Error == "")
            {
                //get the data entered by the user 
                CustomerCollection.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerCollection.ThisCustomer.LastName = txtLastName.Text;
                CustomerCollection.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                CustomerCollection.ThisCustomer.Email = txtEmail.Text;
                CustomerCollection.ThisCustomer.Password = txtPassword.Text;
                CustomerCollection.ThisCustomer.HouseNo = txtHouseNo.Text;
                CustomerCollection.ThisCustomer.Street = txtStreet.Text;
                CustomerCollection.ThisCustomer.Town = txtTown.Text;
                CustomerCollection.ThisCustomer.PostCode = txtPostCode.Text;
                //add the record
                CustomerCollection.Add();
                lblError2.Text = "New customer added succesfully";
                

            }
            else
            {
                //report an error
                lblError2.Text = "There were problems with the data entered " + Error;
            }
        }
    }
}

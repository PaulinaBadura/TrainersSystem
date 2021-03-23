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
            btnYes.Visible = false;
            btnNo.Visible = false;
            btnUpdate.Visible = false;
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
                //confirmation message
                lblAddEditConf.Text = "New customer added successfully";
                //clear the text boxes
                //populate the list 
                lblError.Text = DisplayCustomers() + " customers found";


            }
            else
            {
                //report an error
                lblAddEditConf.Text = "There were problems with the data entered " + Error;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 CustomerID;
            //if a record has beenselected from the list
            if(lstCustomers.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
                //show confirmation message and buttons
                lblConfirmation.Text = "Are you sure you want to delete this customer?";
                btnNo.Visible = true;
                btnYes.Visible = true;
               
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to be deleted from the list";
            }
        }

        void DeleteCustomer()
        {
            Int32 CustomerID;
            //function to delete selected record
            //create a new in stance of the customer collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //find the record to delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            AllCustomers.ThisCustomer.Find(CustomerID);
            //delete the record 
            AllCustomers.Delete();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteCustomer();
            //show confirmation message
            lblConfirmation.Text = "Record has ben deleted";
            btnYes.Visible = false;
            btnNo.Visible = false;
            lblError.Text = DisplayCustomers() + " customers found";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            lblConfirmation.Text = string.Empty;
            btnNo.Visible = false;
            btnYes.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btnAdd.Visible = true;
            btnUpdate.Visible = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 CustomerID;
            //if a record has beenselected from the list
            if (lstCustomers.SelectedIndex != -1)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                //get the primary key value of the record to delete
                CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
                //find the record to updae
                clsCustomerCollection AllCustomers = new clsCustomerCollection();
                AllCustomers.ThisCustomer.Find(CustomerID);
                //display the data for this record
                txtFirstName.Text = AllCustomers.ThisCustomer.FirstName;
                txtLastName.Text = AllCustomers.ThisCustomer.LastName;
                txtDateOfBirth.Text = AllCustomers.ThisCustomer.DateOfBirth.ToString();
                txtEmail.Text = AllCustomers.ThisCustomer.Email;
                txtPassword.Text = AllCustomers.ThisCustomer.Password;
                txtHouseNo.Text = AllCustomers.ThisCustomer.HouseNo;
                txtStreet.Text = AllCustomers.ThisCustomer.Street;
                txtTown.Text = AllCustomers.ThisCustomer.Town;
                txtPostCode.Text = AllCustomers.ThisCustomer.PostCode;
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to be edited from the list";
            }
        }

        //void DisplayCustomer()
        //{
        //        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //        AllCustomers.ThisCustomer.Find(CustomerID);
        //        //display the data for this record
        //        txtFirstName.Text = AllCustomers.ThisCustomer.FirstName;
        //        txtLastName.Text = AllCustomers.ThisCustomer.LastName;
        //        txtDateOfBirth.Text = AllCustomers.ThisCustomer.DateOfBirth.ToString();
        //        txtEmail.Text = AllCustomers.ThisCustomer.Email;
        //        txtPassword.Text = AllCustomers.ThisCustomer.Password;
        //        txtHouseNo.Text = AllCustomers.ThisCustomer.HouseNo;
        //        txtStreet.Text = AllCustomers.ThisCustomer.Street;
        //        txtTown.Text = AllCustomers.ThisCustomer.Town;
        //        txtPostCode.Text = AllCustomers.ThisCustomer.PostCode;

        //}


        void Update()
        {
            Int32 CustomerID;
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //create an instance ofthe collection class
            clsCustomerCollection CustomerCollection = new clsCustomerCollection();
            clsDataConnection DB = new clsDataConnection();
            //validate the data on the web form
            String Error = CustomerCollection.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtDateOfBirth.Text, txtEmail.Text, txtPassword.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostCode.Text);
            //if the data is ok the add it to the object
            if (Error == "")
            {
                //find the record to update
                CustomerCollection.ThisCustomer.Find(CustomerID);
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
                //updatethe record
                CustomerCollection.Update();
                ClearTextBoxes();
                lblError.Text = DisplayCustomers() + " customers found";
                lblAddEditConf.Text = "The account has been updated.";
                btnUpdate.Visible = false;
                btnAdd.Visible = true;



            }
            else
            {
                //report an error
                lblAddEditConf.Text = "There were problems with the data entered " + Error;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();

        }

        void ClearTextBoxes()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtHouseNo.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtTown.Text = string.Empty;
            txtPostCode.Text = string.Empty;
        }

        private void lblAddEditConf_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class ACustomer : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}



	protected void btnOK_Click1(object sender, EventArgs e)
	{
        Add();
        
	}

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key 
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = ACustomer.FirstName;
            txtLAstName.Text = ACustomer.LastName;
            txtEmail.Text = ACustomer.Email;
            txtPassword.Text = ACustomer.Password;
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtHouseNo.Text = ACustomer.HouseNo;
            txtStreet.Text = ACustomer.Street;
            txtTown.Text = ACustomer.Town;
            txtPostCode.Text = ACustomer.PostCode;
        }
        else
        {
            lblError.Text = "Customer not found";
        }
    }

        void Add()
        {
            //create an instance ofthe collection class
            clsCustomerCollection CustomerCollection = new clsCustomerCollection();
            //validate the data on the web form
            String Error = CustomerCollection.ThisCustomer.Valid(txtFirstName.Text, txtLAstName.Text, txtDateOfBirth.Text, txtEmail.Text, txtPassword.Text,  txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostCode.Text); 
            //if the data is ok the add it to the object
            if(Error=="")
            {
                //get the data entered by the user 
                CustomerCollection.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerCollection.ThisCustomer.LastName = txtLAstName.Text;
                CustomerCollection.ThisCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                CustomerCollection.ThisCustomer.Email = txtEmail.Text;
                CustomerCollection.ThisCustomer.Password = txtPassword.Text;
                CustomerCollection.ThisCustomer.HouseNo = txtHouseNo.Text;
                CustomerCollection.ThisCustomer.Street = txtStreet.Text;
                CustomerCollection.ThisCustomer.Town = txtTown.Text;
                CustomerCollection.ThisCustomer.PostCode = txtPostCode.Text;
                //add the record
                CustomerCollection.Add();
                lblError.Text = "New customer added succesfully";
            
            

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
         }
    }

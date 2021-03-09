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
		//create a new instance of clsCustomer
		clsCustomer ACustomer = new clsCustomer();
		//capture all the parameters
		string FirstName = txtFirstName.Text;
		string LastName = txtLAstName.Text;
		string Email = txtEmail.Text;
		string Password = txtPassword.Text;
		string DateOfBirth = txtDateOfBirth.Text;
		string HouseNo = txtHouseNo.Text;
		string Street = txtStreet.Text;
		string Town = txtTown.Text;
		string PostCode = txtPostCode.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password,  HouseNo, Street, Town, PostCode);
        if (Error == "")
        {
            //capture the name
            ACustomer.FirstName = FirstName;
            //capture the last name
            ACustomer.LastName = LastName;
            //capture an email
            ACustomer.Email = Email;
            //capture the password
            ACustomer.Password = Password;
            //capture the Date of birth 
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture the house no
            ACustomer.HouseNo = HouseNo;
            //capture the street
            ACustomer.Street = Street;
            //capture the town
            ACustomer.Town = Town;
            //capture the post code
            ACustomer.PostCode = PostCode;
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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
}
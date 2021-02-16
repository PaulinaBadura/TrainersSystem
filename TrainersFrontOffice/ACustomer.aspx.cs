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
		//capture the name
		ACustomer.FirstName = txtFirstName.Text;
		ACustomer.LastName = txtLAstName.Text;
		ACustomer.Email = txtEmail.Text;
		ACustomer.Password = txtPassword.Text;
		ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
		ACustomer.HouseNo = txtHouseNo.Text;
		ACustomer.Street = txtStreet.Text;
		ACustomer.Town = txtTown.Text;
		ACustomer.PostCode = txtPostCode.Text;
		//store the Name in the session object
		Session["ACustomer"] = ACustomer;
		//redirect to the viewer page
		Response.Redirect("CustomerViewer.aspx");
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
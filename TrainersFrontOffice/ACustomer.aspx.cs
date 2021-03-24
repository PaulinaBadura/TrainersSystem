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

    void ClearTextBoxes()
    {
        txtFirstName.Text = string.Empty;
        txtLAstName.Text = string.Empty;
        txtDateOfBirth.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtPassword.Text = string.Empty;
        txtHouseNo.Text = string.Empty;
        txtStreet.Text = string.Empty;
        txtTown.Text = string.Empty;
        txtPostCode.Text = string.Empty;
    }

    void Add()
        {
            //create an instance ofthe collection class
            clsCustomerCollection CustomerCollection = new clsCustomerCollection();
             clsDataConnection DB = new clsDataConnection();
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
                lblError.Text = "Your account has been created.";
            ClearTextBoxes();
            
            

            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
         }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerMainPage.aspx");
    }

    protected void btnExistingCustomer_Click(object sender, EventArgs e)
    {
        
    }
}

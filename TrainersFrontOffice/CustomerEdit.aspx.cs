using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class CustomerEdit : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the customer ID fromt the session 
        CustomerID = Convert.ToInt32(Session["CustomerID"]);

        if (IsPostBack == false)
        {
            //diplay current data for the record 
            DisplayData();
        }
    }


    void Update()
    {
        //create an instance ofthe collection class
        clsCustomerCollection CustomerCollection = new clsCustomerCollection();
        clsDataConnection DB = new clsDataConnection();
        //validate the data on the web form
        String Error = CustomerCollection.ThisCustomer.Valid(txtFirstName.Text, txtLAstName.Text, txtDateOfBirth.Text, txtEmail.Text, txtPassword.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostCode.Text);
        //if the data is ok the add it to the object
        if (Error == "")
        {
            //find the record to update
            CustomerCollection.ThisCustomer.Find(CustomerID);
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
            //updatethe record
            CustomerCollection.Update();
            ClearTextBoxes();
            lblError.Text = "Your account has been updated.";



        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        if (CustomerID != -1)
        {
            //update the record
            Update();
        }
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

    void DisplayData()
    {
        //instance of customer collection
        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //find the record to update
        AllCustomers.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtFirstName.Text = AllCustomers.ThisCustomer.FirstName;
        txtLAstName.Text = AllCustomers.ThisCustomer.LastName;
        txtEmail.Text = AllCustomers.ThisCustomer.Email;
        txtPassword.Text = AllCustomers.ThisCustomer.Password;
        txtDateOfBirth.Text = AllCustomers.ThisCustomer.DateOfBirth.ToString();
        txtHouseNo.Text = AllCustomers.ThisCustomer.HouseNo;
        txtStreet.Text = AllCustomers.ThisCustomer.Street;
        txtTown.Text = AllCustomers.ThisCustomer.Town;
        txtPostCode.Text = AllCustomers.ThisCustomer.PostCode;
    }

    protected void btnGoToAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("ExisitngCustomer.aspx");
    }

    protected void btnGoback_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerMainPage.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ExisitngCustomer.aspx");
    }
}
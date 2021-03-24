using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class CustomerDelete : System.Web.UI.Page
{
    //var to store customer id
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the customer id to be deleted from the session 
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        btnMainPage.Visible = false;
        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //find the record to update
        AllCustomers.ThisCustomer.Find(CustomerID);
        //display the data for this record
       lblEmail.Text = AllCustomers.ThisCustomer.FirstName;
    }

    void DeleteCustomer()
    {
        //function to delete the account 

        //create a new instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to delete
        Customers.ThisCustomer.Find(CustomerID);
        //delete the record
        Customers.Delete();
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteCustomer();
        //redirect bac to the main page
        btnMainPage.Visible = true;
        btnYes.Visible = false;
        btnNo.Visible = false;
        lblareyou.Text = "Your account has been deleted.";
        
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ExisitngCustomer.aspx");
    }

    protected void btnMainPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerMainPage.aspx");
    }
}
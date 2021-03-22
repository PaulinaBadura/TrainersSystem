using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class ExisitngCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
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
            //display the values of the properties in the labels
            lblID.Text = Convert.ToString(ACustomer.CustomerID);
            lblFirstName.Text = ACustomer.FirstName;
            lblLatName.Text = ACustomer.LastName;
            lblEmail.Text = ACustomer.Email;
            
        }
        else
        {
            lblError.Text = "Customer not found";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has beenselected from the list
        if (Convert.ToInt32(txtCustomerID.Text) != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(txtCustomerID.Text);
            //store the data in the sesion object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerDelete.aspx");

        }
        else
        {
            //display an error
            lblError.Text = "Please provide your ID";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has beenselected from the list
        if (Convert.ToInt32(txtCustomerID.Text) != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(txtCustomerID.Text);
            //store the data in the sesion object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerEdit.aspx");

        }
        else
        {
            //display an error
            lblError.Text = "Please provide your ID";
        }
    }
}
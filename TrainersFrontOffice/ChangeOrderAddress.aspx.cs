using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class ChangeOrderAddress : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayCustomerEmail();
    }


    Int32 DisplayCustomerEmail()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        //create variables to store data for primary key and for email
        string CustomerEmail;
        string CustomerID;
        Int32 Index = 0;
        //while the index is less that the number of records to process
        while (Index < Customers.Count)
        {
            CustomerEmail = Customers.CustomersList[Index].Email;
            CustomerID = Convert.ToString(Customers.CustomersList[Index].CustomerID);
            //set up the new row to be added to the list
            ListItem NewCustomer = new ListItem(CustomerEmail, CustomerEmail);
            //add the new row to the list
            ddlCustomer.Items.Add(NewCustomer);
            //increment index
            Index++;
        }
        //return the number of records found
        return Customers.Count;
    }


    protected void btnChange_Click(object sender, EventArgs e)
    {
        AddAddress();
    }

    void AddAddress()
    {
        //create instance of the class
        clsAddressCollection NewAddress = new clsAddressCollection();
        //validate the data on the web form
        String Error = NewAddress.ThisAddress.Valid(ddlCustomer.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostcode.Text);
        if (Error == "")
        {
            //capture emailaddress
            NewAddress.ThisAddress.Email = ddlCustomer.Text;
            //capture delivery town
            NewAddress.ThisAddress.HouseNo = txtHouseNo.Text;
            //capture date added
            NewAddress.ThisAddress.Street = txtStreet.Text;
            //capture order value
            NewAddress.ThisAddress.Town = txtTown.Text;
            //capture order status
            NewAddress.ThisAddress.PostCode = txtPostcode.Text;
            //add the record
            NewAddress.AddAddress();

            lblError.Text = "New address was added succesfully";

           
        }

        else
        {
            //report error

            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddOrder.aspx");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
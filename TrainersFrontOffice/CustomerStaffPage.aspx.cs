using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class CustomerStaffPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack ==false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of Customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data sources to the list of customers in the collection
        ListBoxCustomers.DataSource = Customers.CustomersList;
        //set the name of the primary key
        ListBoxCustomers.DataValueField = "CustomerID";
        //set the data fieldd to display
        ListBoxCustomers.DataTextField = "Email";
        //bind the data to the list
        ListBoxCustomers.DataBind();


    }
}
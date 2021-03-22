using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class AnOrderDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the listbox
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create instamce of the Order Collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of orders in the collection
        lstOrders.DataSource = Orders.OrderList;
        //set the name of primary key
        lstOrders.DataValueField = "OrderNo";
        //set the data field to display
        lstOrders.DataTextField = "CustomerID";
        //bind the data to the list
        lstOrders.DataBind();
    }

  
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the Customer ID for this entry
        Response.Write(AnOrder.EmailAddress);
        Response.Write(AnOrder.DeliveryTown);
        Response.Write(AnOrder.DateAdded);
        Response.Write(AnOrder.OrderStatus);
        Response.Write(AnOrder.OrderValue);
    }
}
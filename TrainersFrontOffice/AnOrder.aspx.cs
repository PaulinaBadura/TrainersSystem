using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void OKbtn_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture Customer ID
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AnOrder.DeliveryTown = txtDeliveryTown.Text;
        AnOrder.DateAdded = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.OrderStatus = txtOrderStatus.Text;
        AnOrder.OrderValue = Convert.ToInt32(txtOrderValue.Text);
       
        //store the customer ID in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to viewer page
        Response.Redirect("OrderViewer.aspx");



    }
}
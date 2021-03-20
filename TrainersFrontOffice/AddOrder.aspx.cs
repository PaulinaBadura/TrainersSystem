using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class AddOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    
   

    protected void OKbtn_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture Customer ID
        string CustomerID = txtCustomerID.Text;
        string DeliveryTown = txtDeliveryTown.Text;
        string DateAdded = txtOrderDate.Text;
        string OrderStatus = txtOrderStatus.Text;
        string OrderValue = txtOrderValue.Text;
        //variable to store error message
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(CustomerID, DeliveryTown, DateAdded, OrderStatus, OrderValue);
        if (Error == "")
        {
            //capture customer ID
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //capture delivery town
            AnOrder.DeliveryTown = DeliveryTown;
            //capture date added
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            //capture order value
            AnOrder.OrderValue = Convert.ToInt32(OrderValue);
            //capture order status
            AnOrder.OrderStatus = OrderStatus;

            //store the customer ID in the session object
            Session["AnOrder"] = AnOrder;
            //redirect to viewer page
            Response.Redirect("OrderViewer.aspx");

        }

        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create instance of the class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values in the form
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtDeliveryTown.Text = AnOrder.DeliveryTown;
            txtOrderDate.Text = AnOrder.DateAdded.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus.ToString();
            txtOrderValue.Text = AnOrder.OrderValue.ToString();


        }
    }
}
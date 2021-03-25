using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class ViewOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
                lblCustomerID1.Text = AnOrder.CustomerID.ToString();
                lblTown1.Text = AnOrder.DeliveryTown;
                lblDate1.Text = AnOrder.DateAdded.ToString();
                lblStatus1.Text = AnOrder.OrderStatus.ToString();
                lblOrderValue1.Text = AnOrder.OrderValue.ToString();
                lblEmail1.Text = AnOrder.EmailAddress;


            }
        }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
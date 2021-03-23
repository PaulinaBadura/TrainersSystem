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

        //update the developers of ddl
        DisplayCustomerEmail();

    }

    
   

    protected void OKbtn_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
       

        
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
            ddlCustomerID.Text = AnOrder.EmailAddress;
            txtDeliveryTown.Text = AnOrder.DeliveryTown;
            txtOrderDate.Text = AnOrder.DateAdded.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus.ToString();
            txtOrderValue.Text = AnOrder.OrderValue.ToString();


        }
    }

    Int32 DisplayCustomerEmail()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        //create variables to store primary key and customer's email
        string CustomerEmail;
        string CustomerID;
        Int32 Index = 0;
        //while the index is less that the number of records to process
        while (Index < Customers.Count)
        {
            CustomerEmail = Customers.CustomersList[Index].Email;
            CustomerID = Convert.ToString(Customers.CustomersList[Index].CustomerID);
            //set up the new row to be added to the list
            ListItem NewCustomer = new ListItem(CustomerEmail , CustomerEmail);
            //add the new row to the list
            ddlCustomerID.Items.Add(NewCustomer);
            //increment index
            Index++;
        }
        //return the number of records found
        return Customers.Count;
    }

    void Add()
    {
        //create instance of the class
        clsOrderCollection NewOrder = new clsOrderCollection();
        //validate the data on the web form
        String Error = NewOrder.ThisOrder.Valid(ddlCustomerID.Text, txtDeliveryTown.Text, txtOrderDate.Text, txtOrderStatus.Text, txtOrderValue.Text);
        if (Error == "")
        {
            //capture emailaddress
            NewOrder.ThisOrder.EmailAddress = ddlCustomerID.Text;
            //capture delivery town
            NewOrder.ThisOrder.DeliveryTown = txtDeliveryTown.Text;
            //capture date added
            NewOrder.ThisOrder.DateAdded = Convert.ToDateTime(txtOrderDate.Text);
            //capture order value
            NewOrder.ThisOrder.OrderValue = Convert.ToInt32(txtOrderValue.Text);
            //capture order status
            NewOrder.ThisOrder.OrderStatus = txtOrderStatus.Text;
            //add the record
            NewOrder.Add();

            lblError.Text = "New order was added succesfully";
        }

        else
        {
            //report error

            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }

    protected void BtnChange_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangeOrderAddress.aspx");
    }
}
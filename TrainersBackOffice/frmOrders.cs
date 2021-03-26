using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainersClasses;

namespace TrainersBackOffice
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
            btnNo.Visible = false;
            btnYes.Visible = false;
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //call the display customers function
            lblError.Text = DisplayOrders() + " orders found";
        }

        Int32 DisplayOrders()
        {
            //create instamce of the Order Collection
            clsOrderCollection Orders = new clsOrderCollection();
            //set the data source to the list of orders in the collection
            lstOrders.DataSource = Orders.OrderList;
            //set the name of primary key
            lstOrders.ValueMember = "OrderNo";
            //set the data field to display
            lstOrders.DisplayMember = "OrderNo";
            return Orders.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        void Add()
        {
            //create instance of the class
            clsOrderCollection NewOrder = new clsOrderCollection();
            //validate the data on the web form
            String Error = NewOrder.ThisOrder.Valid(txtCustomerID.Text, txtDeliveryTown.Text, txtOrderDate.Text, txtOrderStatus.Text, txtOrderValue.Text, txtCustomerID.Text);
            if (Error == "")
            {
                NewOrder.ThisOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                //capture emailaddress
                NewOrder.ThisOrder.EmailAddress = txtCustomerID.Text;
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

                lblError.Text = "New order was added succesfully. ";
            }



            else
            {
                //report error

                lblError1.Text = Error;
            }
        }

       
        private void btnEdit_Click(object sender, EventArgs e)
           {
             //var to store the primary key value of the record to be deleted
             Int32 OrderNo;
             //if a record has beenselected from the list
            if (lstOrders.SelectedIndex != -1)
            { 
                //get the primary key value of the record to delete
                OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
                //find the record to edit 
                //we need to use our collection class
                clsOrderCollection AllOrders = new clsOrderCollection();
                AllOrders.ThisOrder.Find(OrderNo);
                //display the data for record with chosen OrderNo
                txtCustomerID.Text = AllOrders.ThisOrder.CustomerID.ToString();
                txtEmail.Text = AllOrders.ThisOrder.EmailAddress;
                txtDeliveryTown.Text = AllOrders.ThisOrder.DeliveryTown;
                txtOrderDate.Text = AllOrders.ThisOrder.DateAdded.ToString();
                txtOrderValue.Text = AllOrders.ThisOrder.OrderValue.ToString();
                txtOrderStatus.Text = AllOrders.ThisOrder.OrderStatus;

            }
            else
            {
                    //display an error
                    lblError1.Text = "You must select an item from the list to edit it.";
            }

            }//end of edit

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        void Update()
        {
            Int32 OrderNo;
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            //create an instance of order collection class
            clsOrderCollection OrderCollection = new clsOrderCollection();
            clsDataConnection DB = new clsDataConnection();
            //validate the data on the web form
            String Error = OrderCollection.ThisOrder.Valid(txtCustomerID.Text, txtDeliveryTown.Text, txtOrderDate.Text, txtOrderStatus.Text, txtOrderValue.Text, txtCustomerID.Text);
            //if there is no error
            if (Error == "")
            {
                //find the record using primary key to update
                OrderCollection.ThisOrder.Find(OrderNo);
                //get the data entered by the user 
                OrderCollection.ThisOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                //capture emailaddress
                OrderCollection.ThisOrder.EmailAddress = txtEmail.Text;
                //capture delivery town
                OrderCollection.ThisOrder.DeliveryTown = txtDeliveryTown.Text;
                //capture date added
                OrderCollection.ThisOrder.DateAdded = Convert.ToDateTime(txtOrderDate.Text);
                //capture order value
                OrderCollection.ThisOrder.OrderValue = Convert.ToInt32(txtOrderValue.Text);
                //capture order status
                OrderCollection.ThisOrder.OrderStatus = txtOrderStatus.Text;
                //updatethe record
                OrderCollection.Update();
                Clear();
                lblError.Text = DisplayOrders() + " Orders found";
                lblError1.Text = "The order has been updated.";
            }
            else
            {
                //report an error
                lblError1.Text = "There were problems with the data entered " + Error;
            }

        }//end of edit

        //function to clear the data in the text boxes
        void Clear()
        {
            txtCustomerID.Text = string.Empty;
            txtDeliveryTown.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtOrderStatus.Text = string.Empty;
            txtOrderValue.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 OrderNo;
            //if a record has beenselected from the list
            if (lstOrders.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
                //show confirmation message
                lblError1.Text = "Are you sure you want to delete this order?";

                //show buttons which were not visible before to confirm
                btnNo.Visible = true;
                btnYes.Visible = true;

            }
            else
            {
                //display an error
                lblError1.Text = "Please select a record from the list first. ";
            }
        }

        void Delete()
        {
            //var to store primary key value
            Int32 OrderNo;
            //create a new in stance of collection class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //find the record to delete
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            AllOrders.ThisOrder.Find(OrderNo);
            //delete the record 
            AllOrders.Delete();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            
            Delete();
            //show confirmation message
            lblError1.Text = "Order has ben deleted";
            btnYes.Visible = false;
            btnNo.Visible = false;

            Clear();
            DisplayOrders();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            lblError1.Text = string.Empty;
            btnYes.Visible = false;
            btnNo.Visible = false;
        }

        private void btnFiterID_Click(object sender, EventArgs e)
        {
            //create an instance of the Order class
            clsOrder AnOrder = new clsOrder();
            //variable to store the primary key 
            Int32 OrderNo;
            //variable to store the result of the find operation
            Boolean Found = false;
            //if the filter was provided
            if (txtFilterID.Text != "")
            {
                //get the primary key entered by the user
                OrderNo = Convert.ToInt32(txtFilterID.Text);
                //find the record
                Found = AnOrder.Find(OrderNo);
                //a list so that the DataSource can be used then 
                List<string> Order = new List<string>();
                //if found
                if (Found == true)
                {
                    Order.Add(AnOrder.EmailAddress);
                    lstOrders.DataSource = Order;
                    //set the text to be displayed
                    lstOrders.DisplayMember = "Email";
                    lblError.Text = "1 record found";
                }
                else
                {
                    lblError.Text = "Order number not found";
                }
            }
            else
            {
                //show an error 
                lblError1.Text = "Provide a valid Order Number";
            }
        }

        Int32 DisplayOrdersbyCustomerID(int CustomerIDFilter )
        {
            //this function works to filter the orders by customer id, it accepts one parameter

            //new instance of the clsOrderCollection
            clsOrderCollection AllOrders = new clsOrderCollection();
            //var to store the count of the record
            Int32 Count;
            //var to store CustomerID
            int CustomerID;
            //var to store the index
            Int32 Index = 0;
            //call the filter by post code method
            AllOrders.ReportByCustomerID(CustomerIDFilter);
            //get the count of records found
            Count = AllOrders.Count;
            //loop through each record found using the index to point to each record in data table
            while (Index < Count)
            {
                CustomerID = Convert.ToInt32(AllOrders.OrderList[Index].CustomerID);
                //set up a new object of class list item
                lstOrders.DataSource = AllOrders.OrderList;
                //set the text to be displayed
                lstOrders.DisplayMember = "CustomerID";
                //increment the index
                Index++;
            }
            //return the number of records found
            return Count;

        }

        private void btnFilterCustomerID_Click(object sender, EventArgs e)
        {
            //if data in the text box is provided
            if (txtCustomerIDFilter.Text != "")
            {
                //declare var to store the record count
                Int32 Count;
                Count = DisplayOrdersbyCustomerID(Convert.ToInt32(txtCustomerIDFilter.Text));
                //display the number of records found
                lblError.Text = Count + " records found";
            }
            else
            {
                //display an error
                lblError1.Text = "Provide a valid filter";
            }
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            //if data in the text box is provided
            if (txtOrderStatusFilter.Text != "")
            {
                //declare var to store the record count
                Int32 Count;
                Count = DisplayOrdersbyOrderStatus(txtOrderStatusFilter.Text);
                //display the number of records found
                lblError.Text = Count + " records found";
            }
            else
            {
                //display an error
                lblError1.Text = "Provide a valid filter";
            }
        }

        Int32 DisplayOrdersbyOrderStatus(string OrderStatusFilter)
        {
            //this function works to filter the orders by order status, it accepts one parameter

            //new instance of the clsOrderCollection
            clsOrderCollection AllOrders = new clsOrderCollection();
            //var to store the count of the record
            Int32 Count;
            //var to store OrderStatus
            string OrderStatus;
            //var to store the index
            Int32 Index = 0;
            //call the filter 
            AllOrders.ReportByOrderStatus(OrderStatusFilter);
            //get the count of records found
            Count = AllOrders.Count;
            //loop through each record found using the index to point to each record in data table
            while (Index < Count)
            {
                OrderStatus = Convert.ToString(AllOrders.OrderList[Index].OrderStatus);
                //set up a new object of class list item
                lstOrders.DataSource = AllOrders.OrderList;
                //set the text to be displayed
                lstOrders.DisplayMember = "OrderStatus";
                //increment the index
                Index++;
            }
            //return the number of records found
            return Count;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainPageBackend MainPage = new frmMainPageBackend();
            MainPage.Show();
            this.Hide();
        }
    }
    }
    
    


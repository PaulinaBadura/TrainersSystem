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
    public partial class frmOrderLine : Form
    {
        public frmOrderLine()
        {
            InitializeComponent();
            btnNo.Visible = false;
            btnYes.Visible = false;
        }

        private void frmOrderLine_Load(object sender, EventArgs e)
        {

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            // call the display customers function
            lblError.Text = DisplayOrders() + " orders found";
        }

        Int32 DisplayOrders()
        {
            //create instamce of the Order Collection
            clsOrderLineCollection Orders = new clsOrderLineCollection();
            //set the data source to the list of orders in the collection
            lstOrderLine.DataSource = Orders.OrderLineList;
            //set the name of primary key
            lstOrderLine.ValueMember = "OrderLineID";
            //set the data field to display
            lstOrderLine.DisplayMember = "OrderLineID";

            return Orders.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        void Add()
        {
            //create instance of the class
            clsOrderLineCollection NewOrder = new clsOrderLineCollection();
            //validate the data on the web form
            String Error = NewOrder.ThisOrderLine.Valid(txtTrainerID.Text, txtOrderNo.Text, txtQuantity.Text, txtPrice.Text);
            if (Error == "")
            //string trainerID, string orderNo, string quantity, string price
            {
                //capture trainer ID
                NewOrder.ThisOrderLine.TrainerID = Convert.ToInt32(txtTrainerID.Text);
                //capture order no
                NewOrder.ThisOrderLine.OrderNo = Convert.ToInt32(txtOrderNo.Text);
                //capture quantity
                NewOrder.ThisOrderLine.OrderQty = Convert.ToInt32(txtQuantity.Text);
                //capture price
                NewOrder.ThisOrderLine.Price = Convert.ToInt32(txtPrice.Text);

                NewOrder.Add();

                lblError.Text = "New trainer was successfully added into your order!";
            }


            else
            {
                //report error

                lblError.Text = "There were problems with the data entered: " + Error;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 OrderLineID;
            //if a record has been selected from the list
            if (lstOrderLine.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderLineID = Convert.ToInt32(lstOrderLine.SelectedValue);
                //find the record to edit 
                //we need to use our collection class
                clsOrderLineCollection AllOrders = new clsOrderLineCollection();
                AllOrders.ThisOrderLine.Find(OrderLineID);
                //display the data for record with chosen OrderNo
                txtTrainerID.Text = AllOrders.ThisOrderLine.TrainerID.ToString();
                txtOrderNo.Text = AllOrders.ThisOrderLine.OrderNo.ToString();
                txtPrice.Text = AllOrders.ThisOrderLine.Price.ToString();
                txtQuantity.Text = AllOrders.ThisOrderLine.OrderQty.ToString();

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
            Int32 OrderLineID;
            OrderLineID = Convert.ToInt32(lstOrderLine.SelectedValue);
            //create an instance of order collection class
            clsOrderLineCollection OrderLineCollection = new clsOrderLineCollection();
            clsDataConnection DB = new clsDataConnection();
            //validate the data on the web form
            String Error = OrderLineCollection.ThisOrderLine.Valid(txtTrainerID.Text, txtOrderNo.Text, txtQuantity.Text, txtPrice.Text);
            //if there is no error
            if (Error == "")
            {
                //find the record using primary key to update
                OrderLineCollection.ThisOrderLine.Find(OrderLineID);
                //get the data entered by the user 
                OrderLineCollection.ThisOrderLine.TrainerID = Convert.ToInt32(txtTrainerID.Text);
                //capture orderNo
                OrderLineCollection.ThisOrderLine.OrderNo= Convert.ToInt32(txtOrderNo.Text);
                //capture Price
                OrderLineCollection.ThisOrderLine.Price = Convert.ToInt32(txtPrice.Text);
                //capture quantity
                OrderLineCollection.ThisOrderLine.OrderQty = Convert.ToInt32(txtQuantity.Text);
                //updatethe record
                OrderLineCollection.Update();
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
            txtOrderNo.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtTrainerID.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 OrderLineID;
            //if a record has beenselected from the list
            if (lstOrderLine.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderLineID = Convert.ToInt32(lstOrderLine.SelectedValue);
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

        void Delete()
        {
            //var to store primary key value
            Int32 OrderLineID;
            //create a new in stance of collection class
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            //find the record to delete
            OrderLineID = Convert.ToInt32(lstOrderLine.SelectedValue);
            AllOrders.ThisOrderLine.Find(OrderLineID);
            //delete the record 
            AllOrders.Delete();
        }
    }
}

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
            lstOrders.DisplayMember = "CustomerID";
            return Orders.Count;
        }
    }
}

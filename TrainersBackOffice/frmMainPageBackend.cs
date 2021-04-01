using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainersBackOffice
{
    public partial class frmMainPageBackend : Form
    {
        public frmMainPageBackend()
        {
            InitializeComponent();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers Customers = new frmCustomers();
            Customers.Show();
            this.Hide();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            frmOrders Orders = new frmOrders();
            Orders.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnOrderLine_Click(object sender, EventArgs e)
        {
            frmOrderLine OrderLine = new frmOrderLine();
            OrderLine.Show();
            this.Hide();
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            frmTrainers Trainers = new frmTrainers();
            Trainers.Show();
            this.Hide();
        }
    }
}

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
    }
}

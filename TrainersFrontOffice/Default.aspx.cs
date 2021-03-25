using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

    protected void btnAddOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddOrder.aspx");

    }

    protected void btnAddTrainer_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddOrderLine.aspx");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewOrder.aspx");
    }
}
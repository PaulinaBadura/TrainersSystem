using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		//create new instance of clsCustomer
		clsCustomer ACustomer = new clsCustomer();
		//get the data from the session object 
		ACustomer = (clsCustomer)Session["ACustomer"];
		//display the first name for this entry
		Response.Write(ACustomer.FirstName);
		Response.Write(ACustomer.LastName);
		Response.Write(ACustomer.Email);
		Response.Write(ACustomer.Password);
		Response.Write(ACustomer.DateOfBirth);
		Response.Write(ACustomer.HouseNo);
		Response.Write(ACustomer.Street);
		Response.Write(ACustomer.Town);
		Response.Write(ACustomer.PostCode);
	}
}
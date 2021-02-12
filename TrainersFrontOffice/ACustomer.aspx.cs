using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class ACustomer : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}



	protected void btnOK_Click1(object sender, EventArgs e)
	{
		//create a new instance of clsCustomer
		clsCustomer ACustomer = new clsCustomer();
		//capture the name
		ACustomer.FirstName = txtFirstName.Text;
		ACustomer.LastName = txtLAstName.Text;
		ACustomer.Email = txtEmail.Text;
		ACustomer.Password = txtPassword.Text;
		ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
		ACustomer.HouseNo = txtHouseNo.Text;
		ACustomer.Street = txtStreet.Text;
		ACustomer.Town = txtTown.Text;
		ACustomer.PostCode = txtPostCode.Text;
		//store the Name in the session object
		Session["ACustomer"] = ACustomer;
		//redirect to the viewer page
		Response.Redirect("CustomerViewer.aspx");
	}
}
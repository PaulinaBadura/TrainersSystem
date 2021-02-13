using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class ATrainer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsTrainers
        clsTrainers ATrainer = new clsTrainers();
        //capture the properties
        ATrainer.Brand = txtBrand.Text;
        ATrainer.Name = txtName.Text;
        ATrainer.Colour = ddlColour.Text;
        ATrainer.Size = Convert.ToInt32(txtSize.Text);
        ATrainer.Price = Convert.ToDecimal(txtPrice.Text);
        ATrainer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //store the trainers in the session object
        Session["ATrainer"] = ATrainer;
        //redirect to the viewer page
        Response.Redirect("TrainerViewer.aspx");
    }
}
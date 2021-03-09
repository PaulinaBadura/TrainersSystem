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
        string Brand = txtBrand.Text;
        string Name = txtName.Text;
        string Colour = ddlColour.Text;
        string Size = txtSize.Text;
        string Price = txtPrice.Text;
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data 
        Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
        if (Error == "")
        {
            //capture the properties
            ATrainer.Brand = Brand;
            ATrainer.Name = Name;
            ATrainer.Colour = Colour;
            ATrainer.Size = Convert.ToInt32(Size);
            ATrainer.Price = Convert.ToDecimal(Price);
            ATrainer.DateAdded = Convert.ToDateTime(DateAdded);
            //store the trainers in the session object
            Session["ATrainer"] = ATrainer;
            //redirect to the viewer page
            Response.Redirect("TrainerViewer.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the trainers class
        clsTrainers ATrainer = new clsTrainers();
        //variable to store the primary key
        Int32 TrainerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        TrainerID = Convert.ToInt32(txtTrainerID.Text);
        //find the record
        Found = ATrainer.Find(TrainerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtBrand.Text = ATrainer.Brand;
            txtName.Text = ATrainer.Name;
            ddlColour.Text = ATrainer.Colour;
            txtSize.Text = ATrainer.Size.ToString();
            txtPrice.Text = ATrainer.Price.ToString();
            txtDateAdded.Text = ATrainer.DateAdded.ToString();
        }
        else
        {
            lblError.Text = "Trainer not found";
        }
    }
}
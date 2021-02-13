using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class TrainerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the class clsTrainers
        clsTrainers ATrainer = new clsTrainers();
        //get the data from the session object
        ATrainer = (clsTrainers)Session["ATrainer"];
        //display the properties of this entry
        Response.Write(ATrainer.Brand);
        Response.Write(ATrainer.Name);
        Response.Write(ATrainer.Colour);
        Response.Write(ATrainer.Size);
        Response.Write(ATrainer.Price);
        Response.Write(ATrainer.DateAdded);
        Response.Write(ATrainer.InStock);
    }
}
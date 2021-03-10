using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class TrainerDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayTrainers();
        }
    }
    void DisplayTrainers()
    {
        //create an instance of the Trainers Collection
        clsTrainersCollection Trainers = new clsTrainersCollection();
        //set the data source to the list of orders in the collection
        lstTrainers.DataSource = Trainers.TrainersList;
        //set the name of primary key
        lstTrainers.DataValueField = "TrainerID";
        //set the data field to display
        lstTrainers.DataTextField = "Brand";
        //bind the data to the list
        lstTrainers.DataBind();
    }
}
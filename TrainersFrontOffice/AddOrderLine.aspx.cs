using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class AddOrderLine : System.Web.UI.Page
{
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayPrice();
    }

    protected void OKbtn_Click(object sender, EventArgs e)
    {
        Add();
    }

    void Add()
    {
        //create instance of the class
        clsOrderLineCollection NewOrder = new clsOrderLineCollection();
        //validate the data on the web form
        String Error = NewOrder.ThisOrderLine.Valid(txtTrainerID.Text, txtOrderNo.Text, txtQuantity.Text, ddlTrainerID.Text);
        if (Error == "")
            //string trainerID, string orderNo, string quantity, string price
        {
            //capture trainer ID
            NewOrder.ThisOrderLine.TrainerID = Convert.ToInt32(txtTrainerID.Text);
            //capture order no
            NewOrder.ThisOrderLine.OrderNo = Convert.ToInt32(txtOrderNo.Text);
            //capture quantity
            NewOrder.ThisOrderLine.OrderQty = Convert.ToInt32(txtQuantity.Text);
            //capture price
            NewOrder.ThisOrderLine.Price = Convert.ToInt32(ddlTrainerID.Text);
            
            NewOrder.Add();

            lblError.Text = "New trainer was successfully added into your order!";
        }


        else
        {
            //report error

            lblError.Text = "There were problems with the data entered: " + Error;
        }
    }

    Int32 DisplayPrice()
    {
        clsTrainersCollection Trainers = new clsTrainersCollection();
        //create variables to store primary key and customer's email
        string Price;
        string TrainerID;
        Int32 Index = 0;
        //while the index is less that the number of records to process
        while (Index < Trainers.Count)
        {
            Price = Convert.ToString(Trainers.TrainersList[Index].Price);
            TrainerID = Convert.ToString(Trainers.TrainersList[Index].TrainerID);
            //set up the new row to be added to the list
            ListItem NewTrainer = new ListItem(Price, Price);
            //add the new row to the list
            ddlTrainerID.Items.Add(NewTrainer);
            //increment index
            Index++;
        }
        //return the number of records found
        return Trainers.Count;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddOrder.aspx");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
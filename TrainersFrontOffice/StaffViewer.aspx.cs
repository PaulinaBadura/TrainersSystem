using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object 
        AStaff = (clsStaff)Session["AStaff"];
        //display the first name for this entry
        Response.Write(AStaff.FirstName);
        //display the last name for this entry
        Response.Write(AStaff.LastName);
        Response.Write(AStaff.DateOfBirth);
        Response.Write(AStaff.Department);
        Response.Write(AStaff.Email);
        Response.Write(AStaff.Password);
        
    }
}
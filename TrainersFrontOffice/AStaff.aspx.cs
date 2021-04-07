using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainersClasses;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key 
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AStaff.FirstName;
            txtLastName.Text = AStaff.LastName;
            txtDateOfBirth.Text = AStaff.DateOfBirth.ToString();
            txtDepartment.Text = AStaff.Department;
            txtEmail.Text = AStaff.Email;
            txtPassword.Text = AStaff.Password;

        }

        else
        {
            lblError.Text = "Staff not found";
        }

    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key 
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AStaff.FirstName;
            txtLastName.Text = AStaff.LastName;
            txtDateOfBirth.Text = AStaff.DateOfBirth.ToString();
            txtDepartment.Text = AStaff.Department;
            txtEmail.Text = AStaff.Email;
            txtPassword.Text = AStaff.Password;
        }
        else
        {
            lblError.Text = "Staff not found";
        }

    }
}

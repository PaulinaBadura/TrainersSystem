using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainersClasses;

namespace TrainersBackOffice
{
    public partial class frmTrainers : Form
    {
        public frmTrainers()
        {
            InitializeComponent();
            btnYes.Visible = false;
            btnNo.Visible = false;
            btnUpdate.Visible = false;
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainPageBackend MainPage = new frmMainPageBackend();
            MainPage.Show();
            this.Hide();
        }

        Int32 DisplayTrainers()
        {
            //create an instance of the trainers collection
            clsTrainersCollection MyTrainers = new clsTrainersCollection();
            //find all trainers
            lstTrainers.DataSource = MyTrainers.TrainersList;
            //set the text to be displayed
            lstTrainers.DisplayMember = "Brand" + "Name";
            lstTrainers.ValueMember = "TrainerID";
            //return the count of the records in the list
            return MyTrainers.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add new record
            Add();
        }

        //method for adding new records
        void Add()
        {
            //create an instance of the trainers collection
            clsTrainersCollection NewTrainers = new clsTrainersCollection();
            //validate the data on the webform
            String Error = NewTrainers.ThisTrainer.Valid(txtBrand.Text, txtName.Text, txtColour.Text, txtSize.Text, txtPrice.Text, txtDateAdded.Text);
            //if the data is OK then add it to the project            
            if (Error == "")
            {
                //get the data entered by the user
                NewTrainers.ThisTrainer.Brand = txtBrand.Text;
                NewTrainers.ThisTrainer.Name = txtName.Text;
                NewTrainers.ThisTrainer.Colour = txtColour.Text;
                NewTrainers.ThisTrainer.Size = Convert.ToInt32(txtSize.Text);
                NewTrainers.ThisTrainer.Price = Convert.ToDecimal(txtPrice.Text);
                NewTrainers.ThisTrainer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                NewTrainers.ThisTrainer.InStock = chkInStock.Checked;
                //add the record 
                NewTrainers.Add();
                //confirmation message box
                MessageBox.Show("New Trainer was added succesfully. ", "Trainers list", MessageBoxButtons.OK);
                //lblError.Text = "Trainers was added succesfully. ";
                ClearTextBoxes();
                //lblError.Text = DisplayTrainers() + " trainers found";
            }
            else
            {
                //Error message
                MessageBox.Show("There were problems with the data entered. " + Error);
                //lblError.Text = "There were problems with the data entered " + Error;
            }
        }
        //method to clear the text boxes
        void ClearTextBoxes()
        {
            txtBrand.Text = string.Empty;
            txtName.Text = string.Empty;
            txtColour.Text = string.Empty;
            txtSize.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtDateAdded.Text = string.Empty;
            chkInStock.Text = string.Empty;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var to to store the primary key value of the record to be deleted
            Int32 TrainerID;
            //if a record has been selected from the list
            if (lstTrainers.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                TrainerID = Convert.ToInt32(lstTrainers.SelectedValue);
                //show confirmation message and buttons
                lblConfirmation.Text = "Are you sure you want to delete this customer?";
                btnNo.Visible = true;
                btnYes.Visible = true;
            }
            else
            {
                //Error message
                MessageBox.Show("Please select a record from the list first. ", "Trainers list", MessageBoxButtons.OK);
            }
        }

        void DeleteTrainers()
        {
            Int32 TrainerID;
            //function to delete selected record
            //create a new instance of the trainers collection
            clsTrainersCollection AllTrainers = new clsTrainersCollection();
            //find the record to delete
            TrainerID = Convert.ToInt32(lstTrainers.SelectedValue);
            AllTrainers.ThisTrainer.Find(TrainerID);
            //delete the record 
            AllTrainers.Delete();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteTrainers();
            //show confirmation message
            lblConfirmation.Text = "Record has ben deleted";
            btnYes.Visible = false;
            btnNo.Visible = false;
            lblError.Text = DisplayTrainers() + " trainers found";
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //call the display trainers function
            lblError.Text = DisplayTrainers() + " trainers found";

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            lblConfirmation.Text = string.Empty;
            btnNo.Visible = false;
            btnYes.Visible = false;
        }
    }
}

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
                MessageBox.Show ("New Trainer was added succesfully. ", "Trainers list", MessageBoxButtons.OK);
                //lblError.Text = "Trainers was added succesfully. ";
                ClearTextBoxes();
            }
            else
            {
                //Error message
                MessageBox.Show("There were problems with the data entered. " + Error);
                //lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainPageBackend MainPage = new frmMainPageBackend();
            MainPage.Show();
            this.Hide();
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
                MessageBox.Show("Are you sure you want to delete this trainers? ", "Trainers list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                //Error message
                MessageBox.Show("Please select a record from the list first. ", "Trainers list", MessageBoxButtons.OK);
            }
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //call the display trainers method
            lblError.Text = DisplayTrainers() + " trainers found";
        }

        Int32 DisplayTrainers()
        {
            //create instamce of the Order Collection
            clsTrainersCollection Trainers = new clsTrainersCollection();
            //set the data source to the list of orders in the collection
            lstTrainers.DataSource = Trainers.TrainersList;
            //set the name of primary key
            lstTrainers.ValueMember = "TrainerID";
            //set the data field to display
            lstTrainers.DisplayMember = "TrainerID";
            return Trainers.Count;
        }

    }
}

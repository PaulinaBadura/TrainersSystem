using System.Collections.Generic;
using System;

namespace TrainersClasses
{
    public class clsTrainersCollection
    {
        //constructor for the class
        //private data member for the list
        List<clsTrainers> mTrainersList = new List<clsTrainers>();
        //private data member thisTrainer
        clsTrainers mThisTrainer = new clsTrainers();

        //public property for ThisTrainer
        public clsTrainers ThisTrainer
        {
            get
            {
                //return the private data
                return mThisTrainer;
            }
            set
            {
                //set the private data
                mThisTrainer = value;
            }
        }

        public clsTrainersCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblTrainers_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    
  
        //public property for the trainers list
        public List<clsTrainers> TrainersList
        {
            get
            {
                //return the private data
                return mTrainersList;
            }
            set
            {
                //set the private data
                mTrainersList = value;
            }
        }
        
        public int Count
        {
            get
            {
                //return the count of the list
                return mTrainersList.Count;
            }
            set
            {

            }
        }
       
        public int Add()
        {
            //adds a new record to the database based on the values of mThisTrainer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Brand", mThisTrainer.Brand);
            DB.AddParameter("@Name", mThisTrainer.Name);
            DB.AddParameter("@Colour", mThisTrainer.Colour);
            DB.AddParameter("@Size", mThisTrainer.Size);
            DB.AddParameter("@Price", mThisTrainer.Price);
            DB.AddParameter("@DateAdded", mThisTrainer.DateAdded);
            DB.AddParameter("@InStock", mThisTrainer.InStock);
            //execute the query returning the primary key of the new record
            return DB.Execute("sproc_tblTrainers_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisTrainer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TrainerID", mThisTrainer.TrainerID);
            //execute the stored procedure
            DB.Execute("sproc_tblTrainers_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisTrainer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TrainerID", mThisTrainer.TrainerID);
            DB.AddParameter("@Brand", mThisTrainer.Brand);
            DB.AddParameter("@Name", mThisTrainer.Name);
            DB.AddParameter("@Colour", mThisTrainer.Colour);
            DB.AddParameter("@Size", mThisTrainer.Size);
            DB.AddParameter("@Price", mThisTrainer.Price);
            DB.AddParameter("@DateAdded", mThisTrainer.DateAdded);
            DB.AddParameter("@InStock", mThisTrainer.InStock);
            //execute the stored procedure
            DB.Execute("sproc_tblTrainers_Update");
        }

        public void ReportByBrand(string Brand)
        {
            //filters the record based on a full or partial brand
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Brand parameter to the database
            DB.AddParameter("@Brand", Brand);
            //execute the stored procedure
            DB.Execute("sproc_tblTrainers_FilterByBrand");
            //populate the array list with the data table
            PopulateArray(DB);          
         
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records 
            RecordCount = DB.Count;
            //clear the private array list
            mTrainersList = new List<clsTrainers>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank trainers 
                clsTrainers ATrainer = new clsTrainers();
                //read in the fields from the current record 
                ATrainer.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                ATrainer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ATrainer.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                ATrainer.Size = Convert.ToInt32(DB.DataTable.Rows[Index]["Size"]);
                ATrainer.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                ATrainer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                ATrainer.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //add the record to the private data member
                mTrainersList.Add(ATrainer);
                //point to the next record 
                Index++;
            }
        }
    }
}
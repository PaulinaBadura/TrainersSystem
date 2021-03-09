using System.Collections.Generic;
using System;

namespace TrainersClasses
{
    public class clsTrainersCollection
    {
        //contructor for the class
        public clsTrainersCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblTrainers_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //While there are records to process 
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
                ATrainer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ATrainer.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //add the record to the private data member
                mTrainersList.Add(ATrainer);
                //point to the next record 
                Index++;
            }
        }
    
   
        //private data member for the list
        List<clsTrainers> mTrainersList = new List<clsTrainers>();
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
        public clsTrainers ThisTrainers { get; set; }
    }
}
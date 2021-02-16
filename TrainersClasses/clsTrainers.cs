using System;

namespace TrainersClasses
{
    public class clsTrainers
    {
        private Int32 mTrainerID;
        private DateTime mDateAdded;
        private string mBrand;
        private string mName;
        private string mColour;
        private Int32 mSize;
        private decimal mPrice;
        private Boolean mInStock;
        public bool InStock
        {
            get
            {
                //send data out of the property
                return mInStock;
            }
            set
            {
                //send data into the property
                mInStock = value;
            }
        }
        public string Brand
        {
            get
            {
                //send data out of the property
                return mBrand;
            }
            set
            {
                //send data into the property
                mBrand = value;
            }
        }
        public int Size
        {
            get
            {
                //data out of the property
                return mSize;
            }
            set
            {
                //data into the property
                mSize = value;
            }
        }
        public decimal Price
        {
            get
            {
                //send data out of the property
                return mPrice;
            }
            set
            {
                //send data into the property
                mPrice = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                //sends data out of the property
                return mDateAdded;
            }
            set
            {
                //data into the property
                mDateAdded = value;
            }
        }
        public string Name
        {
            get
            {
                //send data out of the property
                return mName;
            }
            set
            {
                //send data into the property
                mName = value;
            }
        }
        public string Colour
        {
            get
            {
                //data out of the property
                return mColour;
            }
            set
            {
                //send data into the property
                mColour = value;
            }
        }

        public int TrainerID
        {
            get
            {
                //this line of code sends data out of the property
                return mTrainerID;
            }
            set
            {
                //this line of code allows data into the property
                mTrainerID = value;
            }
        }

        public bool Find(int TrainerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the trainer id to search for
            DB.AddParameter("@TrainerID", TrainerID);
            //execute the stored procedure
            DB.Execute("sproc_tblTrainers_FilterByTrainerID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mTrainerID = Convert.ToInt32(DB.DataTable.Rows[0]["TrainerID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mSize = Convert.ToInt32(DB.DataTable.Rows[0]["Size"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                //return that everything worked fine
                return true;
            }
            //if no record found
            else
            {
                //return false indicatiing a problem
                return false;
            }
            
           
        }

       
    }
}
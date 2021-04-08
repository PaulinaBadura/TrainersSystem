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
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mSize = Convert.ToInt32(DB.DataTable.Rows[0]["Size"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
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

        public string Valid(string brand, string name, string colour, string size, string price, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //temporary variable to store size values
            Int32 SizeTemp;
            //temp variable to store price values
            Decimal PriceTemp;
            //if the brand is blank
            if (brand.Length == 0)
            {
                //record the error 
                Error = Error + "The brand may not be blank : ";
            }
            //if the brand is greater than 50 characters
            if (brand.Length > 50)
            {
                //record the error
                Error = Error + "The brand must not be more than 50 characters : ";
            }
            if (name.Length == 0)
            {
                //record the error 
                Error = Error + "The name may not be blank : ";
            }
            //if the brand is greater than 50 characters
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The name must not be more than 50 characters : ";
            }
            if (colour.Length == 0)
            {
                //record the error 
                Error = Error + "The colour may not be blank : ";
            }
            //if the brand is greater than 50 characters
            if (colour.Length > 50)
            {
                //record the error
                Error = Error + "The colour must not be more than 50 characters : ";
            }
            try
            {
                SizeTemp = Convert.ToInt32(size);
                if (SizeTemp == 0)
                {
                    //record the error
                    Error = Error + "The size cannot be blank : ";
                }
                if (SizeTemp > 12)
                {
                    //record the error
                    Error = Error + "The size cannot be greater than 12 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The value entered is not a number : ";
            }
                       
            try
            {
                PriceTemp = Convert.ToDecimal(price);
                if (PriceTemp < 0.01M)
                {
                    //record the error
                    Error = Error + "The price cannot be a negative or 0 : ";
                }
                if (PriceTemp > 500.00M)
                {
                    Error = Error + "The price cannot be more than £500 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The value entered is not money : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date entered is not a valid date : ";
            }


            //return any error message
            return Error;
        }
        public string AllDetails
        {
            get
            {
                return Brand + " " + Name;

            }
        }
   
    }
}
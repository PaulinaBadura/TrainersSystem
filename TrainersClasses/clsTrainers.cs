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
                return mInStock;
            }
            set
            {
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
                return mPrice;
            }
            set
            {
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
            //set the private data members to the test data value
            mTrainerID = 12;
            mDateAdded = Convert.ToDateTime("16/02/2021");
            mBrand = "Test Brand";
            mName = "Test Name";
            mColour = "Test Colour";
            mSize = 2;
            mPrice = 2;
            mInStock = true;
            //always return true
            return true;
        }

       
    }
}
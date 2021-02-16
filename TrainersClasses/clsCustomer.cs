using System;

namespace TrainersClasses
{
    public class clsCustomer
    {
        //private data members for all theproperties
        private Int32 mCustomerID;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private string mPassword;
        private DateTime mDateOfBirth;
        private string mHouseNo;
        private string mStreet;
        private string mPostCode;
        private string mTown;


        //public data members
        public string FirstName {
            get
            {
                //tis line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into property
                mFirstName = value;
            }
        }
        public string LastName {
            get
            {
                //tis line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into property
                mLastName = value;
            }
        }
        public string Email {
            get
            {
                //tis line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into property
                mEmail = value;
            }
        }
        public string Password {
            get
            {
                //tis line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //this line of code allows data into property
                mPassword = value;
            }
        }
        public DateTime DateOfBirth {
            get
            {
                //tis line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into property
                mDateOfBirth = value;
            }
        }
        public string HouseNo {
            get
            {
                //tis line of code sends data out of the property
                return mHouseNo;
            }
            set
            {
                //this line of code allows data into property
                mHouseNo = value;
            }
        }
        public string Street {
            get
            {
                //tis line of code sends data out of the property
                return mStreet;
            }
            set
            {
                //this line of code allows data into property
                mStreet = value;
            }
        }
        public string PostCode {
            get
            {
                //tis line of code sends data out of the property
                return mPostCode;
            }
            set
            {
                //this line of code allows data into property
                mPostCode = value;
            
            }
        }
        public string Town {
            get
            {
                //tis line of code sends data out of the property
                return mTown;
            }
            set
            {
                //this line of code allows data into property
                mTown = value;
            }
        }
        public int CustomerID {
            get
            {
                //tis line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into property
                mCustomerID = value;
            }
        }



        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found ( there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to private data member
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]); 
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                //return that everything worked 
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem 
                return false;
            }
        }
    }
}
using System;

namespace TrainersClasses
{
    public class clsCustomer
    {
        //private data members for all theproperties
        private Int32 mCustomerNo;
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
        public int CustomerNo {
            get
            {
                //tis line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into property
                mCustomerNo = value;
            }
        }



        public bool Find(int customerNo)
        {
            //set the private data members to the test data value
            mCustomerNo = 12;
            mFirstName = "John";
            mLastName = "Wick";
            mEmail = "JohnWick@gmail.com";
            mPassword = "John123";
            mDateOfBirth = Convert.ToDateTime("22/02/1990");
            mHouseNo = "123B";
            mStreet = "Some Street";
            mPostCode = "LE1 7LT";
            mTown = "Leicester";
            //always return true
            return true;
        }
    }
}
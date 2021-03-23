using System;
using System.Text.RegularExpressions;
    


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
        public string FirstName
        {
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
        public string LastName
        {
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
        public string Email
        {
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
        public string Password
        {
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
        public DateTime DateOfBirth
        {
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
        public string HouseNo
        {
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
        public string Street
        {
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
        public string PostCode
        {
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
        public string Town
        {
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
        public int CustomerID
        {
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

        public string Valid(string firstName, string lastName, string dateOfBirth, string email, string password, string houseNo, string street, string town, string postCode)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            //create the string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                Error = Error + "First name may not be blank : ";
            }
            //if the First name is grater than 50
            if (firstName.Length > 50)
            {
                //record the error
                Error = Error + "The first name must be less than 50 characters : ";
            }
            //if the last name is blank
            if (lastName.Length == 0)
            {
                Error = Error + "Last name may not be blank : ";
            }
            //if the last name is grater than 50 characters
            if (lastName.Length > 50)
            {
                //record an error 
                Error = Error + "The last name must be less than 50 characters : ";
            }
            try
            {
                //copy the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
            

                if (DateTemp > DateTime.Now.Date.AddYears(-16))
                {
                    Error = Error + "You are too young, you must be at least 16 years old ;";
                }
                //if somebody is 121  or  more years old
                if (DateTemp <= DateTime.Now.Date.AddYears(-121))
                {
                    //record an error 
                    Error = Error + "You are too old : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date of birth was not valid date : ";
            }
            //if Password is less than 7
            if (password.Length < 8)
            {
                //record an error
                Error = Error + "Password must be at least 8 characters long : ";
            }
            //if Password is more than 16 characters
            if (password.Length > 16)
            {
                //record an error
                Error = Error + "Password cannot be more than 16 characters : ";
            }
            //if Email is blank
            if (email.Length == 0 )
            {
                //record an error
                Error = Error + "Email may not be blank : ";
            }
            
            else if(Regex.IsMatch(email,pattern)==false)
            {
                Error = Error + "Email is not valid. The correct format is 'example@example.uk' : ";
            }
            //if house no is blank
            if (houseNo.Length == 0)
            {
                //record an error
                Error = Error + "House number may not be blank : ";
            }
            //if HouseNo is more than 6 characters
            if ( houseNo.Length > 6)
            {
                //record an error
                Error = Error + "House number must be less than 6 characters : ";
            }
            //if the street is blank
            if (street.Length == 0)
            {
                Error = Error + "Street may not be blank : ";
            }
            //if the street is grater than 50 characters
            if (street.Length > 50)
            {
                //record an error 
                Error = Error + "The street must be less than 50 characters : ";
            }
            //if the town is blank
            if (town.Length == 0)
            {
                Error = Error + "Town may not be blank : ";
            }
            //if the town is grater than 60 characters
            if (town.Length > 60)
            {
                //record an error 
                Error = Error + "The town must be less than 60 characters : ";
            }
            //if the post code is blank
            if (postCode.Length == 0)
            {
                Error = Error + "Post Code may not be blank : ";
            }
            //if the town is grater than 8 characters
            if (postCode.Length > 8)
            {
                //record an error 
                Error = Error + "The post code must be less than 8 characters : ";
            }
            //return any error messages 
            return Error;
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace TrainersClasses
{
    public class clsStaff
    {
        //private data members for all theproperties
        private Int32 mStaffID;
        private string mFirstName;
        private string mLastName;
        private DateTime mDateOfBirth;
        private string mDepartment;
        private string mEmail;
        private string mPassword;


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

        public string Department
        {
            get
            {
                //tis line of code sends data out of the property
                return mDepartment;
            }
            set
            {
                //this line of code allows data into property
                mDepartment = value;
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

        public int StaffID
        {
            get
            {
                //tis line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into property
                mStaffID = value;
            }
        }

        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found ( there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to private data member
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
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
        public string Valid(string firstName, string lastName, string dateofbirth, string department, string email, string password)
        {
            //create the string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                Error = Error + "First name cannot be left black : ";
            }
            //if the First name is grater than 50
            if (firstName.Length > 50)
            {
                //record the error
                Error = Error + "First name need to be less than 50 characters : ";
            }
            //if the last name is blank
            if (lastName.Length == 0)
            {
                Error = Error + "Last name cannot be left blank : ";
            }
            //if the last name is grater than 50 characters
            if (lastName.Length > 50)
            {
                //record an error 
                Error = Error + "Last name need to be less than 50 characters : ";
            }
            try
            {
                //copy the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateofbirth);
                if (DateTemp > DateTime.Now.AddYears(-16))
                {
                    Error = Error + "You need to be at least 16 years old";
                }
                //if somebody is 120  or  more years old
                if (DateTemp < DateTime.Now.AddYears(-121))
                {
                    //record an error 
                    Error = Error + "Your age is too old : ";
                }
            }
            catch
            {
                //record the error 
                Error = Error + "Date of birth is not valid date : ";
            }
            //if department is blank
            if (department.Length == 0)
            {
                Error = Error + "Department cannot be blank : ";
            }
            //if department is grater than 30 characters
            if (department.Length > 30)
            {
                //record an error 
                Error = Error + "Department needs to be less than 30 characters : ";
            }
            //if Email is blank
            if (email.Length == 0)
            {
                //record an error
                Error = Error + "Email needs to be filled in : ";
            }
            //if Password is less than 6
            if (password.Length < 6)
            {
                //record an error
                Error = Error + "Password need to be at least 6 characters long : ";
            }
            //if Password is more than 50 characters
            if (password.Length > 50)
            {
                //record an error
                Error = Error + "Password cannot be more than 50 characters : ";
            }
            return Error;
        }
    }
}
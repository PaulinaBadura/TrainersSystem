using System;

namespace TrainersClasses
{
    public class clsAddress
    {
        private Int32 mChangeNo;
        private string mEmail;
        private string mHouseNo;
        private string mStreet;
        private string mPostCode;
        private string mTown;


        public Int32 ChangeNo
        {
            get
            {
                //tis line of code sends data out of the property
                return mChangeNo;
            }
            set
            {
                //this line of code allows data into property
                mChangeNo = value;
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

        public string Valid(string email, string houseNo, string street, string town, string postCode)
        {
            //create the string variable to store the error
            String Error = "";
           
            
            //if Email is blank
            if (email.Length == 0)
            {
                //record an error
                Error = Error + "Email may not be blank. ";
            }
            //if house no is blank
            if (houseNo.Length == 0)
            {
                //record an error
                Error = Error + "House number may not be blank. ";
            }
            //if HouseNo is more than 6 characters
            if (houseNo.Length > 6)
            {
                //record an error
                Error = Error + "House number must be less than 6 characters. ";
            }
            //if the street is blank
            if (street.Length == 0)
            {
                Error = Error + "Street may not be blank. ";
            }
            //if the street is grater than 50 characters
            if (street.Length > 50)
            {
                //record an error 
                Error = Error + "The street must be less than 50 characters. ";
            }
            //if the town is blank
            if (town.Length == 0)
            {
                Error = Error + "Town may not be blank. ";
            }
            //if the town is grater than 60 characters
            if (town.Length > 60)
            {
                //record an error 
                Error = Error + "The town must be less than 60 characters. ";
            }
            //if the post code is blank
            if (postCode.Length == 0)
            {
                Error = Error + "Post Code may not be blank. ";
            }
            //if the town is grater than 8 characters
            if (postCode.Length > 8)
            {
                //record an error 
                Error = Error + "The post code must be less than 8 characters. ";
            }
            //return any error messages 
            return Error;
        }


       

        //find function
        public bool Find(int ChangeNo)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter to search for
            DB.AddParameter("@ChangeNo", ChangeNo);
            //execute the stored procedure
            DB.Execute("sproc_tblDifferentAddress_FilterByChangeNo");
            //if one record is found 
            if (DB.Count == 1)
            //copy the data from database to the private data members
            {
                mChangeNo = Convert.ToInt32(DB.DataTable.Rows[0]["ChangeNo"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);

                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false if there's a problem
                return false;

            }
        }//end of find function
    }
}
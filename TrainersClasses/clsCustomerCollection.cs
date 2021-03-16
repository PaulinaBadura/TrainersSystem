using System.Collections.Generic;
using System;

namespace TrainersClasses
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a customer
                clsCustomer ACustomer = new clsCustomer();
                //read the fields from the current record
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                ACustomer.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                ACustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                //add the record to the private data member
                mCustomersList.Add(ACustomer);
                //point at the next record
                Index++;
            }


          
            
        }
       


        //private data member for the list
        List<clsCustomer> mCustomersList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        
        //public property for the customers list
        public List<clsCustomer> CustomersList
        {
            get
            {
                //return the private data member
                return mCustomersList;
            }
            set
            {
                //set thte private data
                mCustomersList = value;
            }
        }

        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomersList.Count;
            }
            set
            {
                //later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;

            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //clsDataConnection to datbase
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            //execute the query returnin the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
           
        }
    }
}
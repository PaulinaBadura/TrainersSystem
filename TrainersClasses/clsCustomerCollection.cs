using System.Collections.Generic;
using System;

namespace TrainersClasses
{
    public class clsCustomerCollection
    {
        //constructor for the class
        public clsCustomerCollection()
        {
            
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);
 
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

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer

            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on full or partial post code
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored proc
            DB.Execute("sproc_tblCustomer_FilterByPostCode");
            //populate the array list with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the arrey list based on the data table in the parameter DB
            //var fo the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomersList = new List<clsCustomer>();
            //while there are records to process
            while ( Index < RecordCount)
            {
                //create a customer
                clsCustomer ACustomer = new clsCustomer();
                //read the fields from the current record

                //ACustomer.CustomerID= Convert.ToInt32(DB.DataTable.Rows[Index]["CutomerID"]);
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
    }
}
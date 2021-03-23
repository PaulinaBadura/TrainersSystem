using System;
using System.Collections.Generic;

namespace TrainersClasses
{
    public class clsAddressCollection
    {

        //private data member for the list
        List<clsAddress> mAddressList = new List<clsAddress>();
        //private data member thisCustomer
        clsAddress mThisAddress = new clsAddress();

        //public property for the customers list
        public List<clsAddress> AddressList
        {
            get
            {
                //return the private data member
                return mAddressList;
            }
            set
            {
                //set thte private data
                mAddressList = value;
            }
        }

        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAddressList.Count;
            }
            set
            {
                //later
            }
        }

        public clsAddress ThisAddress
        {
            get
            {
                //return the private data
                return mThisAddress;
            }
            set
            {
                //set the private data
                mThisAddress = value;

            }
        }



        public clsAddressCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDifferentAddress_selectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank order
                clsAddress AnAddress = new clsAddress();
                //read the fields from the current record
                AnAddress.ChangeNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ChangeNo"]);
                AnAddress.HouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                AnAddress.Street = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                AnAddress.Town = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                AnAddress.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                AnAddress.PostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                //add the record to the private data member
                mAddressList.Add(AnAddress);
                //point at the next record
                Index++;
            }
        }

        public int AddAddress()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //clsDataConnection to datbase
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@Email", mThisAddress.Email);
            DB.AddParameter("@HouseNo", mThisAddress.HouseNo);
            DB.AddParameter("@Street", mThisAddress.Street);
            DB.AddParameter("@Town", mThisAddress.Town);
            DB.AddParameter("@PostCode", mThisAddress.PostCode);
            //execute the query returnin the primary key value
            return DB.Execute("sproc_tblDifferentAddress_Insert");

        }
    }
}
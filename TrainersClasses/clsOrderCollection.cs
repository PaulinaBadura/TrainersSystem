using System;
using System.Collections.Generic;

namespace TrainersClasses
{
    public class clsOrderCollection
    {
        //private data members for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        //these lines of cone contain the constructor of the class
        /////////////////////////////////////////
        /////////////////////////////////////////
        ////////////////////////////////////////

        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with data table
            Populate(DB);
        }
        /// <summary>
        /// THE CONSTRUCTOR ENDS HERE
        /// </summary>
        /// <returns></returns>

        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;

            }

            set
            {
                //set the private data
                mOrderList = value;

            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mOrderList.Count;
            }

            set
            {
                //we will do this later
            }
        }



        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }

        }



        

        
        //function for adding new order
        public int Add()
        {
            //adds a new record to the database based on the value value of mThisOrder
            //set the primary key value of the record
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@OrderValue", mThisOrder.OrderValue);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@EmailAddress", mThisOrder.EmailAddress);
            DB.AddParameter("@DeliveryTown", mThisOrder.DeliveryTown);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        //function for updating a record
        public void Update()
        {
            //update an existing record based on the values of thisOrder

            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@OrderValue", mThisOrder.OrderValue);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@EmailAddress", mThisOrder.EmailAddress);
            DB.AddParameter("@DeliveryTown", mThisOrder.DeliveryTown);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        //function for deleting a record
        public void Delete()
        {
            //deletes record based on the value value of mThisOrder
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerID(int CustomerID)
        {
            //filters the records based on full or partial post code
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored proc
            DB.Execute("sproc_tblOrder_FilterByCustomerID");
            //populate the array list with data table
            Populate(DB);
        }

        public void ReportByOrderStatus(string OrderStatus)
        {
            //filters the records based on full or partial post code
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@OrderStatus", OrderStatus);
            //execute the stored proc
            DB.Execute("sproc_tblOrder_FilterByOrderStatus");
            //populate the array list with data table
            Populate(DB);
        }


        void Populate(clsDataConnection DB)

        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                //create blank order
                clsOrder AnOrder = new clsOrder();
                //read the fields from the current record
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                AnOrder.OrderValue = Convert.ToInt32(DB.DataTable.Rows[0]["OrderValue"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                AnOrder.EmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                AnOrder.DeliveryTown = Convert.ToString(DB.DataTable.Rows[0]["DeliveryTown"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

    }//end of clsOrderCollection
}//end of namespace
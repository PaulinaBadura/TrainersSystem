using System;
using System.Collections.Generic;

namespace TrainersClasses
{
    public class clsOrderCollection
    {
        //private data members for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

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


        //these lines of cone contain the constructor of the class
        /////////////////////////////////////////
        /////////////////////////////////////////
        ////////////////////////////////////////

        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_selectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank order
                clsOrder AnOrder = new clsOrder();
                //read the fields from the current record
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

        public int Add()
        {
            //adds a new record to the database based on the value value of mThisOrder
            //set the primary key value of the record
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@OrderValue", mThisOrder.OrderValue);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@EmailAddress", mThisOrder.EmailAddress);
            DB.AddParameter("@DeliveryTown", mThisOrder.DeliveryTown);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }
    }//end of clsOrderCollection
}//end of namespace
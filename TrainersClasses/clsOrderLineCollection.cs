using System;
using System.Collections.Generic;

namespace TrainersClasses
{
    public class clsOrderLineCollection
    {
        //private data members for the list
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();

        public List<clsOrderLine> OrderLineList
        {
            get
            {
                //return the private data
                return mOrderLineList;

            }

            set
            {
                //set the private data
                mOrderLineList = value;

            }
        }

        public clsOrderLine ThisOrderLine
        {
            get
            {
                //return the private data
                return mThisOrderLine;
            }
            set
            {
                //set the private data
                mThisOrderLine = value;
            }

        }

        public int Count
        {
            get
            {
                //return the private data
                return mOrderLineList.Count;
            }

            set
            {
                //we will do this later
            }
        }

        //constructor
        public clsOrderLineCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_selectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank order
                clsOrderLine AnOrder = new clsOrderLine();
                //read the fields from the current record
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                AnOrder.TrainerID = Convert.ToInt32(DB.DataTable.Rows[Index]["TrainerID"]);
                AnOrder.OrderQty = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mOrderLineList.Add(AnOrder);
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
            DB.AddParameter("@OrderNo", mThisOrderLine.OrderNo);
            DB.AddParameter("@TrainerID", mThisOrderLine.TrainerID);
            DB.AddParameter("@Quantity", mThisOrderLine.OrderQty);
            DB.AddParameter("@Price", mThisOrderLine.Price);
           
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrderLine_Insert");
        }
    }
}
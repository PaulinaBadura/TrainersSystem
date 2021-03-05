using System;
using System.Collections.Generic;

namespace TrainersClasses
{
    public class clsOrderCollection
    {
        //private data members for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
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



        public clsOrder ThisOrder { get; set; }


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
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                AnOrder.DeliveryTown = Convert.ToString(DB.DataTable.Rows[0]["DeliveryTown"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }//end of clsOrderCollection
}//end of namespace
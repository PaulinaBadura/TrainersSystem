using System;

namespace TrainersClasses
{
    public class clsOrderLine
    {
        private Int32 mOrderLineID;
        private Int32 mOrderNo;
        private Int32 mOrderQty;
        private Int32 mTrainerID;
        private Int32 mPrice;

        public Int32 OrderLineID
        {
            get
            {
                //this line sends data out of the property
                return mOrderLineID;
            }

            set
            {
                //this line allows data into property
                mOrderLineID = value;
            }
        }

        //Order number
        public Int32 OrderNo
        {
            get
            {
                //this line sends data out of the property
                return mOrderNo;
            }

            set
            {
                //this line allows data into property
                mOrderNo = value;
            }
        }

        public Int32 OrderQty
        {
            get
            {
                //this line sends data out of the property
                return mOrderQty;
            }

            set
            {
                //this line allows data into property
                mOrderQty = value;
            }
        }
        public Int32 TrainerID
        {
            get
            {
                //this line sends data out of the property
                return mTrainerID;
            }

            set
            {
                //this line allows data into property
                mTrainerID = value;
            }
        }

        public Int32 Price
        {
            get
            {
                //this line sends data out of the property
                return mPrice;
            }

            set
            {
                //this line allows data into property
                mPrice = value;
            }
        }

        public string Valid(string trainerID, string orderNo, string quantity, string price)
        {
            String Error = "";
            //temporary variable to store data values
           
            Int32 ValueTemp;
            Decimal PriceTemp;

            try
            {
                ValueTemp = Convert.ToInt32(trainerID);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "Trainer ID cannot be 0!  ";
                }

                //if the value is too big
                if (ValueTemp > 50000)
                {
                    Error = Error + "Trainer ID is too big! ";
                }
            }

            catch
            {
                Error = Error + "Trainer ID  must be a number!  ";
            }

            try
            {
                ValueTemp = Convert.ToInt32(orderNo);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "Order number cannot be 0!  ";
                }

                //if the value is too big
                if (ValueTemp > 500000000)
                {
                    Error = Error + "Order number is too big!   ";
                }
            }

            catch
            {
                Error = Error + "Order number  must be a number!  ";
            }

            try
            {
                ValueTemp = Convert.ToInt32(quantity);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "Quantity cannot be 0!  ";
                }

                //if the value is too big
                if (ValueTemp > 50000)
                {
                    Error = Error + "Quantity is too big! If you wish to order more, please make another order.  ";
                }
            }

            catch
            {
                Error = Error + "Quantity  must be a number!  ";
            }


            ValueTemp = Convert.ToInt32(price);
            //if the value is 0
            if (ValueTemp == 0)
                {
                    Error = Error + "Price cannot be 0!  ";
                }

                //if the value is too big
                if (ValueTemp > 50000)
                {
                    Error = Error + "Price is too big! If you wish to order more, please make another order.  ";
                }
            

            

            //return any error message
            return Error;
        }

        //find function
        public bool Find(int OrderLineID)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter to search for
            DB.AddParameter("@OrderLineID", OrderLineID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            //if one record is found 
            if (DB.Count == 1)
            //copy the data from database to the private data members
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mTrainerID = Convert.ToInt32(DB.DataTable.Rows[0]["TrainerID"]);
                mOrderQty = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);

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
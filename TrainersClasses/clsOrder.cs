using System;

namespace TrainersClasses
{
    public class clsOrder
    {
        //private data memeber for the order property
        private Int32 mOrderNo;
        private DateTime mDateAdded;
        private string mEmailAddress;
        private string mDeliveryTown;
        private string mOrderStatus;
        private Int32 mOrderValue;

        private Int32 mCustomerID;

        public int CustomerID
        {
            get
            {
                //tis line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into property
                mCustomerID = value;
            }
        }

        //Date added
        public DateTime DateAdded
        {
            get
            {
                //this line sends data out of the property
                return mDateAdded;
            }

            set
            {
                //this line allows data into property
                mDateAdded = value;
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

        //Customer ID
        public string EmailAddress
        {
            get
            {
                //this line sends data out of the property
                return mEmailAddress;
            }

            set
            {
                //this line allows data into property
                mEmailAddress = value;
            }
        }


        //Delivery town
        public string DeliveryTown
        {
            get
            {
                //this line sends data out of the property
                return mDeliveryTown;
            }

            set
            {
                //this line allows data into property
                mDeliveryTown = value;
            }
        }

        //Order status
        public string OrderStatus
        {
            get
            {
                //this line sends data out of the property
                return mOrderStatus;
            }

            set
            {
                //this line allows data into property
                mOrderStatus = value;
            }
        }

        //Order value
        public Int32 OrderValue
        {
            get
            {
                //this line sends data out of the property
                return mOrderValue;
            }

            set
            {
                //this line allows data into property
                mOrderValue = value;
            }
        }


        //find function
        public bool Find(int OrderNo)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found 
            if (DB.Count == 1)
            //copy the data from database to the private data members
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mOrderValue = Convert.ToInt32(DB.DataTable.Rows[0]["OrderValue"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mDeliveryTown = Convert.ToString(DB.DataTable.Rows[0]["DeliveryTown"]);

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




        //fuction for the public validation method
        public string Valid(string emailaddress, string deliveryTown, string dateAdded, string orderStatus, string orderValue, string customerID)
        {
            //this function accepts 5 parameters for validation
            //it returns string containing error message
            //if no erorr is found, it return blank string

            //string variable to store error
            String Error = "";
            //temporary variable to store data values
            DateTime DateTemp;
            Int32 ValueTemp;

            try
            {
                ValueTemp = Convert.ToInt32(customerID);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "Customer ID value cannot be 0!  ";
                }


            }

            catch
            {
                Error = Error + "Customer ID value must be a number!  ";
            }

           
        

            try
            {
                //copy the date added value to the temporary variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past.  ";
                }

                //copy the date added value to the temporary variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future.  ";
                }
            }

            catch
            {
                Error = Error + "The date was not a valid data type.  ";
            }

            
                //if the delivery town is blank
               if (deliveryTown.Length == 0)
                {
                    Error = Error + "The delivery town may not be blank!  ";
                }

                //if the delivery town is too long
               if (deliveryTown.Length > 50)
                {
                    Error = Error + "The delivery town must be less than 50 characters!  ";
                }


            //if the order status is blank
            if (emailaddress.Length == 0)
            {
                Error = Error + "The email address may not be blank!  ";
            }

            //if the order statys is too long
            if (emailaddress.Length > 50)
            {
                Error = Error + "The email address must be less than 50 characters!  ";
            }

            

            try
            {
                ValueTemp = Convert.ToInt32(orderValue);
                //if the value is 0
                if (ValueTemp == 0)
                {
                    Error = Error + "The order value cannot be 0!  ";
                }

                //if the value is too big
                if (ValueTemp > 50000)
                {
                    Error = Error + "The order value is too big! If you wish to order more, please make another order.  ";
                }
            }

            catch
            {
                Error = Error + "The order value must be a number!  ";
            }


            //if the order status is blank
            if (orderStatus.Length == 0)
            {
                Error = Error + "The order status may not be blank!  ";
            }

            //if the order statys is too long
            if (orderStatus.Length > 10)
            {
                Error = Error + "The order status must be less than 10 characters!  ";
            }

            //return any error message
            return Error;

        }//end of function for validation


        
    }
}
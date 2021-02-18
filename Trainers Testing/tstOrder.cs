using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstOrder
    {
        //some test data to pass the method
        string CustomerID = "12";
        string DeliveryTown = "Leicester";
        string OrderValue = "13";
        string DateAdded = DateTime.Now.Date.ToString();
        string OrderStatus = "shipped";


        

        //these lines of code are all for FOUND with all attributes
        //it starts here
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        
        //test method for find function
        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method
            Found = AnOrder.Find(OrderNo);

            //check the orderNo
            if (AnOrder.OrderNo != 2)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        //test for date added
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method
            Found = AnOrder.Find(OrderNo);

            //check the property
            if (AnOrder.DateAdded != Convert.ToDateTime("16/02/2021"))
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);


        }

        //test for customer ID
        [TestMethod]
        public void CustomerIDFound()
        {
            //create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method
            Found = AnOrder.Find(OrderNo);

            //check the property
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        //test for delivery town
        [TestMethod]
        public void DeliveryTownFound()
        {
            //create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method
            Found = AnOrder.Find(OrderNo);

            //check the property
            if (AnOrder.DeliveryTown != "Test Town")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        //test for order status
        [TestMethod]
        public void OrderStatusFound()
        {
            //create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method
            Found = AnOrder.Find(OrderNo);

            //check the property
            if (AnOrder.OrderStatus != "Test Status")
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        //test for order value
        [TestMethod]
        public void OrderValueFound()
        {
            //create instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean vvariable to store the results of validation
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //some test data to use with the method
            Int32 OrderNo = 2;
            //invoke the method
            Found = AnOrder.Find(OrderNo);

            //check the property
            if (AnOrder.OrderValue != 1)
            {
                OK = false;
            }

            //test to see if the result is true
            Assert.IsTrue(OK);

        }

        //next lines of code contain tests for validation
        //starting here
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////


        [TestMethod]
        public void ValidMehodOK()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        //valid date added for extreme min
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //variable to store the test date data
            DateTime TestDate;
            //set date toda's date
            TestDate = DateTime.Now.Date;
            //change the date to less than 100 years
            TestDate = TestDate.AddYears(-100);
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //date added minumim less one
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //variable to store the test date data
            DateTime TestDate;
            //set date toda's date
            TestDate = DateTime.Now.Date;
            //change the date to less than 100 years
            TestDate = TestDate.AddDays(-1);
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //date added test for minimum value (today's date)
        [TestMethod]
        public void DateAddedMin()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //variable to store the test date data
            DateTime TestDate;
            //set date toda's date
            TestDate = DateTime.Now.Date;
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        //test method for date added today's date plus one
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //variable to store the test date data
            DateTime TestDate;
            //set date toda's date
            TestDate = DateTime.Now.Date;
            //change the date to less than 1 day
            TestDate = TestDate.AddDays(1);
            //convert to string variable
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //test method for date added exteme maximum
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //variable to store the test date data
            DateTime TestDate;
            //set date toda's date
            TestDate = DateTime.Now.Date;
            //change the date to more than 100 years
            TestDate = TestDate.AddYears(100);
            String DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //test date added for invalid data type
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //set the date added to non date value
            String DateAdded = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //test method for delivery town minumum less one
        [TestMethod]
        public void DeliveryTownMinLessOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //blank string should fail
            string DeliveryTown = "";
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for delivery town minumum value
        [TestMethod]
        public void DeliveryTownMin()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //one character should pass
            string DeliveryTown = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for delivery town minumum value plus one
        [TestMethod]
        public void DeliveryTownMinPlusOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //2 characters should pass
            string DeliveryTown = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for delivery town maximum value minus one
        [TestMethod]
        public void DeliveryTownMaxLessOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should pass
            string DeliveryTown = "";
            DeliveryTown = DeliveryTown.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for delivery town maximum value
        [TestMethod]
        public void DeliveryTownMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should pass
            string DeliveryTown = "";
            DeliveryTown = DeliveryTown.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for delivery town maximum value plus one
        [TestMethod]
        public void DeliveryTownMaxPlusOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //blank string should fail
            string DeliveryTown = "";
            DeliveryTown = DeliveryTown.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for delivery town extreme maximum value
        [TestMethod]
        public void DeliveryTownExtremeMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should fail
            string DeliveryTown = "";
            DeliveryTown = DeliveryTown.PadRight(50000, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for delivery town middle value
        [TestMethod]
        public void DeliveryTownMid()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should pass
            string DeliveryTown = "";
            DeliveryTown = DeliveryTown.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for customer ID minumum less one
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //it cannot be 0
            Int32 TestID;
            TestID = 0;
            String CustomerID = TestID.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for customer ID minumum
        [TestMethod]
        public void CustomerIDMin()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //1 should pass
            Int32 TestID;
            TestID = 1;
            String CustomerID = TestID.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for customerID middle value
        [TestMethod]
        public void CustomerIDMid()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //middle value should pass
            Int32 TestID;
            TestID = 50000;
            String CustomerID = TestID.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for customer ID minumum plus one
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //2 should pass
            Int32 TestID;
            TestID = 2;
            String CustomerID = TestID.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for customer ID maximum
        [TestMethod]
        public void CustomerIDMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //100000 should pass
            Int32 TestID;
            TestID = 100000;
            String CustomerID = TestID.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //test method for customer ID maximum plus one
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //100001 should fail
            Int32 TestID;
            TestID = 100001;
            String CustomerID = TestID.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for customer ID extreme maximum
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should fail
            Int32 TestID;
            TestID = 1000000000;
            String CustomerID = TestID.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for customer invalid data type
        [TestMethod]
        public void CustomerIDInvalidData()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //set the date added to non date value
            String CustomerID = "This is not a number!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //test method for order value data type
        [TestMethod]
        public void OrderValueInvalidData()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //set the date added to non date value
            String OrderValue = "This is not a number!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        //test method for minimum order value
        [TestMethod]
        public void OrderValueMin()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //1 should pass
            Int32 TestValue;
            TestValue = 1;
            String OrderValue = TestValue.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for minimum order value
        [TestMethod]
        public void OrderValueMinLessOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //0 should fail
            Int32 TestValue;
            TestValue = 0;
            String OrderValue = TestValue.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for middle order value
        [TestMethod]
        public void OrderValueMid()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should pass
            Int32 TestValue;
            TestValue = 25000;
            String OrderValue = TestValue.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for maximum order value
        [TestMethod]
        public void OrderValueMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should pass
            Int32 TestValue;
            TestValue = 50000;
            String OrderValue = TestValue.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for maximum order value plus one
        [TestMethod]
        public void OrderValueMaxPlusOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should fail
            Int32 TestValue;
            TestValue = 50001;
            String OrderValue = TestValue.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for extreme maximum order value
        [TestMethod]
        public void OrderValueExtremeMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should fail
            Int32 TestValue;
            TestValue = 5000000;
            String OrderValue = TestValue.ToString();
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for order status minimum value
        [TestMethod]
        public void OrderStatusMin()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should pass
            string OrderStatus = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for order status minimum less one
        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //blank string should fail
            string OrderStatus = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //since we will decide only between canceled, completed, failed, on hold, processing, refunded, shipped, delivered 
        //the maxim number of characters can be 10, since there is no option with more than 10 characters 
        //test method for order status maximum value
        [TestMethod]
        public void OrderStatusMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should pass
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(10, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method for order status maximum value plus one
        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should fail
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(11, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for order status extreme maximum
        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should fail
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(1000, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //test method for order status middle value
        [TestMethod]
        public void OrderStatusMid()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //this should pass
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(5, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderStatus, DateAdded, DeliveryTown, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        //next lines of code are tests for instances
        //it starts here
        /////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////

        //test method for instance of a class
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see if it exists
            Assert.IsNotNull(AnOrder);

        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void OrderNoOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void DeliveryTownOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnOrder.DeliveryTown = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryTown, TestData);
        }

        [TestMethod]
        public void OrderStatusOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Shipped";
            //assign the data to the property
            AnOrder.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void OrderValueOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 50;
            //assign the data to the property
            AnOrder.OrderValue = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderValue, TestData);
        }

    }
}

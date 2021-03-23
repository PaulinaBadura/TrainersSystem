using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstOrder
    {
        //some test data to pass the method
        string EmailAddress = "john@gmail.com";
        string DeliveryTown = "Leicester";
        string OrderValue = "13";
        string DateAdded = DateTime.Now.Date.ToString();
        string OrderStatus = "shipped";

        //test data to pass methods for an address
        string Email = "sofia@gmail.com";
        string HouseNo = "123b";
        string Street = "London Road";
        string Town = "Leicester";
        string PostCode = "LE2 102";




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
        public void EmailAddressFound()
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
            if (AnOrder.EmailAddress != "sofia@gmail.com")
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //test method to test empty email address
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create instance of the class
            clsOrder AnOrder = new clsOrder();
            //string to store error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            //invoke the method
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
            Error = AnOrder.Valid(EmailAddress, DeliveryTown, DateAdded, OrderStatus, OrderValue);
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
        public void EmailAddressOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "john@gmail.com";
            //assign the data to the property
            AnOrder.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.EmailAddress, TestData);
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


        ///THIS SECTION OF CODE CONTAINS TESTS FOR ADDRESS CLASS WHICH A CUSTOMER
        ///CAN USE WHEN ADDING A DIFFERENT ADDRESS TO PLACE AN ORDER

        //test method for instance of a class
        [TestMethod]
        public void InstanceAddressOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //test to see if it exists
            Assert.IsNotNull(AnAddress);

        }

        //test to see if houseno exists in clsaddress
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create som test data to assign to the property 
            string TestData = "123b";
            //assign the data to the property
            AnAddress.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.HouseNo, TestData);
        }

        //test to see if street exists in clsaddress
        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create som test data to assign to the property 
            string TestData = "London Road";
            //assign the data to the property
            AnAddress.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Street, TestData);
        }


        //test if postcode exists
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create som test data to assign to the property 
            string TestData = "LE2 102";
            //assign the data to the property
            AnAddress.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PostCode, TestData);
        }


        //test to see if town exists
        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create som test data to assign to the property 
            string TestData = "Leicester";
            //assign the data to the property
            AnAddress.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Town, TestData);
        }

        //test to see if email exists
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create som test data to assign to the property 
            string TestData = "sofia@gmail.com";
            //assign the data to the property
            AnAddress.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Email, TestData);
        }

        ///this part of code is for tests for validation for clsaddress
        ///it starts here
        ///

        [TestMethod]
        public void ValidAddressMehodOK()
        {
            //create instance of the class
            clsAddress AnAddress = new clsAddress();
            //string to store error message
            String Error = "";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; 
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void HouseNoMinLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";// should trigger an error 
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void HouseNoMin()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "a";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aa";// should pass
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaa";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaa";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaaa";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            //this should fail
            HouseNo = HouseNo.PadRight(500, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            //an empty string should fail
            string Street = "";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void StreetMin()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //this should pass
            Street = Street.PadRight(1, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //this should pass
            Street = Street.PadRight(2, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //this should pass
            Street = Street.PadRight(49, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMax()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //this should pass
            Street = Street.PadRight(50, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //this should pass
            Street = Street.PadRight(25, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //this should fail
            Street = Street.PadRight(51, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetExtremeMax()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //this should fail
            Street = Street.PadRight(500, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TwonMinLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //this should pass
            Town = Town.PadRight(1, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //this should pass
            Town = Town.PadRight(2, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //this should pass
            Town = Town.PadRight(59, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //this should pass
            Town = Town.PadRight(60, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //this should pass
            Town = Town.PadRight(30, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //this should fail
            Town = Town.PadRight(61, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownExtremeMax()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //this should fail
            Town = Town.PadRight(500, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PostCodedMinLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            //blank string should fail
            string PostCode = "";
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            //this should pass
            PostCode = PostCode.PadRight(1, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            //should pass
            PostCode = PostCode.PadRight(2, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            //should pass
            PostCode = PostCode.PadRight(7, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            //this should pass
            PostCode = PostCode.PadRight(8, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            //should pass
            PostCode = PostCode.PadRight(4, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            //should fail
            PostCode = PostCode.PadRight(9, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class
            clsAddress AnAddress = new clsAddress();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            //should fail
            PostCode = PostCode.PadRight(500, 'a');
            //invoke the method
            Error = AnAddress.Valid(Email, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstOrderCollection
    {
        //these lines of code are to test if the class and the properties exist
        //it starts here
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        //test method to see if order list exists
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data to assign to the property
            //data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 2;
            TestItem.DeliveryTown = "Test Town";
            TestItem.OrderStatus = "Test Status";
            TestItem.OrderValue = 1;
            TestItem.EmailAddress = "sofia@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }

        //test method for add
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 2;
            TestItem.OrderNo = 2;
            TestItem.DeliveryTown = "Test Town";
            TestItem.OrderStatus = "Test Status";
            TestItem.OrderValue = 1;
            TestItem.EmailAddress = "sofia@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key to the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            //test to see that two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        
        }



        // test method to see if ThisOrder property exists
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderNo = 2;
            TestOrder.EmailAddress = "sofia@gmail.com";
            TestOrder.OrderValue = 1;
            TestOrder.DeliveryTown = "Test Town";
            TestOrder.OrderStatus = "Test Status";
            TestOrder.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are equal
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

        }

        //test method to see if list and count property exist
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create test data to assign to the property
            //data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 2;
            TestItem.DeliveryTown = "Test Town";
            TestItem.OrderStatus = "Test Status";
            TestItem.OrderValue = 1;
            TestItem.EmailAddress = "sofia@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

        ///THIS PART OF CODE CONTAINS TEST FOR ADDRESS COLLECTION
        ///WHEN A CUSTOMER WANTS TO ADD NEW ADDRESS FOR DELIVERY
        ///IT STARTS HERE
        ///

        [TestMethod]
        public void InstanceAddressOk()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAddresses);
        }

        //test method to see if order list exists
        [TestMethod]
        public void AddressListOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //create test data to assign to the property
            //data needs to be a list of objects
            List<clsAddress> TestList = new List<clsAddress>();
            //add item to the list
            //create the item of test data
            clsAddress TestItem = new clsAddress();
            //set its properties
            TestItem.ChangeNo = 2;
            TestItem.HouseNo = "123b";
            TestItem.Street = "London Road";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "Le2 102";
            TestItem.Email = "sofia@gmail.com";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAddresses.AddressList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.AddressList, TestList);

        }

        //test method for add
        [TestMethod]
        public void AddMethodAddressOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //create the item of test data
            clsAddress TestItem = new clsAddress();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ChangeNo = 2;
            TestItem.HouseNo = "123b";
            TestItem.Street = "London Road";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "Le2 102";
            TestItem.Email = "sofia@gmail.com";
            //set ThisOrder to the test data
            AllAddresses.ThisAddress = TestItem;
            //add the record
            PrimaryKey = AllAddresses.AddAddress();
            //set the primary key to the test data
            TestItem.ChangeNo = PrimaryKey;
            //find the record
            AllAddresses.ThisAddress.Find(PrimaryKey);

            //test to see that two values are the same
            Assert.AreEqual(AllAddresses.ThisAddress, TestItem);

        }

        // test method to see if ThisOrder property exists
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //create the item of test data
            clsAddress TestAddress = new clsAddress();
            //set the properties of the test object
            TestAddress.ChangeNo = 2;
            TestAddress.HouseNo = "123b";
            TestAddress.Street = "London Road";
            TestAddress.Town = "Leicester";
            TestAddress.PostCode = "Le2 102";
            TestAddress.Email = "sofia@gmail.com";
            //assign the data to the property
            AllAddresses.ThisAddress = TestAddress;
            //test to see that the two values are equal
            Assert.AreEqual(AllAddresses.ThisAddress, TestAddress);

        }

        //test method to see if list and count property exist
        [TestMethod]
        public void ListAndCountAddressOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //create test data to assign to the property
            //data needs to be a list of objects
            List<clsAddress> TestList = new List<clsAddress>();
            //add item to the list
            //create the item of test data
            clsAddress TestItem = new clsAddress();
            //set its properties
            TestItem.ChangeNo = 2;
            TestItem.HouseNo = "123b";
            TestItem.Street = "London Road";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "Le2 102";
            TestItem.Email = "sofia@gmail.com";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAddresses.AddressList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.Count, TestList.Count);

        }
    }
}

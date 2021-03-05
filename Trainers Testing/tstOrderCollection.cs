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
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

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
            TestOrder.CustomerID = 1;
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
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }


    }
}

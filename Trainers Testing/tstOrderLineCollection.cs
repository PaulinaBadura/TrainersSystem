using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        //test method to see if order list exists
        [TestMethod]
        public void OrderLineListOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            //create test data to assign to the property
            //data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add item to the list
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.OrderLineID = 2;
            TestItem.OrderNo = 2;
            TestItem.TrainerID= 2;
            TestItem.OrderLineID = 2;
            TestItem.OrderQty = 1;
            TestItem.Price = 2;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderLineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderLineList, TestList);

        }

        //test method for add
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderLineID = 2;
            TestItem.OrderNo = 2;
            TestItem.TrainerID = 2;
            TestItem.OrderLineID = 2;
            TestItem.OrderQty = 1;
            TestItem.Price = 2;
            //set ThisOrder to the test data
            AllOrders.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key to the test data
            TestItem.OrderNo = PrimaryKey;
            //find the record
            AllOrders.ThisOrderLine.Find(PrimaryKey);

            //test to see that two values are the same
            Assert.AreEqual(AllOrders.ThisOrderLine, TestItem);

        }



        // test method to see if ThisOrder property exists
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            //create some data to assign to the property
            clsOrderLine TestOrder = new clsOrderLine();
            //set the properties of the test object
            TestOrder.OrderLineID = 2;
            TestOrder.OrderNo = 2;
            TestOrder.TrainerID = 2;
            TestOrder.OrderLineID = 2;
            TestOrder.OrderQty = 1;
            TestOrder.Price = 2;

            //assign the data to the property
            AllOrders.ThisOrderLine = TestOrder;
            //test to see that the two values are equal
            Assert.AreEqual(AllOrders.ThisOrderLine, TestOrder);

        }

        //test method to see if list and count property exist
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            //create test data to assign to the property
            //data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.OrderLineID = 2;
            TestItem.OrderNo = 2;
            TestItem.TrainerID = 2;
            TestItem.OrderLineID = 2;
            TestItem.OrderQty = 1;
            TestItem.Price = 2;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderLineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }
    }
}

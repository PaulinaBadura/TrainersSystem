using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstOrderLine
    {

        //test data to pass methods for an address
        string TrainerID = "123";
        string OrderNo = "123";
        string Quantity = "1";
        string Price = "1";
        

        //order number, order quantity, trainer ID
        //test method for instance of a class
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrder = new clsOrderLine();
            //test to see if it exists
            Assert.IsNotNull(AnOrder);

        }

        [TestMethod]
        public void OrderNoOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrder = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        //test method for order quantity
        [TestMethod]
        public void OrderQtyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrder = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderQty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderQty, TestData);
        }

        [TestMethod]
        public void TrainerIDOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrder = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.TrainerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TrainerID, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrder = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);
        }

        //test method for delivery town minumum less one
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create instance of the class
            clsOrderLine AnOrder = new clsOrderLine();
            //string to store error message
            String Error = "";
            //0 should fail
            Int32 TestValue;
            TestValue = 0;
            String Price = TestValue.ToString();
            Error = AnOrder.Valid(TrainerID, OrderNo, Quantity, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for delivery town minumum less one
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create instance of the class
            clsOrderLine AnOrder = new clsOrderLine();
            //string to store error message
            String Error = "";
            //0 should fail
            Int32 TestValue;
            TestValue = 0;
            String Quantity = TestValue.ToString();
            Error = AnOrder.Valid(TrainerID, OrderNo, Quantity, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for delivery town minumum less one
        [TestMethod]
        public void OrderNoMinLessOne()
        {
            //create instance of the class
            clsOrderLine AnOrder = new clsOrderLine();
            //string to store error message
            String Error = "";
            //0 should fail
            Int32 TestValue;
            TestValue = 0;
            String OrderNo = TestValue.ToString();
            Error = AnOrder.Valid(TrainerID, OrderNo, Quantity, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //test method for delivery town minumum less one
        [TestMethod]
        public void TrainerIDMinLessOne()
        {
            //create instance of the class
            clsOrderLine AnOrder = new clsOrderLine();
            //string to store error message
            String Error = "";
            //0 should fail
            Int32 TestValue;
            TestValue = 0;
            String TrainerID = TestValue.ToString();
            Error = AnOrder.Valid(TrainerID, OrderNo, Quantity, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

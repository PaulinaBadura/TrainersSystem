using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstOrderLine
    {
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

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstTrainers
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //test to see that it exists
            Assert.IsNotNull(ATrainer);
        }
        [TestMethod]
        public void InStockOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ATrainer.InStock = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, ATrainer.InStock);
        }
        [TestMethod]
        public void TrainerIDOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            // create test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            ATrainer.TrainerID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, ATrainer.TrainerID);
        }

        [TestMethod]
        public void BrandOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to assign to the property
            string TestData;
            TestData = "Nike";
            //assign data to the property
            ATrainer.Brand = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, ATrainer.Brand);
        }
        [TestMethod]
        public void NameOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to assign to the property
            string TestData;
            TestData = "Air Max";
            //assign data to the property
            ATrainer.Name = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, ATrainer.Name);
        }
        [TestMethod]
        public void ColourOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to assign to the property
            string TestData;
            TestData = "Black";
            //assign data to the property
            ATrainer.Colour = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, ATrainer.Colour);
        }
        
        [TestMethod]
        public void SizeOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to assign to the property
            Int32 TestData = 1;
            //assign data to the property
            ATrainer.Size = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, ATrainer.Size);
        }
        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to assign to the property
            Decimal TestData = 50;
            //test to see the two values are the same
            Assert.AreNotEqual(TestData, ATrainer.Price);
        }
        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            ATrainer.DateAdded = TestData;
            //test to see the two values are the same
            Assert.AreEqual(TestData, ATrainer.DateAdded);
        }
        [TestMethod]
        public void FoundOK()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestTrainerIDFound()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            //check the trainer ID
            if(ATrainer.TrainerID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            //check the property
            if (ATrainer.DateAdded !=  Convert.ToDateTime("15/01/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBrandFound()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            //check the property
            if (ATrainer.Brand != "Adidas")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            //check the property
            if (ATrainer.Name != "Originals")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            //check the property
            if (ATrainer.Colour != "White")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSizeFound()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            //check the property
            if (ATrainer.Size != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            //check the property
            if (ATrainer.Price != Convert.ToDecimal(50.00))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class clsTrainers
            clsTrainers ATrainer = new clsTrainers();
            //test data to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 TrainerID = 2;
            //invoke the method
            Found = ATrainer.Find(TrainerID);
            //check the property
            if (ATrainer.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

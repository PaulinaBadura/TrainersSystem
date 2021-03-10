using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstTrainers
    {
        //good test data to pass the method
        string Brand = "Adidas";
        string Name = "Originals";
        string Colour = "White";
        string Size = "2";
        string Price = "9.89";
        string DateAdded = DateTime.Now.Date.ToString();

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
       [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = ""; //this should trigger an error
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BrandMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aa"; //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(49, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMax()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(50, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMid()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(25, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BrandMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(51, 'N'); //this should fail
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BrandMaxExtreme()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(100, 'N'); //this should fail
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is - 100 years
            TestData = TestData.AddYears(-100);
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is - 1 day
            TestData = TestData.AddDays(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 1 day
            TestData = TestData.AddDays(1);
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is + 100 years
            TestData = TestData.AddYears(100);
            //convert the date variable to a string variable 
            string DateAdded = TestData.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = ""; 
            //set the dateAdded to a non date value
            string DateAdded = "This is not a date";
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //////////
        /// <summary>
        /// 
        /// </summary>
        /// 
        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(49, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(50, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(25, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(51, 'N'); //this should fail
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxExtreme()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(100, 'N'); //this should fail
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = ""; //this should trigger an error
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ColourMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aa"; //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(49, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ColourMax()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(50, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ColourMid()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(25, 'N'); //this should be okay
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ColourMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(51, 'N'); //this should fail
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ColourMaxExtreme()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(100, 'N'); //this should fail
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SizeMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestSize = 0; //this should trigger an error
            //convert the size variable to a string variable
            string Size = TestSize.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SizeMin()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestSize = 1; //this should pass
            //convert the size variable to a string variable
            string Size = TestSize.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SizeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestSize = 2; //this should pass
            //convert the size variable to a string variable
            string Size = TestSize.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SizeMid()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestSize = 6; //this should pass
            //convert the size variable to a string variable
            string Size = TestSize.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SizeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestSize = 11; //this should pass
            //convert the size variable to a string variable
            string Size = TestSize.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SizeMax()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestSize = 12; //this should pass
            //convert the size variable to a string variable
            string Size = TestSize.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SizeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 TestSize = 13; //this should pass
            //convert the size variable to a string variable
            string Size = TestSize.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SizeInvalidData()
        {
            //create instance of the class
            clsTrainers ATrainer = new clsTrainers();
            //string to store error message
            String Error = "";
            //set the date added to non date value
            String Size = "Value entered is not a number!";
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Decimal TestPrice = 0.00M; //this should trigger an error
            //convert the size variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Decimal TestPrice = 0.01M; //this should pass
            //convert the size variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Decimal TestPrice = 0.02M; //this should pass
            //convert the size variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Decimal TestPrice = 250.00M; //this should pass
            //convert the size variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Decimal TestPrice = 499.99M; //this should pass
            //convert the size variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Decimal TestPrice = 500.00M; //this should pass
            //convert the size variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTrainers ATrainer = new clsTrainers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Decimal TestPrice = 500.01M; //this should pass
            //convert the size variable to a string variable
            string Price = TestPrice.ToString();
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceInvalidData()
        {
            //create instance of the class
            clsTrainers ATrainer = new clsTrainers();
            //string to store error message
            String Error = "";
            //set the price to non money value
            String Size = "Value entered is not money!";
            //invoke the method
            Error = ATrainer.Valid(Brand, Name, Colour, Size, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}

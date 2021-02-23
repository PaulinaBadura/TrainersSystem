using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstCustomer
    {
        //good test data to pass to the method
        string FirstName = "John";
        string LastName = "Wick";
        string DateOfBirth = DateTime.Now.AddYears(-16).ToString();
        string Email = "email12@test.uk";
        string Password = "Password123";
        string HouseNo = "123B";
        string Street = "Regent Road";
        string Town = "Leicester";
        string PostCode = "LE1 7LT";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            Int32 TestData = 12;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "John";
            //assign the data to the property
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }


        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "Patel";
            //assign the data to the property
            ACustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "John123@gmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "Password123l";
            //assign the data to the property
            ACustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "123b";
            //assign the data to the property
            ACustomer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.HouseNo, TestData);
        }


        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "Regent Road";
            //assign the data to the property
            ACustomer.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Street, TestData);
        }


        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "LE1 7LT";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }


        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create som test data to assign to the property 
            string TestData = "Leicester";
            //assign the data to the property
            ACustomer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Town, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if(ACustomer.CustomerID !=4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.FirstName != "John")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.LastName != "Wick")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.Email != "JohnWick@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.Password != "John123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.DateOfBirth != Convert.ToDateTime("22/02/1990"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.HouseNo != "123B")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.Street != "Some Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.PostCode != "LE1 7LT")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 4;
            //invoe the method
            Found = ACustomer.Find(CustomerID);
            //check the customer no
            if (ACustomer.Town != "Leicester")
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
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke method 
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; // should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName =FirstName.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');// should pass (50 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');// should pass (25 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');// should fail 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; // should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a"; // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa"; // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');// should pass (50 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');// should pass (25 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');// should fail 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 15 years and 364 days ( 16 birthday is tomorrow) 
            TestDate = TestDate.AddYears(-16).AddDays(1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 16 years ( 16 birthday today)  
            TestDate = TestDate.AddYears(-16);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 16 years and 1 day (16 birthday yesterday)
            TestDate = TestDate.AddYears(-16).AddDays(-1);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 120 years
            TestDate = TestDate.AddYears(-120);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 250 years
            TestDate = TestDate.AddYears(-250);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class 
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any error message
            String Error = "";
            //set the DateOfBirth to non date value
            string DateOfBirth = "This is not a date!";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void PasswordExtremeMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = ""; // should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(7, 'a'); // should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(8, 'a'); // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(9, 'a');// should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(15, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(16, 'a');// should pass 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(12, 'a');// should pass (25 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(17, 'a');// should fail 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; // should trigger an error
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void HouseNoMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";// should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void HouseNoMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aa";// should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo= "aaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


       

        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void StreetMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(1, 'a'); // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(2, 'a');// should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street= "";
            Street = Street.PadRight(50, 'a');// should pass 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(25, 'a');// should pass (25 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(51, 'a');// should fail 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TwonMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(1, 'a'); // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(2, 'a');// should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(59, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town =Town.PadRight(60, 'a');// should pass 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(30, 'a');// should pass (25 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(61, 'a');// should fail 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PostCodedMinLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = ""; 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(1, 'a'); // should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(2, 'a');// should pass
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodMaxLessOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCod = "";
            PostCod = PostCod.PadRight(7, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(8, 'a');// should pass 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(4, 'a');// should pass (25 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(9, 'a');// should fail 
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, Email, Password, HouseNo, Street, Town, PostCode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

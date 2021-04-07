using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstStaff
    {
        //good test data to pass to the method
        string FirstName = "Jane";
        string LastName = "Smith";
        string DateOfBirth = DateTime.Now.AddYears(-23).ToString();
        string Department = "Marketing";
        string Email = "Jane.S23@gmail.com";
        string Password = "JS19!M";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            string TestData = "Jane";
            //assign the data to the property
            AStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            string TestData = "Smith";
            //assign the data to the property
            AStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfBirth, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            string TestData = "Marketing";
            //assign the data to the property
            AStaff.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Department, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            string TestData = "Jane.S23@gmail.com";
            //assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create som test data to assign to the property 
            string TestData = "JS19!M";
            //assign the data to the property
            AStaff.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Password, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bollean variable to store the reslt of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoe the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoe the method
            Found = AStaff.Find(StaffID);
            //check the customer no
            if (AStaff.StaffID != 1)
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
            clsStaff AStaff = new clsStaff();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoe the method
            Found = AStaff.Find(StaffID);
            //check the customer no
            if (AStaff.FirstName != "Jane")
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
            clsStaff AStaff = new clsStaff();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoe the method
            Found = AStaff.Find(StaffID);
            //check the customer no
            if (AStaff.LastName != "Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoe the method
            Found = AStaff.Find(StaffID);
            //check the customer no
            if (AStaff.DateOfBirth != Convert.ToDateTime("04/04/1998"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestDepartmentFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 4;
            //invoe the method
            Found = AStaff.Find(StaffID);
            //check the customer no
            if (AStaff.Department != "Marketing")
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
            clsStaff AStaff = new clsStaff();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoe the method
            Found = AStaff.Find(StaffID);
            //check the customer no
            if (AStaff.Email != "Jane.S23@gmail.com")
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
            clsStaff AStaff = new clsStaff();
            //Bollean variable to store the reult of the search
            Boolean Found = false;
            //Bolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoe the method
            Found = AStaff.Find(StaffID);
            //check the customer no
            if (AStaff.Password != "JS19!M")
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
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke method 
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; // should trigger an error 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; // should pass
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; // should pass
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');// should pass (50 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');// should pass (25 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');// should fail 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; // should trigger an error 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a"; // should pass
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa"; // should pass
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');// should pass (50 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');// should pass (25 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');// should fail 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 110 years
            TestDate = TestDate.AddYears(-120);
            //convert the data variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class 
            clsStaff AStaff = new clsStaff();
            //string var to store any error message
            String Error = "";
            //set the DateOfBirth to non date value
            string DateOfBirth = "Invalid format of date";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DepartmentMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void DepartmentMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(1, 'a'); // should pass
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(2, 'a');// should pass
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(29, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(30, 'a');// should pass 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(15, 'a');// should pass (15 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(31, 'a');// should fail 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; // should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //
        //
        // test email

        [TestMethod]
        public void PasswordExtremeMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = ""; // should trigger an error
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(5, 'a'); // should trigger an error 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department,  Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(6, 'a'); // should pass
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(7, 'a');// should pass
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(16, 'a');// should pass 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(25, 'a');// should pass (25 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(51, 'a');// should fail 
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //string var to store any Error  message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(200, 'a');// should fail (200 characters)
            //invoke the method
            Error = AStaff.Valid(FirstName, LastName, DateOfBirth, Department, Email, Password);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

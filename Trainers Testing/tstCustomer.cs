using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;

namespace Trainers_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
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

    }
}

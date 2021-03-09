using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;
using System.Collections.Generic;

namespace Trainers_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create som test data to asign to the property in this case a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create an item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.FirstName = "Adam";
            TestItem.LastName = "Merkel";
            TestItem.Email = "adam.m@gmail.com";
            TestItem.Password = "password";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-17);
            TestItem.HouseNo = "123b";
            TestItem.Street = "Some street";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "Le1 7Lt";
            //add the item to the list
            TestList.Add(TestItem);
            //asign the data to the property
            AllCustomers.CustomersList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.CustomersList, TestList);
        }


        

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.FirstName = "Adam";
            TestCustomer.LastName = "Merkel";
            TestCustomer.Email = "adam.m@gmail.com";
            TestCustomer.Password = "password";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-17);
            TestCustomer.HouseNo = "123b";
            TestCustomer.Street = "Some street";
            TestCustomer.Town = "Leicester";
            TestCustomer.PostCode = "Le1 7Lt";
            //assign the data to the property 
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create an item of test data
            clsCustomer TestItem = new clsCustomer();
            //set the properties of the test object
            TestItem.FirstName = "Adam";
            TestItem.LastName = "Merkel";
            TestItem.Email = "adam.m@gmail.com";
            TestItem.Password = "password";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-17);
            TestItem.HouseNo = "123b";
            TestItem.Street = "Some street";
            TestItem.Town = "Leicester";
            TestItem.PostCode = "Le1 7Lt";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCustomers.CustomersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


        
    }

}

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


        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of a class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestCustomer = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Paulina";
            TestCustomer.LastName = "Rose";
            TestCustomer.Email = "rose.p@gmail.com";
            TestCustomer.Password = "mypassword1";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestCustomer.HouseNo = "1234";
            TestCustomer.Street = "Street New";
            TestCustomer.Town = "London";
            TestCustomer.PostCode = "LW3 45G";
            //set this customer to the test data
            AllCustomers.ThisCustomer = TestCustomer;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestCustomer.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestCustomer = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Eva";
            TestCustomer.LastName = "RoseLane";
            TestCustomer.Email = "eva.r@gmail.com";
            TestCustomer.Password = "mypassword1";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestCustomer.HouseNo = "1234";
            TestCustomer.Street = "Street New";
            TestCustomer.Town = "London";
            TestCustomer.PostCode = "LW3 45G";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestCustomer;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestCustomer.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //noe find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestCustomer = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestCustomer.FirstName = "Eva";
            TestCustomer.LastName = "RoseLane";
            TestCustomer.Email = "eva.r@gmail.com";
            TestCustomer.Password = "mypassword1";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestCustomer.HouseNo = "1234";
            TestCustomer.Street = "Street New";
            TestCustomer.Town = "London";
            TestCustomer.PostCode = "LW3 45G";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestCustomer;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestCustomer.CustomerID = PrimaryKey;
            //modify the test data
            TestCustomer.FirstName = "Evy";
            TestCustomer.LastName = "Lane";
            TestCustomer.Email = "eva.r@gmail.com";
            TestCustomer.Password = "mypassword1";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestCustomer.HouseNo = "1234";
            TestCustomer.Street = "Street some";
            TestCustomer.Town = "York";
            TestCustomer.PostCode = "LW3 45G";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestCustomer;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class contianing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank tring (should return all records)
            FilteredCustomers.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
           //instance of the filterd data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply apost code that dosent exist
            FilteredCustomers.ReportByPostCode("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //instance of the filterd data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesnt exist
            FilteredCustomers.ReportByPostCode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check the first record id is 11
                if (FilteredCustomers.CustomersList[0].CustomerID != 11)
                {
                    OK = false;
                }
                //check the first record id is 12
                if (FilteredCustomers.CustomersList[1].CustomerID != 12)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ReportByEmailMethodOK()
        {
            //create an instance of the class contianing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank tring (should return all records)
            FilteredCustomers.ReportByEmail("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByEmailNoneFound()
        {
            //instance of the filterd data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply apost code that dosent exist
            FilteredCustomers.ReportByEmail("xxxxxxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

    }

}

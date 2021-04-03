using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersClasses;
using System.Collections.Generic;

namespace Trainers_Testing
{
    [TestClass]
    public class tstTrainersCollection
    {
        
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class 
            clsTrainersCollection AllTrainers = new clsTrainersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllTrainers);
        }
        [TestMethod]
        public void TrainersListOK()
        {
            //create an instance of the class 
            clsTrainersCollection AllTrainers = new clsTrainersCollection();
            //create some test data to assign to the property
            //list of objects
            List<clsTrainers> TestList = new List<clsTrainers>();
            //add an item to the list
            //create the item of test data
            clsTrainers TestItem = new clsTrainers();
            //set its properties 
            TestItem.Brand = "Adidas";
            TestItem.Name = "Originals";
            TestItem.Colour = "White";
            TestItem.Size = 2;
            TestItem.Price = 9.89M;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.InStock = true;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllTrainers.TrainersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllTrainers.TrainersList, TestList);
        }
        

        [TestMethod]
        public void ThisTrainersPropertyOK()
        {
            //create an instance of the class 
            clsTrainersCollection AllTrainers = new clsTrainersCollection();
            //create some test data to assign to the property
            clsTrainers TestTrainers = new clsTrainers();
            //set the properties of the test object
            TestTrainers.Brand = "Adidas";
            TestTrainers.Name = "Originals";
            TestTrainers.Colour = "White";
            TestTrainers.Size = 2;
            TestTrainers.Price = 9.89M;
            TestTrainers.DateAdded = DateTime.Now.Date;
            TestTrainers.InStock = true;
            //assign the data to the property
            AllTrainers.ThisTrainer = TestTrainers;
            //test to see that it exists
            Assert.AreEqual(AllTrainers.ThisTrainer, TestTrainers);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class 
            clsTrainersCollection AllTrainers = new clsTrainersCollection();
            //create some test data to assign to the property
            List<clsTrainers> TestList = new List<clsTrainers>();
            //add an item to the list
            //create the item of test data
            clsTrainers TestItem = new clsTrainers();
            //set the properties of the test object
            TestItem.Brand = "Adidas";
            TestItem.Name = "Originals";
            TestItem.Colour = "White";
            TestItem.Size = 2;
            TestItem.Price = 9.89M;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.InStock = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllTrainers.TrainersList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllTrainers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class 
            clsTrainersCollection AllTrainers = new clsTrainersCollection();
            //create the item of test data
            clsTrainers TestItem = new clsTrainers();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.Brand = "Adidas";
            TestItem.Name = "Originals";
            TestItem.Colour = "White";
            TestItem.Size = 2;
            TestItem.Price = 9.89M;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.InStock = true;
            //set ThisTrainer to the test data
            AllTrainers.ThisTrainer = TestItem;
            //add the record
            PrimaryKey = AllTrainers.Add();
            //set the primary key of the test data
            TestItem.TrainerID = PrimaryKey;
            //find the record
            AllTrainers.ThisTrainer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllTrainers.ThisTrainer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class 
            clsTrainersCollection AllTrainers = new clsTrainersCollection();
            //create the item of test data
            clsTrainers TestItem = new clsTrainers();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.Brand = "Adidas";
            TestItem.Name = "Originals";
            TestItem.Colour = "White";
            TestItem.Size = 2;
            TestItem.Price = 9.89M;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.InStock = true;
            //set ThisTrainer to the test data
            AllTrainers.ThisTrainer = TestItem;
            //add the record
            PrimaryKey = AllTrainers.Add();
            //set the primary key of the test data
            TestItem.TrainerID = PrimaryKey;
            //find the record
            AllTrainers.ThisTrainer.Find(PrimaryKey);
            //delete the record
            AllTrainers.Delete();
            //now find the record
            Boolean Found = AllTrainers.ThisTrainer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class 
            clsTrainersCollection AllTrainers = new clsTrainersCollection();
            //create the item of test data
            clsTrainers TestItem = new clsTrainers();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestItem.Brand = "Adidas";
            TestItem.Name = "Originals";
            TestItem.Colour = "White";
            TestItem.Size = 2;
            TestItem.Price = 9.89M;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.InStock = true;
            //set ThisTrainer to the test data
            AllTrainers.ThisTrainer = TestItem;
            //add the record
            PrimaryKey = AllTrainers.Add();
            //set the primary key of the test data
            TestItem.TrainerID = PrimaryKey;
            //modify the test data
            TestItem.Brand = "Nike";
            TestItem.Name = "AirMax";
            TestItem.Colour = "Black";
            TestItem.Size = 7;
            TestItem.Price = 75.99M;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.InStock = false;
            //set the record based on the new test data
            AllTrainers.ThisTrainer = TestItem;
            //update the record
            AllTrainers.Update();
            //find the record
            AllTrainers.ThisTrainer.Find(PrimaryKey);
            //test to see ThisTrainer matches the test data
            Assert.AreEqual(AllTrainers.ThisTrainer, TestItem);
        }
    }
}

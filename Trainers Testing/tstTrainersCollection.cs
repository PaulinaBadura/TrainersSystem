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
            AllTrainers.ThisTrainers = TestTrainers;
            //test to see that it exists
            Assert.AreEqual(AllTrainers.ThisTrainers, TestTrainers);
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

        
    }
}

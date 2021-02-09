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
    }
}

using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCinemaCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an ninstance of the class we want to create
            clsCinemaCollection AllCinema = new clsCinemaCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCinema);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create the instance of the class we want to create 
            clsCinemaCollection AllCinema = new clsCinemaCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllCinema.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCinema.Count, SomeCount);
        }

        [TestMethod]
        public void AllCinemaOK()
        {
            //create an instance of the class we want to create
            clsCinemaCollection Cinema = new clsCinemaCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCinema> TestList = new List<clsCinema>();
            //add an item to the list
            //create the item of the test data
            clsCinema TestItem = new clsCinema();
            //set its properties
            TestItem.CinemaId = 12;
            TestItem.Cinema = "Leicester";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Cinema.AllCinema = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Cinema.AllCinema, TestList);

        }

    }
}

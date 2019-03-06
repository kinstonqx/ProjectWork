using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllShowings = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllShowings);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            //create the instance of the class we want to create 
            clsCustomerCollection AllShowings = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllShowings.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllShowings.Count, SomeCount);
        }

        [TestMethod]
        public void AllCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection Customer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FirstName = "James";
            TestItem.LastName = "John";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customer.AllCustomer = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.AllCustomer, TestList);
        }
    }
}
    

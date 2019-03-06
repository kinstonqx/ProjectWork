using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class clsMovies
            clsCustomer AnCustomer = new clsCustomer();
            //check to see that the class is not null
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeCustomer = "James";
            //assign the data to the property
            ACustomer.FirstName = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, SomeCustomer);

        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeCustomer = "John";
            //assign the data to the property
            ACustomer.LastName = SomeCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, SomeCustomer);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 CustomerId = 1;
            //assign the data to the property
            ACustomer.CustomerId = CustomerId;
            //test to see that the two value are the same
            Assert.AreEqual(ACustomer.CustomerId, CustomerId);
        }
    }
}
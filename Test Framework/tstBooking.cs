using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstBooking
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class clsTicket
            clsBooking ABooking = new clsBooking();
            //check to see that the class is not null
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        public void BookingIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property
            Int32 BookingId = 4;
            //assign the data to the property
            ABooking.BookingId = BookingId;
            //test to see that the two value are the same
            Assert.AreEqual(ABooking.BookingId, BookingId);
        }

        [TestMethod]
        public void BookingDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property
            Int32 BookingDate = 03/04/2018;
            //assign the data to the property
            ABooking.BookingDate = BookingDate;
            //test to see that the two value are the same
            Assert.AreEqual(ABooking.BookingDate, BookingDate);
        }
    }
}

using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class txtMovies
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class clsMovies
            clsMovies AnMovies = new clsMovies();
            //check to see that the class is not null
            Assert.IsNotNull(AnMovies);
        }
    }
}

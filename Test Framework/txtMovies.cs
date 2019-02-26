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


        [TestMethod]
        //used to test the movie property of the class
        public void MoviePropertyOK()
        {
            //create an instance of the class
            clsMovies AMovie = new clsMovies();
            //create some test data to assign to the property
            string SomeMovie = "Shrek";
            //assign the data to the property
            AMovie.Movie = SomeMovie;
            //test to see that the two values are the same
            Assert.AreEqual(AMovie.Movie, SomeMovie);
        }
    }
}

    
    
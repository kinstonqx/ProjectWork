using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstMovieCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an ninstance of the class we want to create
            clsMovieCollection AllMovies = new clsMovieCollection();
            //test to see that it exists
            Assert.IsNotNull(AllMovies);
        }


        [TestMethod]
        public void CountPropertyOK();
        {
        //create the instance of the class we want to create 
        clsMovieCollection AllMovies = new clsMovieCollection();
        //create some test data to assign to the property
        Int32 SomeCount = 1;
        //assign the data to the property
        AllMovies.Count = SomeCount;
        //test to see that the two values are the same 
        Assert.AreEqual(AllMovies.Count, SomeCount);
        
            
      }
    }


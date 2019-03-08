using System.Collections.Generic;

namespace Class_Library
{
    public class clsCinemaCollection
    {
        private List<clsCinema> mAllCinema = new List<clsCinema>();

        //public property for count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllCinema.Count;
            }
            set
            {

            }
        }
        //public property for allmovies
        public List<clsCinema> AllCinema
        {
            //getter sends data to requesting code
            get
            {
                //return private data member
                return mAllCinema;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllCinema = value;
            }
        }
    }
}

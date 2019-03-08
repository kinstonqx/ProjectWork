using System;

namespace Class_Library
{
    public class clsCinema
    {
        public string Cinema { get; set; }
        public int CinemaId { get; set; }

        public string Valid(string someCinema)
        {//string variable to store the error message
            string Error = "";
            //if the name of the country is not blank
            if (someCinema.Length > 50)
            {
                //return an error message
                Error = "The Cinema name cannot have more than 50 characters";
            }
            if (someCinema.Length == 0)
            {
                // return an error message
                Error = "The Cinema name may not be blank!";
            }
            return Error;
        }
        }
    }

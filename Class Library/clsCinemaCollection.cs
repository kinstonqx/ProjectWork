using System;
using System.Collections.Generic;
using Class_Library;

namespace Class_Library
{
    public clsCinemaCollection()
    {
        //create an instance of the dataconnection
        clsDataConnection DB = new clsDataConnection();
        //execute the stored procedure to get the list of data
        DB.Execute("sproc_tblCinema_SelectAll");
        //get the count of records
        Int32 RecordCount = DB.Count;
        //set up the index for the loop
        Int32 Index = 0;
        //while there are records to process
        while (Index < RecordCount)
        {
            //create a new instance of the cinema class
            clsCinema ACinema = new clsCinema();
            //get the cinema name
            ACinema.Cinema = DB.DataTable.Rows[Index]["Cinema"].ToString();
            //get the primary key
            ACinema.CinemaId = Convert.ToInt32(DB.DataTable.Rows[Index]["CinemaId"]);
            //add the cinema to the private data member
            mAllCinema.Add(ACinema);
            //increment the index
            Index++;
        }


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

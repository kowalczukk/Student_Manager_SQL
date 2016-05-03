using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager2
{
    public class Person //: IEnumerable<cOsoba> 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int Id
        //{
        //    get
        //    {
        //        return Id;
        //    }

        //    set
        //    {
        //        Id = value;
        //    }
        //}
        //public string FirstName
        //{
        //    get
        //    {
        //        return FirstName;
        //    }

        //    set
        //    {
        //        FirstName = value;
        //    }
        //}
        //public string LastName
        //{
        //    get
        //    {
        //        return LastName;
        //    }

        //    set
        //    {
        //        LastName = value;
        //    }
        //}


        //#region deklaracje zmiennych
        //int _Id = 0;
        //string _FirstName = "", _LastName = "";
        //#endregion

        //public Person() { }
        //public Person(string firstName, string lastName, int id)
        //{
        //    _Id = id;
        //    _FirstName = firstName;
        //    _LastName = lastName;
        //}
        //public int Id { get { return _Id; } }
        //public string FirstName
        //{
        //    get { return _FirstName; }
        //    //set { _imie = value; }
        //}
        //public string LastName
        //{
        //    get { return _LastName; }
        //    //set { _nazwisko = value; }
        //}
        //public string FullName
        //{
        //    get { return _FirstName + " " + _LastName; }
        //}
    }
}

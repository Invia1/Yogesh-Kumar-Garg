using System;
using System.Text.RegularExpressions;


namespace SmallEmployeeApp.Models
{
     class Employee
    {
        // public int EId { get; set; }
        private int _eId;
        public int EId
        {
            get
            {
                return _eId;
            }
            set
            {
                _eId = value;
               

            }
        }

        public string EName { get; set; }
        //public string EName
        //{ 
        //    get { return EName; }
        //    set
        //    {
        //        EName= value;
        //    }
        //{ 
        //    if(Regex.IsMatch(value,"^[a-zA-Z ]+$"))
        //    {
        //        EName= value;

        //    }
        //    else
        //    {
        //        Console.WriteLine("please enter valid name:");

        //    }
        // }

        // }
        public int EAge { get; set; }
    }
}

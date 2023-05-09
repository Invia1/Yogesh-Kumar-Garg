using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment
{
    class Person
    {
        string _pName;
        double _amount;
        public string PName
        {
            get { return _pName; }
            set
            {
                _pName = value;
                while (string.IsNullOrWhiteSpace(_pName) )
                {
                    Console.WriteLine("Name is required field , Please enter your name .....");
                    string name = Console.ReadLine();
                    _pName = name;
                }
            }
        }


        public double Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                if (_amount >= 10000)
                {
                    Console.WriteLine("you can shopping..........Enjoy");
                }
                else
                {
                    Console.WriteLine($"sorry,{PName} you don`t have sufficient balance:");
                }
            }
        }


    }

    class AccountDetails
    {
        public void AccountInfo()
        {
            Person obj1 = new Person();

            Console.WriteLine("enter your name:");
            obj1.PName = Console.ReadLine();

            Console.WriteLine("enter Your account balance:");
            obj1.Amount = Convert.ToDouble(Console.ReadLine());


        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            AccountDetails obj = new AccountDetails();
            obj.AccountInfo();




        }
    }
}

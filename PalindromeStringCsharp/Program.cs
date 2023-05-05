using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeStringCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a name which to be check if it is palindrome or not");
            string str= Console.ReadLine();

            char[] arr= str.ToCharArray();
            Array.Reverse(arr);
            string str2= new string(arr);

            if (str.ToLower() == str2.ToLower())
            {
                Console.WriteLine("palindrome");
            }
            else
                Console.WriteLine("not palindrome");

            Console.ReadKey();


                                            
       
            
            
            
        }

    }
}

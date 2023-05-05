using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCharactersCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            int count = 0;
            Console.WriteLine("Enter a name::");
            string name = Console.ReadLine();

            char[] arr = name.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && arr[i] != ' ' && arr[j]!='0' )
                    {
                        count++;
                        arr[j] = '0';
                    }
                }
                if (count > 1 )
                    Console.WriteLine(arr[i] + "---" + count + "times");
            }
            Console.ReadLine();
           
            
        }
    }
}

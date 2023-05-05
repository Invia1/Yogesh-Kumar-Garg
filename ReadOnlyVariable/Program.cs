using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyVariable
{
    internal class Program
    {
        public static readonly int i = 9;

       static Program()
        {
            i=10;
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            Console.WriteLine(i);
        }
    }
}

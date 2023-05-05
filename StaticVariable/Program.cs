using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariable
{
    class employee
    {
        public string empName;
        public static string organizationName;
        public  int employeeId;

         static employee()
        {
            organizationName= "invia";   // initialize static variable in static constructor
        }
        static void Main(string[] args)
        {
            employee emp1= new employee();
            emp1.empName = "yug";
            organizationName = "invia private limited"; // changable 
            emp1.employeeId = 4218;

            employee emp2= new employee();
            emp2.empName = "lalit";
            emp2.employeeId = 4219;

            
            Console.WriteLine("employee name---{0}, employee id----{1}, organization name----{2}",emp1.empName,emp1.employeeId,organizationName);
            Console.WriteLine("employee name---{0}, employee id----{1}, organization name----{2}", emp2.empName, emp2.employeeId, organizationName);
              Console.ReadLine();
        }

    }
}

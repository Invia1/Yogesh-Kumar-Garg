using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EmployeeDetailsWithCollections.BLL;
using EmployeeDetailsWithCollections.Model;

namespace EmployeeDetailsWithCollections.EntryPoint
{
    class EmployeesDetails
    {
        public static void Main(string[] args)
        {
             HR obj=new HR();
            ArrayList array=new ArrayList();
            array = obj.Employeesdetails();

            int a = 1;
            foreach (Employee item in array)
            {
                Console.WriteLine($"---------Employee {a}------\nEmployee id--{item.EmpId}\n Employee name---{item.EmpName}\n Employee Age---{item.EmpAge}");
                a++;
            }

        }
    }
}

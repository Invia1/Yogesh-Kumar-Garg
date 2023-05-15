using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;



namespace EmployeeDetailsWithCollections
{

    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
    }







    class HR
    {
        public List<Employee> Employeesdetails()
        {
            return new List<Employee>
            {
                new Employee
                {
                    EmpId=101,
                    EmpAge=25,
                    EmpName="yug"
                },
                new Employee
                {
                    EmpId=102,
                    EmpAge=27,
                    EmpName="lalit"
                },

                    new Employee
                {
                    EmpId=103,
                    EmpAge=26,
                    EmpName="Meenu"

                }
            };
        }

    }




    class EmployeesDetails
    {
        public static void Main(string[] args)
        {
            HR obj = new HR();
            List<Employee> array = new List<Employee>();
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
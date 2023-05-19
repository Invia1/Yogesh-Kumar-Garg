using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }


    class EmployeesOperation
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("data has been added");
        }

        public void SearchEmployee()
        {


            Console.WriteLine(" enter the employee name which you want to search  and you will get last occurance of that name");
            string name = Console.ReadLine();


            Employee searchedEmployee = employees.LastOrDefault(emp => emp.EmpName == name);
            if (searchedEmployee != null)
            {
                Console.WriteLine(searchedEmployee.EmpID + ", " + searchedEmployee.EmpName);
            }
            else
            {
                Console.WriteLine($"{name} is not in the list");
            }


        }


        public List<Employee> GetEmployees()
        { return employees; }



    }

    class Program
    {
        static void Main()
        {


            EmployeesOperation EO = new EmployeesOperation();
            char reply = ' ';

            do
            {
                Console.WriteLine("enter the details of a Employee");
                Employee obj = new Employee();

                Console.WriteLine("enter employee id");
                obj.EmpID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter employee name");
                obj.EmpName = Console.ReadLine();

                Console.WriteLine("enter employee job");
                obj.Job = Console.ReadLine();

                Console.WriteLine("enter employee salary");
                obj.Salary = Convert.ToDouble(Console.ReadLine());

                EO.AddEmployee(obj);

                Console.WriteLine("if you want to add more data then type y");
                reply = Convert.ToChar(Console.ReadLine());

            } while (reply == 'y' || reply == 'Y');



            EO.SearchEmployee();

            Console.ReadKey();
        }
    }
}


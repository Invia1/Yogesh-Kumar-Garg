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


        public void SortedlistOfEmployees()
        {


            IOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.EmpName);

            Console.WriteLine("\nsorting in ascending order by Employee name\n");
            foreach (Employee item in sortedEmployees)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.Salary);
            }

            IOrderedEnumerable<Employee> sortedEmployees1 = employees.OrderByDescending(emp => emp.EmpName);

            Console.WriteLine("\nsorting in descending order by Employee name\n");
            foreach (Employee item in sortedEmployees1)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.Salary);
            }


            IOrderedEnumerable<Employee> sortedEmployees2 = employees.OrderBy(emp => emp.Salary);
            Console.WriteLine("\nsorting in ascending order by Employee salary\n");
            foreach (Employee item in sortedEmployees2)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.Salary);
            }

            IOrderedEnumerable<Employee> sortedEmployees3 = employees.OrderByDescending(emp => emp.Salary);
            Console.WriteLine("\nsorting in descending order by Employee salary\n");
            foreach (Employee item in sortedEmployees3)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.Salary);
            }

        }



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

            EO.SortedlistOfEmployees();







            Console.ReadKey();
        }
    }
}

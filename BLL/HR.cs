using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDetailsWithCollections.Model;

namespace EmployeeDetailsWithCollections.BLL
{
     class HR
    {
        public ArrayList Employeesdetails()
        {
            return new ArrayList
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
}

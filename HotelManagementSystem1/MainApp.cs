using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.Models;
using HotelManagementSystem.Bll;
using System.Reflection.Emit;
using System.ComponentModel;

namespace HotelManagementSystem
{
     class MainApp
    {
        static void Main(string[] args)
        {
            PatientOperation PS = new PatientOperation();
            int num;
            Label:
            do
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("enter 1 for registration of a new patient");
                Console.WriteLine("enter 2  to get all patient details");
                Console.WriteLine("enter 3 to get  a specific patient details by aadhaar no");
                Console.WriteLine("enter 4 to get a specific patient details by id");
                Console.WriteLine("enter 0 to exit");

                num = Convert.ToInt32(Console.ReadLine());

                

                if (num >= 0 && num <= 4)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine(" ---------------------------Enter details----------------------");
                            PatientDetails PDO = new PatientDetails();
                            Console.WriteLine($"patient id--");
                            PDO.PatientRegistrationId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"patient first name-");
                            PDO.PatientFirstName = Console.ReadLine();
                            Console.WriteLine("enter patient last name");
                            PDO.PatientLastName = Console.ReadLine();
                            Console.WriteLine($"patient phone no:");
                            PDO.PatientPhoneNumber =Convert.ToInt64( Console.ReadLine());
                            Console.WriteLine($"patient Gender:");
                            PDO.Gender = Console.ReadLine();
                            Console.WriteLine($"patient age:");
                            PDO.Age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"patient Address:");
                            PDO.Address = Console.ReadLine();
                            Console.WriteLine($"patient Aadhaar:");
                            PDO.Aadhar_No = Convert.ToInt64( Console.ReadLine());
                            Console.WriteLine($"patient speciality: general medicine\\Orthopedics\\Dental");
                            PDO.SpecialityToBeConsulted = Console.ReadLine();


                            PS.AddPatient(PDO);
                            break;


                        case 2:
                            PS.DisplayAll();
                            break;

                        case 3:
                            Console.WriteLine("enter patient aadhar no  which patient detAILS DO YOU WANT");

                            long ad =Convert.ToInt64( Console.ReadLine());
                            PS.GetDetailsByAadhaar(ad);

                            break;

                            case 4:

                            int ID= Convert.ToInt32( Console.ReadLine());
                            PS.GetDetailsById(ID);
                            break;
                        case 0:

                            Console.WriteLine("thank you");

                            break;



                    }



                }

                else
                {
                    Console.WriteLine("please enter valid number");
                    goto Label;
                }
            } while (num != 0);
        }
    }
}

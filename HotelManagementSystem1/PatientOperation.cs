using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Bll
{

    class PatientOperation
    {
        List<PatientDetails> PatientDetailsList = new List<PatientDetails>();

        public void DisplayAll()
        {

            

            foreach (var obj in PatientDetailsList)
            {
                Console.WriteLine(" ----------------------------------------------------");
                Console.WriteLine($"patient id---{obj.PatientRegistrationId}");
                Console.WriteLine($"patient name---{obj.PatientFirstName} {obj.PatientLastName}");
                Console.WriteLine($"patient phone no---{obj.PatientPhoneNumber}");
                Console.WriteLine($"patient Gender---{obj.Gender}");
                Console.WriteLine($"patient age---{obj.Age}");
                Console.WriteLine($"patient Address---{obj.Address}");
                Console.WriteLine($"patient Aadhaar---{obj.Aadhar_No}");
                Console.WriteLine($"patient speciality---{obj.SpecialityToBeConsulted}");


            }
        }

        public void AddPatient(PatientDetails pd)
        {

            var abd = PatientDetailsList.Where(PD => PD.Aadhar_No == pd.Aadhar_No);

            var abc = PatientDetailsList.Where(PD => PD.PatientRegistrationId == pd.PatientRegistrationId);


            if (abc.Count() != 0)
            {

                Console.WriteLine($"patient with id --{pd.PatientRegistrationId} is already exist:");

            }
               
            if(abd.Count() != 0) {
                Console.WriteLine($"patient with adhaar --{pd.Aadhar_No} is already exist:");
            }
        
            if(abc.Count() == 0 && abd.Count()==0)
            {
                PatientDetailsList.Add(pd); 
            }

        }
           


        


        public void GetDetailsByAadhaar(long Aadhaar)
        {
            PatientDetails obj = PatientDetailsList.First(PD => PD.Aadhar_No == Aadhaar);

            Console.WriteLine($"patient id---{obj.PatientRegistrationId}");
            Console.WriteLine($"patient name---{obj.PatientFirstName} {obj.PatientLastName}");
            Console.WriteLine($"patient phone no---{obj.PatientPhoneNumber}");
            Console.WriteLine($"patient Gender---{obj.Gender}");
            Console.WriteLine($"patient age---{obj.Age}");
            Console.WriteLine($"patient Address---{obj.Address}");
            Console.WriteLine($"patient Aadhaar---{obj.Aadhar_No}");
            Console.WriteLine($"patient speciality---{obj.SpecialityToBeConsulted}");

        }
    


        

        public void GetDetailsById(int id)
        {
            PatientDetails obj = PatientDetailsList.First(PD => PD.PatientRegistrationId == id);

            Console.WriteLine($"patient id---{obj.PatientRegistrationId}");
            Console.WriteLine($"patient name---{obj.PatientFirstName} {obj.PatientLastName}");
            Console.WriteLine($"patient phone no---{obj.PatientPhoneNumber}");
            Console.WriteLine($"patient Gender---{obj.Gender}");
            Console.WriteLine($"patient age---{obj.Age}");
            Console.WriteLine($"patient Address---{obj.Address}");
            Console.WriteLine($"patient Aadhaar---{obj.Aadhar_No}");
            Console.WriteLine($"patient speciality---{obj.SpecialityToBeConsulted}");


        }
    }
}

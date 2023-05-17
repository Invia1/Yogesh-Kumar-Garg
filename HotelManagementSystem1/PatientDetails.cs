using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
     class PatientDetails
    {
       
        public int PatientRegistrationId { get; set; }
        
        public string PatientFirstName { get;set; }
        public string PatientLastName { get; set; }
        public string Gender { get;set;}
        public int Age { get; set; }
        public long PatientPhoneNumber { get; set;}
        public string Address { get; set; }
        public long Aadhar_No { get; set; }
        public string SpecialityToBeConsulted { get; set;}
    }
    }




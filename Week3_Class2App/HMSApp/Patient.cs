using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HMSApp
{

    //data 
    public class Patient
    {
        public int Pid { get; set; }
        public string PatientName { get; set; }
        public string SpecialityConsulted { get; set; }


    }


    //data access layer
    public class PatientDetails
    {
        public IEnumerable<Patient> GetPatientDetails()
        {
            Patient p1 = new Patient()
            {
                Pid = 101,
                PatientName = "Alan",
                SpecialityConsulted = "GM"
            };

            return 
        }
    }


    //business logic layer
    public class PatientBusinessLogic
    {
        IEnumerable<PatientDetails> p2;
       
        public Patient GetPatients()
        {
            return p2.ge
        }
    }
}

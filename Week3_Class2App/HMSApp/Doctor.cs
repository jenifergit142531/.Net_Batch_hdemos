using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSApp
{
    public abstract class DoctorDepartment
    {
        public abstract void Departments();
        public void DeptNames()
        {
            Console.WriteLine("1.General medicine 2.Ortho 3.Pediac");
        }
    }

    class GeneralMedicine : DoctorDepartment
      {
        public override void Departments()
        {
            Console.WriteLine("Go to Wing 1 second floor for general medicine");

        }



    }




    /*  internal class Doctor
      {

          public static void DoctorDetails()
          {
              Console.WriteLine("You need to do the code here");
          }
          public static void DoctorAvailability()
          {
              Console.WriteLine("You need to do the code here");
          }
          public static void BookAppointment()
          {
              Console.WriteLine("You need to do the code here");
          }
          public static void CancelAppointment()
          {
              Console.WriteLine("You need to do the code here");
          }
      }*/
}

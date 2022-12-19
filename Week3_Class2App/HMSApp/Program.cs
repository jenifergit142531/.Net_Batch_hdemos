using HMSApp;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    public static void Main(string[] args)
    {

       PatientBusinessLogic bl = new PatientBusinessLogic();
        //var data= bl.GetPatients();
        foreach(var i in bl.GetPatients)
        {
            Console.WriteLine(i.Pid);
            Console.WriteLine(i.PatientName);
            Console.WriteLine(i.SpecialityConsulted);
        }





        //Doctor.DoctorDetails();
        // Doctor.DoctorAvailability();
        // Doctor.BookAppointment();
        //Doctor.CancelAppointment();


        //Tightly coupled code

        //GeneralMedicine gm = new GeneralMedicine();
        //gm.Departments();
        //gm.DeptNames();

    }
}

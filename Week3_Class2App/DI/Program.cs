
public interface IPatients
{
    void GetPatients();
    void GetDoctorDetails();
}
public class GMPatient : IPatients
{
    public void GetPatients()
    {
        Console.WriteLine("GM Patient details goes here");
    }
    public void GetDoctorDetails()
    {
        Console.WriteLine("GM Patient says hello");
    }
}
public class OrthoPatient : IPatients
{
    public void GetPatients()
    {
        Console.WriteLine("Ortho Patient details goes here");
    }
    public void GetDoctorDetails()
    {
        Console.WriteLine("Ortho Patient says hi");
    }
}
public class Client
{
    public void PatientList(IPatients patients)
    {
        patients.GetPatients();
        patients.GetDoctorDetails();
    }
}


class Program
{
    public static void Main(string[] args)
    {


        //DI in the code 

        Client c = new Client();
        GMPatient g1 = new GMPatient();
        c.PatientList(g1);
        OrthoPatient g2 = new OrthoPatient();
        c.PatientList(g2);






        /* GMPatient gp = new GMPatient();
         gp.GetPatients();
        gp.getdoctordetails();

         OrthoPatient op = new OrthoPatient();
         op.GetPatients();
        op.getdoctordetails();*/
    }
}

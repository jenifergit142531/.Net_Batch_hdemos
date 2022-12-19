
using Week3_Class2App;

class Program
{

   
    public static void Main(string[] args)
    {
        Numbers num = new Numbers();
        int result = num.Add(10, 20);
        Console.WriteLine("Result :" + result);
      
       /* Employee object1 = new Employee();
        EmployeePayroll object2 = new EmployeePayroll();
        EmployeePersonalDetails object3 = new EmployeePersonalDetails();


        Console.WriteLine("The number of generations " + GC.MaxGeneration);
        Console.WriteLine("Object 1 Generation :" + GC.GetGeneration(object1));
        Console.WriteLine("Object 2 Generation :" + GC.GetGeneration(object2));
        Console.WriteLine("Object 3 Generation :" + GC.GetGeneration(object3));
        GC.Collect();

        Console.WriteLine("The number of generations " + GC.MaxGeneration);
        Console.WriteLine("Object 1 Generation :" + GC.GetGeneration(object1));
        Console.WriteLine("Object 2 Generation :" + GC.GetGeneration(object2));
        Console.WriteLine("Object 3 Generation :" + GC.GetGeneration(object3));
        GC.Collect();

        Console.WriteLine("The number of generations " + GC.MaxGeneration);
        Console.WriteLine("Object 1 Generation :" + GC.GetGeneration(object1));
        Console.WriteLine("Object 2 Generation :" + GC.GetGeneration(object2));
        Console.WriteLine("Object 3 Generation :" + GC.GetGeneration(object3));
        GC.Collect();

        Console.WriteLine("The number of generations " + GC.MaxGeneration);
        Console.WriteLine("Object 1 Generation :" + GC.GetGeneration(object1));
        Console.WriteLine("Object 2 Generation :" + GC.GetGeneration(object2));
        Console.WriteLine("Object 3 Generation :" + GC.GetGeneration(object3));
       */

    }
}

/*class Employee
{
    
    ~Employee()
    {
        Console.WriteLine("Employee deleted");
    }

}
class EmployeePayroll
{

    ~EmployeePayroll()
    {
        Console.WriteLine("Employee payroll deleted");
    }

}
class EmployeePersonalDetails
{

    ~EmployeePersonalDetails()
    {
        Console.WriteLine("Employee personal details deleted");
    }

}*/




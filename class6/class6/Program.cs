using class6;
using System.Reflection;

class Program
{
    public static void Main(string[] args)
    {


        Assembly exec = Assembly.GetExecutingAssembly();
        Type[] typeInfo = exec.GetTypes();
        foreach(var mytypes in typeInfo)
        {
            Console.WriteLine("Class : " + mytypes.FullName);

            ConstructorInfo[] ci = mytypes.GetConstructors();
            foreach(var i in ci)
            {
                Console.WriteLine("Construtor Info" + i.ToString());
            }

            MethodInfo[] mi = mytypes.GetMethods();
            foreach(var methods in mi)
            {
                Console.WriteLine("Method Name :" + methods.Name);

                ParameterInfo[] pi = methods.GetParameters();
                foreach(var arg in pi)
                {
                    Console.WriteLine("Parameter name " + arg.Name);
                    Console.WriteLine("Parameter Type " + arg.ParameterType);
                }




            }
        }








       /* Type t = typeof(int);
        Console.WriteLine("Name : " + t.Name);
        Console.WriteLine("Full Name :"+t.FullName);
        Console.WriteLine("Namepace :" + t.Namespace);
        Console.WriteLine("Base Type :" + t.BaseType);*/


       /* EventApp e1 = new EventApp();

        //event and delegate binding
        e1.notify += new Mydel1(e1.SMSnotify);
        e1.notifyMail += new Mydel1(e1.Emailnotify);

        

        //Raise or trigger the event

        e1.RaiseEvent();











        // TaskParallel.TaskParallelism();

        //set the target method
        //single cast delegate
        delOne d1 = new delOne(DelegateApp.Show);

        //Multicast delegate

        delTwo d2 = new delTwo(DelegateApp.Add);
        d2 += new delTwo(DelegateApp.Sub);


        //generic delegate
        delThree<int> d3 = new delThree<int>(DelegateApp.price);
        delThree<string> d4 = new delThree<string>(DelegateApp.concat);



        //invoke the delegate
        //d1();

        //d2(20,5);

       /* int result = d3(2, 4500);
        string value=d4("Hello", "world");

        Console.WriteLine("Total price {0}", result);
        Console.WriteLine("Hi...{0}", value);*/

    }
}

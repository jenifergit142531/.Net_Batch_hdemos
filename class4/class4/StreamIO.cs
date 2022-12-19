using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class StreamIO
    {
        public static void CreateDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\demo\\mydirectory");
            try
            {
                if(dir.Exists)
                {
                    Console.WriteLine("Directory already exists");
                }
                else
                {
                    dir.Create();
                    Console.WriteLine("Directory is created");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void MystreamWriter()
        {
            FileStream fs = new FileStream("C:\\demo\\mydirectory\\mystreamfile.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(fs);
            s.WriteLine("Hello c#");
            s.Close();
            fs.Close();
        }

        public static void MystreamReader()
        {
            FileStream fs = new FileStream("C:\\demo\\mydirectory\\mystreamfile.txt", FileMode.OpenOrCreate);
            StreamReader r = new StreamReader(fs);
            string line = r.ReadLine();
            Console.WriteLine(line);
            r.Close();
            fs.Close();

        }
    }
}

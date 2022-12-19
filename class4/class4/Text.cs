using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class Text
    {
        public static void MyTextWriter()
        {
           // FileStream fs = new FileStream("C:\\demo\\FileIOFolder\\myTextfile.txt", FileMode.OpenOrCreate);
            using(TextWriter tw=File.CreateText("C:\\demo\\FileIOFolder\\myTextfile.txt"))
            {
                tw.WriteLine("Hello c#");
                tw.WriteLine("This is a abstract text class");
            }
            Console.WriteLine("File created");
        }
        public static void MyTextReader()
        {
            using (TextReader tr = File.OpenText("C:\\demo\\FileIOFolder\\myTextfile.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }



        }
    }
}

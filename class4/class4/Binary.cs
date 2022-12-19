using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class Binary
    {
        public static void MyBinaryWriter()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("C:\\demo\\FileIOFolder\\mybinary.txt", FileMode.OpenOrCreate)))
            {
               bw.Write(12.2345);
                bw.Write("This is a string");
               bw.Write(true);
               bw.Write(10);
            }
            Console.WriteLine("File created successfully");
        }
        public static void MyBinaryReader()
        {
            using(BinaryReader br=new BinaryReader(File.Open("C:\\demo\\FileIOFolder\\mybinary.txt",FileMode.OpenOrCreate)))
            {
               
               Console.WriteLine("Double value:" + br.ReadDouble());
                Console.WriteLine("Boolean value:" + br.ReadBoolean());
               Console.WriteLine("Integer value:" + br.ReadUInt16());
                Console.WriteLine("String value:" + br.ReadString());

            }
        }
    }
}

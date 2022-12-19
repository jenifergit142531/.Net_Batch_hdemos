using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3
{
    internal class ByteFileIO
    {
        public static void writeByte()
        {
            FileStream fs = new FileStream("C:\\demo\\FileIOFolder\\Mybytefile.txt", FileMode.OpenOrCreate);
            {
                for(int i =65;i<=90;i++)
                {
                    fs.WriteByte((byte)i);
                }
                fs.Close();
            }
        }
        public static void readByte()
        {
            FileStream fs = new FileStream("C:\\demo\\FileIOFolder\\Mybytefile.txt", FileMode.OpenOrCreate);
            int i = 0;
            while((i=fs.ReadByte())!=-1)
            {
                Console.WriteLine((char)i);
            }
            fs.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4
{
    internal class StringBuilderApp
    {
        
        public static void MyBuilderWrite()
        {
            string text = "Hello,This is writer and reader using stringbuilder class";
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            sw.WriteLine(text);
            sw.Close();
       
            StringReader sr = new StringReader(sb.ToString());
            while(sr.Peek()>-1)
            {
                Console.WriteLine(sr.ReadLine());
            }

        }
    }
}

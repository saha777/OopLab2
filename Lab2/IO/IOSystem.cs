using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.IO
{
    public class IOSystem
    {
        public static void Clear()
        {
            Console.Clear();
        }

        public static void Write(StringBuilder builder)
        {
            Console.WriteLine(builder.ToString());
        }

        public static int Read()
        {
            return Int32.Parse(Console.ReadLine());
        }
    }
}

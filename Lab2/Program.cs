using Lab2.State;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program!");
            Context context = new Context();
            context.Run();
            Console.WriteLine("End program!");
        }
    }
}

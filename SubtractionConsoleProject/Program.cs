using System;
using SubtractionProject;

namespace SubtractionConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            int y = Convert.ToInt32(args[1]);

            Console.WriteLine(SubtractClass.Subtract(x, y));
        }
    }
}

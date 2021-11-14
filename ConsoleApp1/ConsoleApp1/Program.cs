using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            OperatingSystem os = System.Environment.OSVersion;
            Console.WriteLine("Platform: {0}", os.Platform);
            System.Console.WriteLine("The current date and time is " + System.DateTime.Now);
            System.Console.ReadLine();

            // Task 2
            Console.WriteLine("Input value for variable x.");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fx = " + (Math.Cos(1.5 * x) - Math.Exp(Math.Sin(x + (5/3))) + Math.Sqrt(x + (7/6))));

        }
    }
}

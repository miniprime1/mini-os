using System;
using Sys = Cosmos.System;

namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Welcome to miniOS 1.0");
            Console.WriteLine("miniOS booted successfully.");
        }

        protected override void Run()
        {
        begin:
            Console.WriteLine("\nProgram List");
            Console.WriteLine("1. Hello World");
            Console.WriteLine("2. Calculator");
            Console.WriteLine("3. Echo Program");
            Console.Write("Enter program number: ");
            var num = Console.ReadLine();

            Console.WriteLine("");

            if (num == "1")
            {
                Console.WriteLine("Hello, World!");

                Console.Write("\nPress any key to exit ");
                Console.ReadKey();
                goto begin;
            }
            else if (num == "2")
            {
                Console.Write("Enter 1st input: ");
                var xs = Console.ReadLine();
                var x = double.Parse(xs);
                Console.Write("Enter 2nd input: ");
                var ys = Console.ReadLine();
                var y = double.Parse(ys);

                Console.WriteLine("\nResult");
                Console.WriteLine($"Addition: {x} + {y} = {x + y}");
                Console.WriteLine($"Subtractionn: {x} - {y} = {x - y}");
                Console.WriteLine($"Multiplication: {x} * {y} = {x * y}");
                Console.WriteLine($"Division: {x} / {y} = {x / y}");

                Console.Write("\nPress any key to exit ");
                Console.ReadKey();
                goto begin;
            }
            else if (num == "3")
            {
                Console.Write("Input: ");
                var text = Console.ReadLine();
                Console.WriteLine($"Typed text: {text}");

                Console.Write("\nPress any key to exit ");
                Console.ReadKey();
                goto begin;
            }
            else
            {
                Console.WriteLine("Error: invalid choice");

                Console.Write("\nPress any key to exit ");
                Console.ReadKey();
                goto begin;
            }
        }
    }
}

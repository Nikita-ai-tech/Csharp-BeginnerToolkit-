using System;

namespace BeginnerToolkit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Beginner’s C# Toolkit!");

            if (args.Length > 0)
            {
                switch (args[0].ToLower())
                {
                    case "--demo":
                        RunDemo();
                        break;

                    case "--test":
                        RunTest();
                        break;

                    case "--prod":
                        RunProduction();
                        break;

                    default:
                        Console.WriteLine("Unknown mode. Use --demo, --test, or --prod.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No mode specified. Defaulting to demo.");
                RunDemo();
            }
        }

        static void RunDemo()
        {
            int[] numbers = { 5, 10, 15 };
            double avg = Toolkit.CalculateAverage(numbers);
            Console.WriteLine($"[Demo] Average of [5,10,15] = {avg}");

            string reversed = Toolkit.ReverseString("hello");
            Console.WriteLine($"[Demo] Reversed 'hello' = {reversed}");
        }

        static void RunTest()
        {
            ToolkitTests.RunTests();
        }

        static void RunProduction()
        {
            Console.WriteLine("[Production] Toolkit is running in production mode.");
            // Add production‑ready logic here later
        }
    }
}

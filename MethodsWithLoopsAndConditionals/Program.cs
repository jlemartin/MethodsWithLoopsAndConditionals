using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luke Warm 1
            var instructions = "Write a method that will print to the console all numbers 1000 through -1000:";
            Console.WriteLine(instructions);
            Console.WriteLine();
            // Countdown();

            // Luke Warm 2
            instructions = "Write a method that will print to the console numbers 3 through 999 by 3 each time:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            // ByThrees();

            // Luke Warm 3
            instructions = "Write a method to accept two integers as parameters and check whether they are equal or not:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            //Console.WriteLine("Enter first number for comparison:");
            //var int1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number for comparison:");
            //var int2 = Convert.ToInt32(Console.ReadLine());
            //EqualOrNot(int1, int2);

            // Luke Warm 4
            instructions = "Write a method to check whether a given number is even or odd:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("Enter number for odd / even check:");
            var check1 = Convert.ToInt32(Console.ReadLine());
            OddEvenCheck(check1);


        }

        // Write a method that will print to the console all numbers 1000 through -1000.
        public static void Countdown()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void ByThrees()
        {
            var num3 = 3;

            while (num3 <= 999)
            {
                Console.WriteLine(num3);
                num3 += 3;
            } 
        }

        // Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void EqualOrNot(int first, int second)
        {
            if (first == second)
            {
                Console.WriteLine($"{first} and {second} are equal.");
            }
            else
            {
                Console.WriteLine($"{first} and {second} are NOT equal.");
            }
        }

        // Write a method to check whether a given number is even or odd
        public static void OddEvenCheck(int checkIt)
        {
            var modNum = checkIt % 2;
            if (modNum == 0)
            {
                Console.WriteLine($"{checkIt} is an EVEN number.");
            }
            else
            {
                Console.WriteLine($"{checkIt} is an ODD number.");
            }
        }

        // 
    }
}

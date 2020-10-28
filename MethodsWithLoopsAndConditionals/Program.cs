using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luke Warm 1
            // Write a method that will print to the console all numbers 1000 through -1000.
            // Countdown();

            // Luke Warm 2
            // Write a method that will print to the console numbers 3 through 999 by 3 each time.
            ByThrees();


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
    }
}

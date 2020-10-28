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
            Countdown();

            Console.WriteLine("----------------");
            // Luke Warm 2
            instructions = "Write a method that will print to the console numbers 3 through 999 by 3 each time:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            ByThrees();

            Console.WriteLine("----------------");
            // Luke Warm 3
            instructions = "Write a method to accept two integers as parameters and check whether they are equal or not:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("Enter first number for comparison:");
            var int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number for comparison:");
            var int2 = Convert.ToInt32(Console.ReadLine());
            EqualOrNot(int1, int2);

            Console.WriteLine("----------------");
            // Luke Warm 4
            instructions = "Write a method to check whether a given number is even or odd:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("Enter number for odd / even check:");
            var check1 = Convert.ToInt32(Console.ReadLine());
            OddEvenCheck(check1);

            Console.WriteLine("----------------");
            // Luke Warm 5
            instructions = "Write a method to check whether a given number is positive or negative:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("Enter number to see if it is positive or negative:");
            var checkPosNeg = Convert.ToInt32(Console.ReadLine());
            PosNegCheck(checkPosNeg);

            Console.WriteLine("----------------");
            // Luke Warm 6
            instructions = "Write a method to read the age of a candidate and determine whether they can vote:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("Are you eligible to vote? What is your age:");
            var yourAge = Int32.Parse(Console.ReadLine());
            VotingCheck(yourAge);

            Console.WriteLine("----------------");
            //Heating Up 1
            instructions = "Write a method to check if an integer (from the user) is in the range -10 to 10:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("Please enter an integer for the range check:");
            var rangeNum = Convert.ToInt32(Console.ReadLine());
            RangeCheck(rangeNum);

            Console.WriteLine("----------------");
            // Heating Up 2
            instructions = "Write a method to display the multiplication table (from 1 to 12) of a given integer:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("Times table for what number:");
            var timesInt = Convert.ToInt32(Console.ReadLine());
            TimesTable(timesInt);

            Console.WriteLine("----------------");
            // Heating Up 3
            instructions = "Write a method that takes a number from the user and returns an array with that many indexes. The values shall be random numbers.";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("How many in the array?");
            var arrayInt = Convert.ToInt32(Console.ReadLine());
            var anArray = RandomArray(arrayInt);
            // Displaying the array
            //for (int i = 0; i < anArray.Length; i++)
            //{
            //    Console.WriteLine(anArray[i]);
            //}

            Console.WriteLine("----------------");
            // Heating Up 4
            instructions = "Write a method to compute the sum of all the elements in an array of integers:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            var sumNum = ArraySum(anArray);
            Console.WriteLine("---------------");
            Console.WriteLine($"The sum of elements in the array is {sumNum}.");

            Console.WriteLine("----------------");
            // Heating Up 5
            instructions = "Write a method to display the cube of the number up to a given integer:";
            Console.WriteLine();
            Console.WriteLine(instructions);
            Console.WriteLine();
            Console.WriteLine("Please enter an integer for the cube display:");
            var cubeNum = Convert.ToInt32(Console.ReadLine());
            CubeDisplay(cubeNum);


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

        // Write a method to check whether a given number is positive or negative
        public static void PosNegCheck(int checkThis)
        {
            if (checkThis < 0)
            {
                Console.WriteLine($"{checkThis} is a NEGATIVE number.");
            }
            else
            {
                Console.WriteLine($"{checkThis} is a POSITIVE number.");
            }
        }

        // Write a method to read the age of a candidate and determine whether they can vote
        public static void VotingCheck(int votingAge)
        {
            if (votingAge >= 18)
            {
                Console.WriteLine($"Yes, at {votingAge} you are old enough to vote.");
            }
            else
            {
                Console.WriteLine($"Nope, you can't vote when you are {votingAge} years old.");
            }
        }

        // Write a method to check if an integer (from the user) is in the range -10 to 10
        public static void RangeCheck(int thatNum)
        {
            if (thatNum >= -10 && thatNum <= 10)
            {
                Console.WriteLine($"{thatNum} is within the -10 to 10 range.");
            }
            else
            {
                Console.WriteLine($"{thatNum} is outside the -10 to 10 range.");
            }
        }

        // Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void TimesTable(int numX)
        {
            for (int i = 1; i <= 12; i++)
            {
                var prodNum = i * numX;
                Console.WriteLine($"{numX} x {i} = {prodNum}");
            }
        }

        // Write a method that takes a number from the user and returns an array with that many indexes.
        // The values shall be random numbers.
        public static int[] RandomArray(int numA)
        {
            var newArray = new int[numA];
            var randomGen = new Random();

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = randomGen.Next(1, 100);
            }

            return newArray;
        }

        // Write a method to compute the sum of all the elements in an array of integers
        public static int ArraySum(int[] theArray)
        {
            var theSum = 0;

            for (int i = 0; i < theArray.Length; i++)
            {
                theSum += theArray[i];
            }

            return theSum;
        }

        // Write a method to display the cube of the number up to given an integer
        // (If a user inputs the number 3 the method should print to the console:
        // Number is: 1 and the cube of 1 is:1, Number is: 2 and the cube of 2 is: 8,
        // Number is: 3 and the cube of 3 is:27)
        public static void CubeDisplay(int int3)
        {
            var cubed = 0;

            for (int i = 1; i <= int3; i++)
            {
                cubed = i * i * i;
                Console.WriteLine($"Number is: {i} and the cube is {cubed}");
            }
        }
    }
}

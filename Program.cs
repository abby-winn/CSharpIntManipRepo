using System;
namespace ConsoleTest
{
    class Program
    {
        static void display()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");

            Console.WriteLine("To display the whole list of input please type 1");
            Console.WriteLine("To display every even number please type 2");
            Console.WriteLine("To display every odd number please type 3");
            Console.WriteLine("To display every 5th number please type 4");
            Console.WriteLine("To display the sum of the integers please type 5");
            Console.WriteLine("To display every number divisible by 3 please type 6");
            Console.WriteLine("To quit please type 7");
        }

        static void one(int[] integers)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
            }
        }


        static void two(int[] integers)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    Console.WriteLine(integers[i]);
                }
            }

        }

        static void three(int[] integers)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 != 0)
                {
                    Console.WriteLine(integers[i]);
                }
            }
        }


        static void four(int[] integers)
        {
            if (integers.Length < 5)
            {
                for (int i = 4; i < integers.Length; i += 5)
                {
                    Console.WriteLine(integers[i]);
                }
            }

        }

        static void five(int[] integers)
        {

            int sum = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                sum += integers[i];
            }

            Console.WriteLine(sum);

        }

        static void six(int[] integers)
        {

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 3 == 0)
                {
                    Console.WriteLine(integers[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many intergers do you want?");
            int intTemp = Convert.ToInt32(Console.ReadLine());

            int[] integers = new int[intTemp];

            for (int i = 0; i < intTemp; i++)
            {
                Console.WriteLine("Please type an integer.");
                int intTemp2 = Convert.ToInt32(Console.ReadLine());
                integers[i] = intTemp2;
            }

            int userInput = 0;

            while (userInput != 7)
            {
                Console.WriteLine("");
                display();
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    one(integers);
                }

                else if (userInput == 2)
                {
                    two(integers);
                }

                else if (userInput == 3)
                {
                    three(integers);
                }

                else if (userInput == 4)
                {
                    four(integers);
                }

                else if (userInput == 5)
                {
                    five(integers);
                }

                else if (userInput == 6)
                {
                    six(integers);
                }

                else
                {
                    Console.WriteLine("Invalid Response: Here are your options.");
                }
                Console.WriteLine("");
            }
        }
    }
}



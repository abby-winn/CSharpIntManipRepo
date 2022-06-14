using System;
namespace ConsoleTest
{
    class Program
    {
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

            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
            }

        }

        static void five(int[] integers){

            int sum = 0;

            for (int i = 0; i < integers.Length; i++){
                sum += integers[i];
            }

            Console.WriteLine(sum);

        }

        static void six(int[] integers){

            for (int i = 0; i < integers.Length; i++){
                if (integers[i] % 3 == 0){
                    Console.WriteLine(integers[i]);
                }
            }

        }

    }
}



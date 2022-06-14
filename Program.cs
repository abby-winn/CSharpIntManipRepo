// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleTest {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("How many intergers do you want?");
            int desiredNum = Console.ReadLine();

            int[] integers = new int[desiredNum];

            for(int i = 0; i < desiredNum; i++){
                Console.WriteLine("Please type an integer.");
                int desiredInt = Console.ReadLine();
                integers[i] == desiredInt;
            }


        }
    }
}



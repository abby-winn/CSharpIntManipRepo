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

        static void three(int[] tempList){
            for(int i = 0; i<tempList.length; i++){
                if(tempList[i]%2 != 0){
                    Console.WriteLine(integers[i]);
                }
            }
        }

        static void four(int[] tempList){
            if(tempList.length<5){
                for(int i = 4; i<tempList.length; i+=5){
                    Console.WriteLine(integers[i]);
            }        
                }
            
        }
    }
}



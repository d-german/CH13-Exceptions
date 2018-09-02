﻿using System;

namespace Lab03
{
    class Program
    {
        private static void Main(string[] args)
        {
            var continueLoop = true; // determines whether to keep looping

            do
            {
                Console.Write("Enter a value for miles: ");
                if (!double.TryParse(Console.ReadLine(), out var miles))
                {
                    Console.WriteLine("You must enter two integers. Please try again.\n");
                    continue;
                }

                Console.Write("Enter a value for gallons: ");
                if (!double.TryParse(Console.ReadLine(), out var gallons))
                {
                    Console.WriteLine("You must enter two integers. Please try again.\n");
                    continue;
                }

                var mpg = new MilesPerGallon {Miles = miles, Gallons = gallons}.Mpg;

              
               // var result = miles / gallons;

                // display result                                         
                Console.WriteLine(
                    $"\nResult: {miles} / {gallons} = {mpg} mpg");
                continueLoop = false;
            } while (continueLoop);
        }
    }
}

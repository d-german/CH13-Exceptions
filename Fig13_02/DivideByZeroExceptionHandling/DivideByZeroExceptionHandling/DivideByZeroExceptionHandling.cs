// Fig. 13.2: DivideByZeroExceptionHandling.cs
// FormatException and DivideByZeroException handlers.

using System;

internal class DivideByZeroExceptionHandling
{
    private static void Main(string[] args)
    {
        var continueLoop = true; // determines whether to keep looping

        do
        {
            Console.Write("Enter an integer numerator: ");
            if (!int.TryParse(Console.ReadLine(), out var numerator))
            {
                Console.WriteLine("You must enter two integers. Please try again.\n");
                continue;
            }

            Console.Write("Enter an integer denominator: ");
            if (!int.TryParse(Console.ReadLine(), out var denominator))
            {
                Console.WriteLine("You must enter two integers. Please try again.\n");
                continue;
            }

            if (denominator == 0)
            {
                Console.WriteLine("Zero is an invalid denominator. Please try again.\n");
                continue;
            }
                                  
            var result = numerator / denominator;

            // display result                                         
            Console.WriteLine(
                $"\nResult: {numerator} / {denominator} = {result}");
            continueLoop = false;
        } while (continueLoop);
    }
}


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/
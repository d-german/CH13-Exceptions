using System;


internal class Program
{
    private static void Main(string[] args)
    {
        bool continueLoop; // determines whether to keep looping

        do
        {
            Console.Write("Enter an integer: ");

            var success = int.TryParse(Console.ReadLine(), out var result);
            var message = success ? $"You entered {result}" : "Please try again.";

            Console.WriteLine(message);
            continueLoop = !success;
        } while (continueLoop);
    }
}

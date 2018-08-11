using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string s1 = null;
        var s2 = s1 ?? "nothing"; // s2 evaluates to "nothing"

        StringBuilder sb = null;
        var s = sb?.ToString().ToUpper() ?? "nothing"; // s evaluates to "nothing"

        StringBuilder sb2 = new StringBuilder("Hello World");
        int? length = s?.Length;

        if (length.HasValue)
        {
            Console.WriteLine(length.Value);
        }
        Console.WriteLine(length.GetValueOrDefault());
    }
}
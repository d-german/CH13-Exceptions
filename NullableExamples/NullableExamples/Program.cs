using System.Text;

namespace NullableExamples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s1 = null;
            var s2 = s1 ?? "nothing"; // s2 evaluates to "nothing"

            StringBuilder sb = null;
            var s = sb?.ToString().ToUpper() ?? "nothing"; // No error; s instead evaluates to "nothing"
        }
    }
}
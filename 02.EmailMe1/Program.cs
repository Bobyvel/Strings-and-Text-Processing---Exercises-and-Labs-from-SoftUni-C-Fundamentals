using System;
using System.Linq;

namespace _02.EmailMe1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = Console.ReadLine().Split('@');

            var sumBefore = mail[0].Select(c => (int) c).Sum();
            var sumAfter = mail[1].Select(c => (int) c).Sum();

            var result = (sumBefore - sumAfter) >= 0 ? "Call her!" : "She is not the one.";

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;

namespace _09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                var borderLeftIndex = input.IndexOf(pattern);
                var borderRightIndex = input.LastIndexOf(pattern);

                if (borderLeftIndex != -1 && borderRightIndex != -1)
                {
                    Console.WriteLine("Shaked it.");
                    input = input.Remove(borderRightIndex, pattern.Length);
                    input = input.Remove(borderLeftIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}

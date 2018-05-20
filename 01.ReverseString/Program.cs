using System;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine().ToCharArray();
            var reversed = string.Empty;
            for (int i = input.Length -1; i >= 0; i--)
            {
               reversed += input[i];
            }

            Console.WriteLine(reversed);
            Console.WriteLine();

            //different way
            for (int i = 0; i < input.Length/2; i++)
            {
                var firstLetter = input[i];
                var lastLetter = input[input.Length - 1 - i];

                input[i] = lastLetter;
                input[input.Length - 1 - i] = firstLetter;
            }

            Console.WriteLine(input);

            //another way back
            Array.Reverse(input);
            Console.WriteLine(input);
        }
    }
}

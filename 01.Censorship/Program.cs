using System;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var input = Console.ReadLine();


            input = input.Replace(word, new string('*', word.Length));

            Console.WriteLine(input);

        }
    }
}

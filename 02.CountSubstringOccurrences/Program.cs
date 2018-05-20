using System;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var substring = Console.ReadLine();
            var text = input.ToLower();
            var searchedText = substring.ToLower();

            var counter = 0;
            var index = -1;

            while (true)
            {
                index = text.IndexOf(searchedText, index + 1);
                if (index != -1)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);

        }
    }
}

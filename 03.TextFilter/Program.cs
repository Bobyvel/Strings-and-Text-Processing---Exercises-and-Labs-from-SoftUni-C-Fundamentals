using System;
using System.Linq;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                input = input.Replace(word, new string(word.Select(w => '*').ToArray()));
            }

            Console.WriteLine(input);
        }
    }
}

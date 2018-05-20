using System;
using System.Linq;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = Console.ReadLine();

            while (true)
            {
                var input = Console.ReadLine().Split();
                var hideoutChar = char.Parse(input[0]);
                var countOfChars = int.Parse(input[1]);

                var pattern = new string(hideoutChar, countOfChars);

                var indexFound = map.IndexOf(pattern, 0);
               
                if (indexFound != -1)
                {
                    var size = map.Substring(indexFound).TakeWhile(x => x == hideoutChar).Count();

                    Console.WriteLine($"Hideout found at index {indexFound} and it is with size {size}!");
                    return;
                }
            }
        }
    }
}

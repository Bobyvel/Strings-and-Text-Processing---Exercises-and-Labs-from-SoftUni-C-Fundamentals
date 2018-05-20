using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', '!', '?', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var palindromes = new List<string>();

            foreach (var word in input)
            {
                var currentWord = new string(word.Reverse().ToArray());

                if (currentWord.Equals(word))
                {
                    palindromes.Add(word);
                }

            }


            
            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(w => w)));


            
        }
    }
}

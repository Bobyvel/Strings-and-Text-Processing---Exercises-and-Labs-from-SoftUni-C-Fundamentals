using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[]{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            var total = 0d;
            for (int i = 0; i < input.Length; i++)
            {
                var word = input[i];
                var number = double.Parse(word.Substring(1, word.Length - 2));

                var letterBefore = word[0];
                number = char.IsUpper(letterBefore) ? number / DefinePosition(letterBefore) : number * DefinePosition(letterBefore);
               
                var letterAfter = word[word.Length - 1];
                number = char.IsUpper(letterAfter) ? number - DefinePosition(letterAfter) : number + DefinePosition(letterAfter);

                total += number;
            }

            Console.WriteLine($"{total:F2}");
        }

        private static int DefinePosition(char letter)
        {
            var position = 0;
            if (char.IsUpper(letter))
            {
               position = letter - 64;

            }
            else if (char.IsLower(letter))
            {
                position = letter - 96;
            }

            return position;
        }
    }
}

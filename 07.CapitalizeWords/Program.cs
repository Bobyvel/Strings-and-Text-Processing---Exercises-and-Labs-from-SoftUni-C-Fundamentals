using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
           
            while (input != "end")
            {
                var tolkens = input.Split(new [] { ' ', '.', ',', ':', ';', '?', '!', '-', '_' },
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tolkens.Length; i++)
                {
                    var word = tolkens[i].ToLower();
                    var firstLetter = word[0].ToString().ToUpper();

                    tolkens[i] = firstLetter + word.Substring(1);
                }
                
                Console.WriteLine(string.Join(", ", tolkens));

                input = Console.ReadLine();

               
            }

            

        }
    }
}

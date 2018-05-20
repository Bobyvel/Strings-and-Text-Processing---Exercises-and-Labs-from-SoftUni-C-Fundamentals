using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var firstWord = input[0];
            var secondWord = input[1];
            var map = new Dictionary<char, char>();
            var shorterWord = firstWord.Length >= secondWord.Length ? secondWord : firstWord;
            var longerWord = firstWord.Length >= secondWord.Length ? firstWord : secondWord;

           
            var isMagic = IsExchangable(longerWord, shorterWord, map);
             if (isMagic && (shorterWord.Length != longerWord.Length))
            {
                var restOftheWord = longerWord.Substring(shorterWord.Length);
                
                foreach (var letter in restOftheWord)
                {   
                    isMagic = !map.ContainsKey(letter) ? false : true;
                }
            }

            var result = isMagic ? "true" : "false";
            Console.WriteLine(result);


        }

        private static bool IsExchangable(string longerWord, string shorterWord, Dictionary<char, char> map)
        {
            
            for (int i = 0; i < Math.Min(longerWord.Length, shorterWord.Length); i++)
            {
                if (!map.ContainsKey(longerWord[i]) && !map.ContainsValue(shorterWord[i]))
                {
                    map[longerWord[i]] = shorterWord[i];
                }
                else
                {
                    if (map[longerWord[i]] != shorterWord[i])
                    {
                        return  false;
                    }
                }
            }
            return  true;
        }
    }
}

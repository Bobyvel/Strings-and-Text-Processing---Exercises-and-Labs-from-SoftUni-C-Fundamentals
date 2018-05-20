using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var passedLetters = string.Empty;
            var result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var letter = input[i];

                if (!passedLetters.Contains(letter))
                {

                    result.Append(letter + ":");
                    var index = 0;
                    for (int j = 0; j < input.Length; j++)
                    {
                        index = input.IndexOf(letter, index);
                        if (index == -1)
                        {
                            break;
                        }

                        result.Append(index + "/");
                        index++;
                    }

                    Console.WriteLine(result.Remove(result.Length-1, 1));
                    result.Clear();
                    passedLetters += letter;
                }
                
            }
            
        }
    }
}

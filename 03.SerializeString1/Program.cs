using System;
using System.Collections.Generic;
using System.Text;

namespace _03.SerializeString1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var lastCharacter = new List<char>();
            var result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                var character = input[i];

                if (!lastCharacter.Contains(character))
                {

                    result.Append(character + ":");

                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] == character)
                        {
                            result.Append(j + "/");
                        }

                    }

                    Console.WriteLine(result.Remove(result.Length-1, 1));
                    result.Clear();
                }

                lastCharacter.Add(character);
            }


        }
    }
}

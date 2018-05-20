using System;
using System.Text;

namespace _05.OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new StringBuilder();
            var replaceCounter = 0;
            var number = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
               
                if (!char.IsDigit(input[i]))
                {
                    result.Append(input[i]);

                    if (replaceCounter == 1)
                    {
                        result.Append(input[i]);
                        replaceCounter = 0;
                        number = String.Empty;
                    }
                }
                else 
                {
                  
                    replaceCounter = 1;
                    number += input[i];

                    if (i == input.Length-1)
                    {
                        result.Append(number);
                    }

                }
            }

            Console.WriteLine(result);

        }
    }
}

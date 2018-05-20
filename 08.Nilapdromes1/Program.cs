using System;
using System.Text.RegularExpressions;

namespace _08.Nilapdromes1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            

            while (input != "end")
            {
                var leftBorder = string.Empty;
                var rightBorder = string.Empty;
                var border = string.Empty;
                for (int i = 0; i < input.Length/2; i++)
                {
                   leftBorder += input[i];
                   rightBorder = input[input.Length -1 - i] + rightBorder;

                    if (leftBorder == rightBorder)
                    {
                        border = leftBorder;
                    }
                }

                if (border.Length > 0)
                {
                    var middle = input.Substring(border.Length, input.Length - (border.Length * 2));
                    Console.WriteLine($"{middle}{border}{middle}");
                }
                

                input = Console.ReadLine();
            }
        }
    }
}

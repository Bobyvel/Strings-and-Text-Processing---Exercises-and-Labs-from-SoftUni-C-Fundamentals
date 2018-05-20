using System;
using System.Text;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                 result += "\\u" + ((int)input[i]).ToString("x4");
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Numerics;

namespace _01.ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var baseN = int.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);

            var result = string.Empty;
            while (number > 0)
            {
                var reminder = number % baseN;
                result = reminder.ToString() + result;
                number = number / baseN;
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Numerics;

namespace _02.ConvertFromBase_N_ToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var baseN = int.Parse(input[0]);
            var number = input[1];

            BigInteger result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                var currentNumber = int.Parse(number[i].ToString());
                result += currentNumber * BigInteger.Pow(baseN, number.Length - 1 - i);
            }

            Console.WriteLine(result);
        }
    }
}

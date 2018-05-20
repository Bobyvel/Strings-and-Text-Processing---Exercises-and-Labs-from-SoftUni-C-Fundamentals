using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigNumbersAsStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = Console.ReadLine().TrimStart('0');
            var numberTwo = Console.ReadLine().TrimStart('0');

            if (numberOne.Length != numberTwo.Length)
            {
                var maxLenth = Math.Max(numberOne.Length, numberTwo.Length);
                numberOne = numberOne.PadLeft(maxLenth + 1, '0');
                numberTwo = numberTwo.PadLeft(maxLenth + 1, '0');
            }

            var totalSum = new StringBuilder();
            var reminder = 0;
            for (int i = 0; i < numberOne.Length; i++)
            {
                var currentSum = int.Parse(numberOne[numberOne.Length - 1 - i].ToString()) +
                                 int.Parse(numberTwo[numberTwo.Length - 1 - i].ToString()) + reminder;
           
                totalSum.Insert(0, (currentSum % 10).ToString());

                reminder = currentSum > 9 ? 1 : 0;


            }

            totalSum = totalSum[0] == '0' ? totalSum.Remove(0, 1) : totalSum;

            Console.WriteLine(totalSum);


        }
    }
}

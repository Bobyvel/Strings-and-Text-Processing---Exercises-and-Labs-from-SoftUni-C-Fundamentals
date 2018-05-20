using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MultiplyBigNumberAsString
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            var multiplier = byte.Parse(Console.ReadLine());

            if (number == "0" || multiplier == 0 || number == string.Empty)
            {
                Console.WriteLine(0);
                return;
            }
            
            number = number.PadLeft(number.Length + 1, '0');

            var result = new StringBuilder();
            var reminder = 0;
            for (int i = number.Length -1; i >= 0 ; i--)
            {
                var currentResult = int.Parse(number[i].ToString()) * multiplier + reminder;
                result.Insert(0, currentResult % 10);

                reminder = currentResult > 9 ? currentResult / 10 : 0;
            }

            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}

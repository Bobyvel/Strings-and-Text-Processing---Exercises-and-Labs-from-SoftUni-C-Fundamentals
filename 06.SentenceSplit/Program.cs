using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SentenceSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var delimeter = Console.ReadLine();

            var result = input.Replace(delimeter, ", ");

            Console.WriteLine($"[{result}]");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.DeserializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new StringBuilder();
            while (input != "end")
            {
                var letter = input[0].ToString();
                var indexes = input.Split(new string[] {":", "/"}, StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(int.Parse).ToArray();
                var capacity = indexes.Max() + 1;
                result.Append(new string(' ', capacity));
                for (int i = 0; i < indexes.Length; i++)
                {
                   
                    var index = indexes[i];
                    result.Replace(" ", letter, index, 1);
                }
                

                input = Console.ReadLine(); 
            }

            Console.WriteLine(result);
        }
    }
}

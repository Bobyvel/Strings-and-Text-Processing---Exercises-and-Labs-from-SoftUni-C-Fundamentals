using System;
using System.Text;

namespace _03.KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var streight = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    var nextIndex = i + 1;
                    streight += int.Parse(input[nextIndex].ToString());
                    while (nextIndex < input.Length && streight > 0)
                    {
                        if (input[nextIndex] == '>')
                        {
                            break;
                        }

                        input = input.Remove(nextIndex, 1);
                        streight--;
                    }
                }
            }

            Console.WriteLine(input);


            //diff way
            var input1 = Console.ReadLine();
            var streight1 = 0;
            var result = new StringBuilder();
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] == '>')
                {
                    streight1 += int.Parse(input1[i + 1].ToString());
                }
                else if (streight1 > 0)
                {
                    streight1--;
                    continue;
                }

                result.Append(input1[i]);
            }

            Console.WriteLine(result);
        }
    }
}


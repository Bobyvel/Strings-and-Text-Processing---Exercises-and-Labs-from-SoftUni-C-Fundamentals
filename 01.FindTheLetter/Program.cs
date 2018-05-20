using System;
using System.Linq;

namespace _01.FindTheLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var arr = Console.ReadLine().Split().ToArray();

            var letter = char.Parse(arr[0]);
            var occurance = int.Parse(arr[1]);
            var counter1 = 0;

            //first way
            var text = input.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    counter1++;
                    if (counter1 == occurance)
                    {
                        Console.WriteLine(i);
                        //return;
                        break;
                    }
                }
            }

            if (counter1 != occurance)// needed if not return
            {
                Console.WriteLine("Find the letter yourself!");
            }

            


            //second way
            var counter2 = 0;
            var startIndex = 0;
            while (true)
            {
                var index = input.IndexOf(letter, startIndex + 1);
                if (index != -1)
                {
                    counter2++;

                    if (counter2 == occurance)
                    {
                        Console.WriteLine(index);
                        //return;
                        break;
                    }
                }

                startIndex = index;

                if (startIndex == -1 && counter2 > 0)
                {
                    break;
                }
                
            }
            if (counter1 != occurance) // needed if not return
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}

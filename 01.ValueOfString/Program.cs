using System;

namespace _01.ValueOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var lettersCase = Console.ReadLine();
            var sum = 0;
           
                for (int i = 0; i < input.Length; i++)
                {
                    if (lettersCase == "UPPERCASE")
                    {
                        if (input[i] > 64 && input[i] < 91)
                        {
                            sum += input[i];
                        }
                    }
                    else if(lettersCase == "LOWERCASE")
                    {
                        if (input[i] > 96 && input[i] < 123)
                        {
                            sum += input[i];
                        }
                    }
                }

            Console.WriteLine($"The total sum is: {sum}");
            
        }
    }
}

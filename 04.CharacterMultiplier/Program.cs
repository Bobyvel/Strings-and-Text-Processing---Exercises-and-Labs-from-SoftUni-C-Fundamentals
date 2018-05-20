using System;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            
            var firstWord = input[0].Length >= input[1].Length ? input[0] : input[1]; //longer one
            var secondWord = input[0].Length >= input[1].Length ? input[1] : input[0];
            var sum = 0;
            for (int i = 0; i < secondWord.Length; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }
            if (firstWord.Length > secondWord.Length)
            {
                var diff = firstWord.Length - secondWord.Length;
                for (int i = 0; i < diff; i++)
                {
                    sum += firstWord[firstWord.Length - 1 - i];
                }

            }
            Console.WriteLine(sum);
        }
    }
}

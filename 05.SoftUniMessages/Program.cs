using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.SoftUniMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            
            while ((input = Console.ReadLine()) != "Decrypt!")
            {
                var messageLenth = int.Parse(Console.ReadLine());

                var validMessage = Regex.Match(input, 
                    $@"^(?<numBefore>\d+)(?<message>[A-Za-z]{{{messageLenth}}})(?<symbolsAfter>[^A-Za-z\s]+)$");

                if (!validMessage.Success)
                {
                    continue;
                }
                
                var indexes = validMessage.Groups["numBefore"].Value;
                
                foreach (var digit in validMessage.Groups["symbolsAfter"].Value.ToCharArray())
                {
                    if (char.IsDigit(digit))
                    {
                        indexes += digit;
                    }
                }
                    

                var result = new StringBuilder();
                var massage = validMessage.Groups["message"].Value;
                for (int i = 0; i < indexes.Length; i++)
                {
                    var atIndex = int.Parse(indexes[i].ToString());
                    
                    if ( atIndex < messageLenth)
                    {
                        result.Append(massage[atIndex].ToString());
                    }
                }

                Console.WriteLine($"{massage} = {result}");
                result.Clear();

            }

        }
    }
}

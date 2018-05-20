using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace _05.StringCommander
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            

            while (true)
            {
                var command = Console.ReadLine().Split();
                switch (command[0])
                {
                   case "end" :
                       Console.WriteLine(input);
                       return;
                   case "Left":
                       var count = int.Parse(command[1]);
                      input = RotateLeft(input, count);
                       break;
                   case "Right":
                       count = int.Parse(command[1]);
                       input = RotateRight(input, count);
                       break;
                   case "Insert":
                       var index = int.Parse(command[1]);
                       var newString = command[2];
                       input = input.Insert(index, newString);
                       break;
                   case "Delete":
                       var startIndex = int.Parse(command[1]);
                       var endIndex = int.Parse(command[2]);
                       input = input.Remove(startIndex, endIndex -startIndex + 1);
                       break;
                }
                
            }
        }

        private static string RotateRight(string input, int count)
        {
            var rotate = count % input.Length;
            return input.Substring(input.Length - rotate, rotate) + input.Substring(0, input.Length - rotate) ;
             
        }
        private static string RotateLeft(string input, int count)
        {
            var rotate = count % input.Length;
            return input.Substring(rotate, input.Length - rotate) + input.Substring(0, rotate);
             
        }
    }
}

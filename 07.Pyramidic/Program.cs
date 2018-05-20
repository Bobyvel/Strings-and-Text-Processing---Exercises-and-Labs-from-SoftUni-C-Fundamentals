 using System;
 using System.Collections.Generic;
 using System.Linq;

namespace _07.Pyramidic
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var linesList = new string [lines];
            var result = new List<string>();
            
            for (int i = 0; i < lines; i++)
            {
                linesList[i] = Console.ReadLine();
            }

            for (int i = 0; i < linesList.Length; i++)
            {
                var currentLine = linesList[i];
                for (int j = 0; j < currentLine.Length; j++)
                {
                    var currentLetter = currentLine[j];
                    var layer = 3;
                    var currentPiramide = currentLetter + Environment.NewLine;
                    for (int k = i+1; k < linesList.Length; k++)
                    {
                        var nextLine = linesList[k];
                        var piramidSymbol = new string(currentLetter, layer);
                        if (nextLine.Contains(piramidSymbol))
                        {
                          layer +=2;
                          currentPiramide += piramidSymbol + Environment.NewLine;

                        }
                        else
                        {
                            break;
                        }
                        
                    }
                    result.Add(currentPiramide);
                }
            }

            Console.WriteLine(result.OrderByDescending(r => r.Length).FirstOrDefault());
        }
    }
}
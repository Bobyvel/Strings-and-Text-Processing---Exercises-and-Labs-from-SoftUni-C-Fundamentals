using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.GroceryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var products = new Dictionary<string, double>();

            while ((input = Console.ReadLine()) != "bill")
            {
                var productMatch = Regex.Match(input, @"^(?<name>[A-Z][a-z]+)\:(?<price>\d+\.\d{2})$");
                if (!productMatch.Success)
                {
                   continue; 
                }
                
                products[productMatch.Groups["name"].Value] = double.Parse(productMatch.Groups["price"].Value);
            }

            foreach (var product in products.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"{product.Key} costs {product.Value:F2}");
            }
        }
    }
}

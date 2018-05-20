using System;

namespace _06.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "collapse")
            {
                var fiction = Console.ReadLine();

                while (fiction.Length != 0)
                {
                    var index = input.IndexOf(fiction);
                    while (index != -1)
                    {
                        input = input.Remove(index, fiction.Length);
                        index = input.IndexOf(fiction);
                    }
                    

                    fiction = fiction.Remove(0, 1);
                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length-1, 1);
                    }
                }

                if (input.Length > 0)
                {
                    Console.WriteLine(input);
                }
                else
                {
                    Console.WriteLine("(void)");
                }


                input = Console.ReadLine();
            }
        }
    }
}

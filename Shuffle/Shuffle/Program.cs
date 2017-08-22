using System;
using System.Collections.Generic;
using System.Linq;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringValues = new string[] { "Batman", "Darkseid", "Flash", "Harley Quinn", "Joker", "Superman", "Wonder Woman" };
            var intValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(string.Join(", ", stringValues.Shuffle()));
            Console.WriteLine(string.Join(", ", stringValues.Shuffle()));

            Console.WriteLine(string.Join(", ", intValues.Shuffle()));
            Console.WriteLine(string.Join(", ", intValues.Shuffle()));

            Console.ReadLine();
        }
    }
}

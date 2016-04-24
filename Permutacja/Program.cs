using System;
using System.Collections.Generic;

namespace Permutacja
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var timer = DateTime.Now;

            var setOfElements = new List<string> { "a", "x", "c" };

            var engine = new Permutations();
            var result = engine.GetPermutationsList(10, setOfElements);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Liczba iteracji: " + Memory.Count);
            Console.WriteLine("Liczba elementów: " + result.Count);
            var diff = DateTime.Now - timer;
            Console.WriteLine("Czas działania: " + diff.TotalMilliseconds + "ms");

            Console.ReadKey();
        }
    }
}
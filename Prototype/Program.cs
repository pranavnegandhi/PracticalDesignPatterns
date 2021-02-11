using System;

namespace Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var original = new Document();
            var cloneA = original.Clone();
            var cloneB = cloneA.Clone();

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Clone A: {cloneA}");
            Console.WriteLine($"Clone B: {cloneB}");
        }
    }
}
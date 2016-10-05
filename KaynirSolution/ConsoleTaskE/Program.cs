using System;
using System.Linq;

namespace ConsoleTaskE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] amount = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] carts = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int droids = Math.Abs(carts.Where(x => x < amount[1]).Select(x => (x - amount[1])).Sum());
            int bumbums = carts.Where(x => x > amount[1]).Select(x => (x - amount[1])).Sum();
            Console.WriteLine($"{bumbums} {droids}");
        }
    }
}

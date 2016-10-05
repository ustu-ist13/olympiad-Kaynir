using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTaskC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            var cells = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                mass[i] = Convert.ToInt32(cells[i]);
            }
            List<int[]> massList = new List<int[]>();
            for (int j = 0; j < mass.Length - 2; j++)
            {
                massList.Add(new int[] { mass[j], mass[j + 1], mass[j + 2] });
            }
            var powers = massList.Select(x => new { sum = x.Sum(), index = massList.IndexOf(x) + 2 });
            var maxPower = powers.FirstOrDefault(x => x.sum == powers.Select(y => y.sum).Max());
            Console.Write($"{maxPower.sum} {maxPower.index}");
            Console.ReadKey();
        }
    }
}

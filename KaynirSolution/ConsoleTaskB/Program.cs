using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleTaskB
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int row = Convert.ToInt16(Regex.Replace(inp, @"[^\d]+", ""));
            string seat = Regex.Replace(inp, @"[^\D]+", "");
            if (row <= 2)
            {
                string[] window = { "A", "D"};
                if (window.Contains(seat)) Console.WriteLine("window");
                else Console.WriteLine("aisle");
            }
            else if(row >= 3 && row <= 20)
            {
                string[] window = { "A", "F" };
                string[] aisle = { "B", "C", "D", "E" };
                if (window.Contains(seat)) Console.WriteLine("window");
                else if (aisle.Contains(seat)) Console.WriteLine("aisle");
                else Console.WriteLine("neither");
            }
            else if (row >= 21)
            {
                string[] window = { "A", "K" };
                string[] aisle = { "C", "D", "G", "H" };
                if (window.Contains(seat)) Console.WriteLine("window");
                else if (aisle.Contains(seat)) Console.WriteLine("aisle");
                else Console.WriteLine("neither");
            }
            Console.ReadLine();
        }
    }
}

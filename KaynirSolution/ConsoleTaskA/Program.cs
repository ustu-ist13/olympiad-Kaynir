using System;

namespace ConsoleTaskA
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = Convert.ToInt32(Console.ReadLine());
            if ((12 - f) * 45 < 240) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.ReadLine();     
        }
    }
}

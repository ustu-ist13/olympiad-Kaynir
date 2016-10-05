using System;

namespace ConsoleTaskD
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] answer = new string[t];
            for (int i = 1; i <= t; i++)
            {
                string[] test = Console.ReadLine().Split(' ');
                string type = test[3];
                int gun = int.Parse(test[6]);
                int cav = int.Parse(test[10]);
                int max = 0;
                int min = 0;
                min = (gun <= cav) ? cav - gun + 1 : 0;
                max = (gun <= cav) ? 30 - gun : 29 - gun;
                answer[i-1] = $"{min} {max}";
            }
            for (int i = 1; i <= t; i++)
            {
                Console.WriteLine(answer[i-1]);
            }
        }
    }
}

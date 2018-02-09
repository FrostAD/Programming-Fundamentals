using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int count = 0;
            bool found = false;
            int lastI = 0;
            int lastJ = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    if (i + j == magic)
                    {
                        lastI = i;
                        lastJ = j;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
            else
            {
                Console.WriteLine($"Number found! {lastI} + {lastJ} = {magic}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    if (count >= n)
                    {
                        Console.WriteLine($"Sum:{sum}");
                        return;
                    }
                    Console.WriteLine(i);
                    count++;
                    sum += n;
                }
            }
        }
    }
}

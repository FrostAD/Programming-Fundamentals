using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            bool equal = false;


            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    count++;
                    sum += (i * j) * 3;
                    if (sum >= max)
                    {
                        equal = true;
                        break;
                    }

                }
                if (sum >= max)
                {
                    break;
                }
            }

            if (equal)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }

        }
    }
}

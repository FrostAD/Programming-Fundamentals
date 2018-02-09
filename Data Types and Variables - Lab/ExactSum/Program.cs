using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 1; i <= nums; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}

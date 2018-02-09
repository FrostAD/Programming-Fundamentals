using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool special = false;
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                int num = i;
                while (num > 0)
                {
                    int digit = num % 10;
                    sum += digit;
                    num /= 10;

                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                    sum = 0;
                }
                else
                {
                    special = false;
                    sum = 0;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}

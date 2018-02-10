using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < (x-1)/2; i++)
            {
                Console.WriteLine($"{new string(' ', i)}x{new string(' ', (x - 2)- 2 * i)}x{new string(' ', i)}");
                
            }

            Console.WriteLine($"{new string(' ',(x - 1)/ 2)}x{new string(' ', (x - 1 )/ 2)}");

            for (int i = (x - 2)/ 2; i >= 0; i--)
            {
                Console.WriteLine($"{new string(' ', i)}x{new string(' ', (x - 2) - 2 * i)}x{new string(' ', i)}");
            }
        }
    }
}

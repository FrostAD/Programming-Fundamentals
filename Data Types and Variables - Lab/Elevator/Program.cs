using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal people = decimal.Parse(Console.ReadLine());
            decimal capacity = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(people/ capacity));
        }
    }
}

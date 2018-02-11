using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            decimal result = (width * height) / 1000000.0m;
            Console.WriteLine($"{width}x{height} => {Math.Round(result, 1)}MP");
        }
    }
}

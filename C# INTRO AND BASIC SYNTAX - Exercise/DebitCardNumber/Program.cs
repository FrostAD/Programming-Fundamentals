using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPart = int.Parse(Console.ReadLine());
            int secondPart = int.Parse(Console.ReadLine());
            int thirdPart = int.Parse(Console.ReadLine());
            int fourthPart = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstPart:d4} {secondPart:d4} {thirdPart:d4} {fourthPart:d4}");
        }
    }
}

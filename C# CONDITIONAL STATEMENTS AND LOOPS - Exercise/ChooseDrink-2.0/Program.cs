using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDrink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = 0m;
            decimal sum = 0;

            switch (profession)
            {
                case "Athlete":
                    price = 0.70m;
                    sum = quantity * price;
                    Console.WriteLine($"The Athlete has to pay {sum:f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1m;
                    sum = quantity * price;
                    Console.WriteLine($"The {profession} has to pay {sum:f2}.");
                    break;
                case "SoftUni Student":
                    price = 1.70m;
                    sum = quantity * price;
                    Console.WriteLine($"The SoftUni Student has to pay {sum:f2}.");
                    break;
                default:
                    price = 1.20m;
                    sum = quantity * price;
                    Console.WriteLine($"The {profession} has to pay {sum:f2}.");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomato = 150;
            int salami = 600;
            int pepper = 50;
            int total = 0;

            for (int i = 1; i <= count; i++)
            {
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "cheese":
                        total += 500;
                        break;
                    case "tomato sauce":
                        total += 150;
                        break;
                    case "salami":
                        total += 600;
                        break;
                    case "pepper":
                        total += 50;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {total}");
        }
    }
}

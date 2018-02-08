using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = string.Empty;
            int count = 0;
            while (product != "Bake!")
            {
                product = Console.ReadLine();
                if (product == "Bake!")
                {
                    break;
                }
                count++;
                Console.WriteLine($"Adding ingredient {product}.");
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}

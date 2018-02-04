using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabel
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            energyContent = (volume / 100) * energyContent;
            sugarContent = (volume / 100) * sugarContent;

            Console.WriteLine($"{volume:f0}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");

        }
    }
}

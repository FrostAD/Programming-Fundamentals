using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal discount = 0;
            int pricePackage = 0;
            int priceHall = 0;

            string hall = String.Empty;

            if (size >= 1 && size <= 50)
            {
                hall = "Small Hall";
                priceHall = 2500;
            } else if (size > 50 && size <= 100)
            {
                hall = "Terrace";
                priceHall = 5000;
            } else if (size > 100 && size <= 120)
            {
                hall = "Great Hall";
                priceHall = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "Normal":
                    discount = 0.05m;
                    pricePackage = 500;
                    break;
                case "Gold":
                    discount = 0.10m;
                    pricePackage = 750;
                    break;
                case "Platinum":
                    discount = 0.15m;
                    pricePackage = 1000;
                    break;
            }

            decimal totalPrice = priceHall + pricePackage;
            totalPrice = totalPrice - (totalPrice * discount);
            decimal pricePerPerson = totalPrice / size;
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

        }
    }
}

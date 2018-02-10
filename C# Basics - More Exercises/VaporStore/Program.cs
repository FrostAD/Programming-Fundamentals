using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            decimal price = 0m;
            decimal spent = 0m;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game Time")
                {
                    if (balance > 0)
                    {
                        Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance - spent:f2}");
                    }
                    else
                    {
                        Console.WriteLine("Out of money!");
                    }
                    
                    return;
                }

                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99m;
                        if (price > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }

                        balance -= 39.99m;
                        spent += 39.99m;
                        Console.WriteLine("Bought OutFall 4");
                        break;
                    case "CS: OG":
                        price = 15.99m;
                        if (price > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        balance -= 15.99m;
                        spent += 15.99m;
                        Console.WriteLine("Bought CS: OG");
                        break;
                    case "Zplinter Zell":
                        price = 19.99m;
                        if (price > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        balance -= 19.99m;
                        spent += 19.99m;
                        Console.WriteLine("Bought Zplinter Zell");
                        break;
                    case "Honored 2":
                        price = 59.99m;
                        if (price > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }

                        balance -= 59.99m;
                        spent += 59.99m;
                        Console.WriteLine("Bought Honored 2");
                        break;
                    case "RoverWatch":
                        price = 29.99m;
                        if (price > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        balance -= 29.99m;
                        spent += 29.99m;
                        Console.WriteLine("Bought RoverWatch");
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99m;
                        if (price > balance)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        spent += 39.99m;
                        balance -= 39.99m;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        break;
                        default:
                            Console.WriteLine("Not Found");
                            break;
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
        }
    }
}

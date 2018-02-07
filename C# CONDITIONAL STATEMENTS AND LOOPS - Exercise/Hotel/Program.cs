using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            decimal studioPrice = 0m;
            decimal doublePrice = 0m;
            decimal suitePrice = 0m;
            

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (nightCount > 7)
                    {
                        studioPrice = studioPrice - (studioPrice * 0.05m);
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if (nightCount > 14)
                    {
                        doublePrice = doublePrice - (doublePrice * 0.10m);
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nightCount > 14)
                    {
                        suitePrice = suitePrice - (suitePrice * 0.15m);
                    }
                    break;
            }

            decimal totalStudioPrice = studioPrice * nightCount;
            decimal totalDoublePrice = doublePrice * nightCount;
            decimal totalSuitePrice = suitePrice * nightCount;
            if (nightCount > 7 && (month == "September" || month == "October"))
            {
                totalStudioPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
        }
    }
}

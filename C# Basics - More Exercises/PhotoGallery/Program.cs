using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int bytes = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{number:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            if (bytes < 1000)
            {
                Console.WriteLine("Size: {0}B", bytes);
            }
            else if (bytes < 1000000)
            {
                bytes /= 1000;
                Console.WriteLine("Size: {0}KB", bytes);
            }
            else
            {
                bytes /= 1000000;
                Console.WriteLine("Size: {0}MB", bytes);
            }
            string orientation = String.Empty;
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}

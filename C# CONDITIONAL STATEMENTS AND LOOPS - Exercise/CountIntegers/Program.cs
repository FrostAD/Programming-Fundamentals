﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            try
            {
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(count);

            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallFibonacciNumbers.GenerateSmallFibonacciNumbers();

            LastNumeralFibonacciNumbers.GenerateLastNumeralFibonacciNumbers();

            Console.ReadKey();
        }
    }
}

﻿using System;

namespace String_interpolations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // Output information using formatting
            Console.WriteLine("This car is {0} {1} {2}, with miles {3} and cost ${4}", year, make, model, 
                miles, price);

            // Using string interpolation
            Console.WriteLine($"This car is {year} {make} {{{model}}}, with miles {miles} and cost {price:C2}");

            // With inline expressions
            Console.WriteLine($"This car is {year} {make} {model}, with KM {miles * 1.6:F2} and cost {price:C2}");

        }
    }
}
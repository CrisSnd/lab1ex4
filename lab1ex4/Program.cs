﻿using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i;

            Console.WriteLine("Introduceti numarul:" + "\n");
            i = double.Parse(Console.ReadLine());

            if (i > 0)
                {
                Console.WriteLine("\n"+"+");
                }
            else if (i<0)
                {
                Console.WriteLine("\n" + "-");
                }
            else 
            {
                Console.WriteLine("\n" + "0");
            }

        }
    }
}

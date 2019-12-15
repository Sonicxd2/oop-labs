﻿using System;

namespace Lab2
{
    public class Test
    {
        
        static void Main(string[] args)
        {
            var polynom = new Polynom(new double[] {0, 1, 2, 3});
            var polynom2 = new Polynom(new double[] {0, 1, 2, 3});
            polynom = polynom2 + polynom;
            Console.WriteLine(polynom.ToString());
        }
    }
}
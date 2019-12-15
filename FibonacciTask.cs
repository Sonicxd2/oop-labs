﻿using System;
using Lab1.exception;

namespace Lab1
{
    public class FibonacciTask
    {
        public void Run(string[] args)
        {
            if (args.Length > 0)
            {
                try
                {
                    ulong val = Convert.ToUInt64(args[0]);
                    if (val == 1)
                    {
                        Console.WriteLine(1);
                        return;
                    }

                    if (val == 2)
                    {
                        Console.WriteLine("1 1");
                        return;
                    }

                    Console.Write("1 1 ");
                    ulong preLast = 1;
                    ulong last = 1;
                    for (ulong i = 2; i < val; i++)
                    {
                        ulong temp = preLast + last;
                        Console.Write($" {temp}");
                        preLast = last;
                        last = temp;
                    }

                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    throw new IllegalStateException("Illegal format of argument", ex);
                }
            }
            else
            {
                throw new RuntimeException("Need argument to program.");
            }
        }
    }
}
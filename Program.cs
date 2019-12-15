﻿using System;

namespace Lab1
{
    class Program
    {
        delegate void Run(string[] args);

        private static Run[] subTasks =
        {
            new FileTask().Run,
            new FibonacciTask().Run,
            new RomanResolverTask().Run
        };

        static void Main(string[] args)
        {
            Console.WriteLine($"Select lab[1 - {subTasks.Length}]:");
            Console.WriteLine(); // making console beautiful O_O
            try
            {
                int selection = Convert.ToInt32(Console.ReadLine());
                subTasks[selection - 1].Invoke(args);
            }
            catch (Exception e)
            {
                ExceptionUtils.PrintStackTrace(e);
            }
        }
    }
}
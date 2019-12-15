﻿using System;
using System.Text.RegularExpressions;
using Lab1.exception;

namespace Lab1
{
    public class RomanResolverTask
    {
        public void Run(string[] args)
        {
            if (args.Length > 0)
            {
                args[0] = args[0].ToUpper();
                if (Regex.IsMatch(args[0], "^(?=[MDCLXVI])M*(C[MD]|D?C{0,3})(X[CL]|L?X{0,3})(I[XV]|V?I{0,3})$"))
                {
                    Console.WriteLine(RomanUtils.RomanToInteger(args[0]));
                }
                else
                {
                    throw new IllegalStateException("Number is not applicable.");
                }
            }
            else
            {
                throw new RuntimeException("Need argument to program.");
            }
        }
    }
}
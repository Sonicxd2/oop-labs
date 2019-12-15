﻿using System;
using System.Threading;

namespace Lab1
{
    public class ExceptionUtils
    {
        private ExceptionUtils()
        {
            throw new ApplicationException("Can't create allocate this class'");
        }

        public static void PrintStackTrace(Exception e)
        {
            Console.WriteLine("Exception in thread: " + Thread.CurrentThread.Name);
            Console.WriteLine(e.GetType() + ": " + e.Message);
            Console.WriteLine(e.StackTrace);
        }
    }
}
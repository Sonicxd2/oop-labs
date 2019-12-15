﻿using System;
using System.IO;
using Lab1.exception;

namespace Lab1
{
    class FileTask
    {
        public void Run(string[] args)
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                int counter = 0;
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    string[] splitted = line.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        foreach (string number in splitted)
                        {
                            counter += Convert.ToInt32(number);
                        }
                    }
                    catch (FormatException ex)
                    {
                        throw new IllegalStateException("Broken file", ex);
                    }

                    try
                    {
                        using (StreamWriter writer = new StreamWriter("output.txt"))
                        {
                            writer.WriteLine(Convert.ToString(counter));
                        }
                    }
                    catch (Exception e)
                    {
                        throw new RuntimeException("Output failed", e);
                    }
                }
            }
        }
    }
}
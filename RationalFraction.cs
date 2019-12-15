﻿namespace Lab2
{
    public class RationalFraction
    {
        int m;
        int n;

        public int M
        {
            get => m;
            set => m = value;
        }

        public int N
        {
            get => n;
            set => n = value;
        }

        public RationalFraction(int m, int n)
        {
            this.m = m;
            this.n = n;
        }

        public double ToDouble()
        {
            return (double) m / n;
        }
    }
}
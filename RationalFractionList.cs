﻿using System;
using System.Collections.Generic;

namespace Lab2
{
    public class RationalFractionList
    {
        private IList<RationalFraction> list = new List<RationalFraction>();

        private RationalFraction max;
        private RationalFraction min;


        public void Add(RationalFraction fraction)
        {
            list.Add(fraction);
            InvalidateByModify();
        }

        public void Remove(RationalFraction fraction)
        {
            list.Remove(fraction);
            InvalidateByModify();
        }

        public IList<RationalFraction> AsList()
        {
            return list;
        }

        public RationalFraction GetMax()
        {
            if (max == null)
            {
                double curr = Double.MinValue;
                foreach (var rational in list)
                {
                    if (rational.ToDouble() > curr)
                    {
                        max = rational;
                        curr = rational.ToDouble();
                    }
                }
            }

            return max;
        }

        public RationalFraction GetMin()
        {
            if (min == null)
            {
                double curr = Double.MaxValue;
                foreach (var rational in list)
                {
                    if (rational.ToDouble() < curr)
                    {
                        min = rational;
                        curr = rational.ToDouble();
                    }
                }
            }

            return min;
        }

        protected void InvalidateByModify()
        {
            min = null;
            max = null;
        }
    }
}
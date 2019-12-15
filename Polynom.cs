﻿using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Polynom
    {
        //final
        private readonly IList<Double> values;

        public Polynom(IList<double> values)
        {
            this.values = values;
        }

        public Polynom(double[] array)
        {
            this.values = new List<double>(array);
        }

        public Polynom(IList<RationalFraction> fractions)
        {
            var arr = new double[fractions.Count];
            int i = 0;
            foreach (var fraction in fractions)
            {
                arr[i++] = fraction.ToDouble();
            }
        }

        public Polynom(RationalFraction[] fractions)
        {
            var arr = new double[fractions.Length];
            int i = 0;
            foreach (var fraction in fractions)
            {
                arr[i++] = fraction.ToDouble();
            }
        }


        public static Polynom operator +(Polynom a, Polynom b)
        {
            double[] res = new double[Math.Max(a.values.Count, b.values.Count)];
            if (a.values.Count == b.values.Count)
            {
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = a.values[i] + b.values[i];
                }
            }
            else
            {
                Polynom max = a.values.Count > b.values.Count ? a : b;
                Polynom min = max == a ? b : a;
                int distance = Math.Abs(a.values.Count - b.values.Count);
                for (int i = 0; i < distance; i++)
                {
                    res[i] = max.values[i];
                }

                for (int i = distance; i < res.Length; i++)
                {
                    res[i] = max.values[i] + min.values[i - distance];
                }
            }

            return new Polynom(res);
        }

        public static Polynom operator -(Polynom a, Polynom b)
        {
            double[] reverted = new double[b.values.Count];
            for (int i = 0; i < b.values.Count; i++)
            {
                reverted[i] = -b.values[i];
            }

            return new Polynom(reverted);
        }

        protected bool Equals(Polynom other)
        {
            return Equals(values, other.values);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Polynom) obj);
        }

        public override string ToString()
        {
            return string.Join(",", values);
        }
    }
}
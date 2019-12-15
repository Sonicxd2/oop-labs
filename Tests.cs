﻿using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace Lab2
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }

        [Test]
        public void RationalFraction()
        {
            var fraction = new RationalFraction(1, 2);
            Assert.True(Math.Abs(fraction.ToDouble() - 0.5) < 1e-6);
            RationalFractionList list = new RationalFractionList();
            list.Add(fraction); list.Add(new RationalFraction(1, 3));
            Assert.True(Math.Abs(list.GetMax().ToDouble() - 0.5) < 1e-6);
            Assert.True(Math.Abs(list.GetMin().ToDouble() - 0.33333333333) < 1e-6);
        }
       
        
        [Test]
        public void Polynom()
        {
            var polynom = new Polynom(new double[]{0, 1, 2, 3});
            var polynom2 = new Polynom(new double[]{0, 1, 2, 3});
            polynom = polynom2 + polynom;
//            throw new Exception(polynom.ToString());
            Console.WriteLine(polynom.ToString());
            Assert.True(polynom.Equals(new Polynom(new double[]{0, 2, 4, 6})));
            polynom = polynom - polynom2;
            Assert.True(polynom.Equals(new Polynom(new double[]{0, 1, 2, 3})));
        }

    }
}
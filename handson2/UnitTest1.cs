//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using NUnit.Framework;

namespace handson2
{
    [TestFixture]
    public class UnitTest1
    {
    
        [TestCase(20,10,10)]
        [TestCase(10,20,-10)]
        [TestCase(10,10,0)]
        [TestCase(10,0,10)]
        public void Subtraction(double a,double b,double c)
        {
            SimpleCalculator sc = new SimpleCalculator();
            double result = sc.Subtraction(a, b);
            Assert.AreEqual(c, result);

        }
        [TestCase(20, 10, 200)]
        [TestCase(10, -20, -200)]
        [TestCase(-10, 20, -200)]
        [TestCase(10, 20, 200)]
        [TestCase(10, 0, 0)]
        [TestCase(0, 20, 0)]

        public void Multiplication(double a, double b, double c)
        {
            SimpleCalculator sc = new SimpleCalculator();
            double result = sc.Multiplication(a, b);
            Assert.AreEqual(c, result);

        }
        [TestCase(20, 10, 2)]
        [TestCase(10, 20, 0.5)]
        [TestCase(0, 20, 0)]
        public void Division(double a, double b, double c)
        {
            SimpleCalculator sc = new SimpleCalculator();
            double result = sc.Division(a, b);
            if (b == 0)
            {
                Assert.Fail("Division by 0");
            }
            Assert.AreEqual(c, result);
        }
    }
}

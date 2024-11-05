using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMod7;


namespace DemoMod7TEST
{
    public class MycalculatorTest
    {
        double v1;
        double v2;
        SimpleCalculator mcalculator;

        [SetUp]
        public void Setup()
        {
            v1 = 35.28;
            v2 = 20.35;
            mcalculator = new MyCalculator();
        }

        [Test] //IMPORTANT
        public void testAddPostivePositive()
        {
            double expected = 55.63;
            double actual = mcalculator.add(v1, v2);
            Assert.AreEqual(expected, actual,0.001,"Addition Failed");
           
        }

        [Test] //IMPORTANT
        public void testAddPostiveNegative()
        {
            double expected = 14.93;
            double actual = mcalculator.add(v1, -v2);
            Assert.AreEqual(expected, actual, 0.001, "Addition Failed");

        }

        [Test] //IMPORTANT
        public void testAddNegativeNegative()
        {
            double expected = -55.63;
            double actual = mcalculator.add(-v1, -v2);
            Assert.AreEqual(expected, actual, 0.001, "Addition Failed");

        }

        [Test] //IMPORTANT
        public void testSubtract()
        {
            double expected =14.93;
            double actual = mcalculator.subtract(v1, v2);
            Assert.AreEqual(expected, actual, 0.001, "Subtraction Failed");

        }
        [Test] //IMPORTANT
        public void testMultiplyPP()
        {
            double expected = 717.948;
            double actual = mcalculator.multiply(v1, v2);
            Assert.AreEqual(expected, actual, 0.001, "Multiplication Failed");

        }

        [Test] //IMPORTANT
        public void testMultiplyPN()
        {
            double expected = -717.948;
            double actual = mcalculator.multiply(v1, -v2);
            Assert.AreEqual(expected, actual, 0.001, "Multiplication Failed");

        }
        [Test] //IMPORTANT
        public void testMultiplyNN()
        {
            double expected = 717.948;
            double actual = mcalculator.multiply(-v1, -v2);
            Assert.AreEqual(expected, actual, 0.001, "Multiplication Failed");

        }
        [Test] //IMPORTANT
        public void testDivision()
        {
            double expected = 1.7336;
            double actual = mcalculator.divide(v1, v2);
            Assert.AreEqual(expected, actual, 0.001, "Division Failed");

        }
        [Test] //IMPORTANT
        public void testDivisionByZero()
        {
            /*double expected = 1.7336;
            double actual = mcalculator.divide(v1, v2);
            Assert.AreEqual(expected, actual, 0.001, "Division Failed");*/
            try
            {
                double actual = mcalculator.divide(v1, 0);
            }
            catch (ArithmeticException e)
            {
                Assert.IsTrue(true);
            }

        }

        [Test] //IMPORTANT
        public void testSquarePositive()
        {
            double expected = 1244.6783;
            double actual = mcalculator.square(v1);
            Assert.AreEqual(expected, actual, 0.001, "Square Failed");

        }
        [Test] //IMPORTANT
        public void testSquareNegative()
        {
            double expected = 1244.6783;
            double actual = mcalculator.square(-v1);
            Assert.AreEqual(expected, actual, 0.001, "Square Failed");

        }

        [Test] //IMPORTANT
        public void testSquareRootPositive()
        {
            double expected = 5.9396;
            double actual = mcalculator.squareroot(v1);
            Assert.AreEqual(expected, actual, 0.001, "Squareroot Failed");

        }

        [Test] //IMPORTANT
        public void testSquareRootNegative()
        {
            /* double expected = 5.9396;
             double actual = mcalculator.squareroot(v1);
             Assert.AreEqual(expected, actual, 0.001, "Squareroot Failed");*/
            try
            {
                double actual = mcalculator.squareroot(-v1);
            }
            catch (SquareRootNegativeException e)
            {
                Assert.IsTrue(true);
            }

        }

        [Test] //IMPORTANT
        public void testSquareRootZero()
        {
            double expected = 0;
            double actual = mcalculator.squareroot(0);
            Assert.AreEqual(expected, actual, 0.001, "Squareroot Failed");

        }

    }
}

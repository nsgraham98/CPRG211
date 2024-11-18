using Lab7;

namespace Lab7TEST
{
    public class Tests
    {
        double v1;
        double v2;
        BasicMath calc;

        [SetUp]
        public void Setup()
        {
            v1 = 2.5;
            v2 = 0.6;
            calc = new BasicMath();
        }

        [Test]
        public void TestAddMethod()
        {
            double expected = 3.1;
            double actual = calc.Add(v1, v2);
            Assert.AreEqual(expected, actual, 0.001, "Addition failed");
        }
        [Test]
        public void TestSubtractMethod()
        {
            double expected = 1.9;
            double actual = calc.Subtract(v1, v2);
            Assert.AreEqual(expected, actual, 0.001, "Subtraction Failed");
        }
        [Test]
        public void TestMultiplyMethod()
        {
            double expected = 1.5;
            double actual = calc.Multiply(v1, v2);
            Assert.AreEqual(expected, actual, 0.001, "Multiplication failed");
        }

        [Test]
        public void TestDivideMethod()
        {
            try
            {
                double expected = 4.16;
                double actual = calc.Divide(v1, v2);
                Assert.AreEqual(expected, actual, 0.01, "Division failed");
            }
            catch (ArithmeticException e) { }
        } 

    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalcMathTests
    {
        [TestMethod]
        public void TestCalcMathExist()
        {
            CalcMath calcMath = new CalcMath();
            Assert.IsNotNull(calcMath);
        }

        [TestMethod]
        public void TestAddition()
        {
            int expected = 5;
            int actual = CalcMath.Add(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSbutraction()
        {
            int expected = 5;
            int actual = CalcMath.Subtract(8, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivision()
        {
            int expected = 5;
            int actual = CalcMath.Divide(15, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            int expected = 15;
            int actual = CalcMath.Multiply(5, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestModulus()
        {
            int expected = 2;
            int actual = CalcMath.Modulus(5, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestCalculatorExist()
        {
            Calculator calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void TestCalculate()
        {
            int expected = 5;
            int actual = Calculator.calculate(2, 3, "+");
            Assert.AreEqual(expected, actual);
        }
    }
}

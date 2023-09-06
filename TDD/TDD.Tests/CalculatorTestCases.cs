using TDD.Logics.Contracts;
using TDD.Logics.Services;

namespace TDD.Tests
{
    [TestClass]
    public class CalculatorTestCases
    {
        private ICalculator _calculator = new CalculatorService();

        [TestMethod]
        public void Should_Add_Number()
        {
            int actual = _calculator.Add(5, 5);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Subtract_Number()
        {
            int actual = _calculator.Subtract(10, 5);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Should_Multiply_Number()
        {
            int actual = _calculator.Multiply(5, 5);
            int expected = 25;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Should_Divide_Number()
        {
            int actual = _calculator.Divide(10, 5);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Should_Throw_Error_For_Dividing_By_Zero()
        {
            int actual = _calculator.Divide(10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Divide_Zero_By_Zero_Return_Infinity()
        {
            int actual = _calculator.Divide(0, 0);
        }
    }
}
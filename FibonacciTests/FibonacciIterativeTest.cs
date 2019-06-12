using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Tests
{
    /// <summary>
    /// Имплементация на тест за UShortFibonacciIterative
    /// </summary>
    [TestClass]
    public class FibonacciIterativeTest : AFibonacciTest
    {
        /// <summary>
        /// Конструиране на UShortFibonacciIterative обекта.
        /// </summary>
        /// <param name="context">Тестов контекст</param>
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            FibonachiCalculator = new UShortFibonacciIterative();
        }
    }
}

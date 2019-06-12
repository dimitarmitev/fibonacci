using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Tests
{
    /// <summary>
    /// Имплементация на тест за MemoryFibonacci
    /// </summary>
    [TestClass]
    public class MemoryFibonacciTest : AFibonacciTest
    {
        /// <summary>
        /// Конструиране на MemoryFibonacci обекта.
        /// </summary>
        /// <param name="context">Тестов контекст</param>
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            FibonachiCalculator = new MemoryFibonacci();
        }
    }
}

using Fibonacci;
using Fibonacci.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciTests
{
    /// <summary>
    /// Имплементация на тест за MemoryFibonacciConcurent
    /// </summary>
    [TestClass]
    public class MemoryFibonacciConcurentTest: AFibonacciTest
    {
        /// <summary>
        /// Конструиране на MemoryFibonacciConcurent обекта.
        /// </summary>
        /// <param name="context">Тестов контекст</param>
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            FibonachiCalculator = new MemoryFibonacciConcurent();
        }
    }
}

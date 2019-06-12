using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
using System.Threading.Tasks;

namespace Fibonacci.Tests
{
    /// <summary>
    /// Тестове за демонстрация на проблемите при конкурентно извикване 
    /// на имплементация използваща запазване на резултати.
    /// </summary>
    [TestClass]
    public class FibonacciConcurentTest
    {
        /// <summary>
        /// Тестваме и очакваме възникване на изключение при решение
        /// не взимащо предвид конкурентни зивкивания. Поради това, че тестът 
        /// разчита на race condition - не винаги минава "успешно", т.е. се чупи.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AggregateException))]
        public void ConcurrentTestFail()
        {
            try
            {
                var fibonacci = new MemoryFibonacci();
                CalculateFibonacci(fibonacci);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw ex;
            }
        }
        
        /// <summary>
        /// Контролен тест на решение използващо заключване.
        /// </summary>
        [TestMethod]
        public void ConcurrentTest()
        {
            var fibonacci = new MemoryFibonacciConcurent();
            CalculateFibonacci(fibonacci);
        }

        /// <summary>
        /// Общ код споделян между двата теста
        /// </summary>
        /// <param name="fibonacci">Имплеменатция на калкулатор за търсене на n-ия член на редицата на Фибоначи</param>
        private static void CalculateFibonacci(IFibonacciCalculator<ushort> fibonacci)
        {
            Parallel.ForEach(
                new ushort[] {
                    300,
                    300,
                    300
                },
                a =>
                {
                    var result = fibonacci.CalculateNth(a);
                    Assert.AreEqual(result, BigInteger.Parse("222232244629420445529739893461909967206666939096499764990979600"));
                }
            );
        }
    }
}

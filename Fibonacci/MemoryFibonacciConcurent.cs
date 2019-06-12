using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci
{
    /// <summary>
    /// Имплементация на търсене на n-ти член на редицата на Фибоначи с използване на памет.
    /// Веднъж инициализиран, при последващи викания, пресмятането използва вече намерените
    /// членове на редицата.
    /// </summary>
    public class MemoryFibonacciConcurent : IFibonacciCalculator<ushort>
    {
        /// <summary>
        /// Намерени членове на редицата на Фибоначи
        /// </summary>
        List<BigInteger> fibonachiValues =
           new List<BigInteger>(
               new BigInteger[]
               {
                        new BigInteger(0),
                        new BigInteger(1)
               }
           );

        /// <inheritdoc />
        public BigInteger CalculateNth(ushort searchedMember)
        {
            // Заключваме колекцията, за да могат изчисленията да се извършват правилно.
            // Това се налага, тъй като при конкурентна работа е вероятно или да получим грешни
            // резултати, или да възникне изключение при работа с колекцията.
            lock (fibonachiValues)
            {
                while (fibonachiValues.Count <= searchedMember)
                {
                    int i = fibonachiValues.Count;
                    fibonachiValues.Add(fibonachiValues[i - 1] + fibonachiValues[i - 2]);
                }
            }
            return fibonachiValues[searchedMember];
        }
    }
}

using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci
{
    /// <summary>
    /// Имплементация на търсене на n-ти член на редицата на Фибоначи с използване на памет.
    /// Веднъж инициализиран, при последващи викания, пресмятането използва вече намерените
    /// членове на редицата.
    /// </summary>
    public class MemoryFibonacci : IFibonacciCalculator<ushort>
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
            while (fibonachiValues.Count <= searchedMember)
            {
                int i = fibonachiValues.Count;
                fibonachiValues.Add(fibonachiValues[i - 1] + fibonachiValues[i - 2]);
            }
            return fibonachiValues[searchedMember];
        }
    }
}

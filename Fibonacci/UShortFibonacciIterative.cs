using System.Numerics;

namespace Fibonacci
{
    /// <summary>
    /// Имплементация на итеративно търсене на n-ти член на редицата на Фибоначи.
    /// </summary>
    public class UShortFibonacciIterative : IFibonacciCalculator<ushort>
    {
        /// <inheritdoc />
        public BigInteger CalculateNth(ushort searchedMember)
        {
            BigInteger previous = 0;
            BigInteger current = 1;
            if (searchedMember == 0)
            {
                return previous;
            }
            if (searchedMember == 1)
            {
                return current;
            }
            // Тук можем да пресметнем ushort.MaxValue, тъй като 
            // индексът е int
            for (int i = 2; i <= searchedMember; i++)
            {
                BigInteger next = previous + current;
                previous = current;
                current = next;
            }
            return current;
        }
    }
}

using System;
using System.Numerics;

namespace Fibonacci
{
    /// <summary>
    /// Имплементация на итеративно търсене на n-ти член на редицата на Фибоначи.
    /// </summary>
    public class UIntFibonacciIterative : IFibonacciCalculator<uint>
    {
        /// <inheritdoc />
        public BigInteger CalculateNth(uint searchedMember)
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
            if (searchedMember == uint.MaxValue)
            {
                // Предизвикваме изключение за uint.MaxValue, тъй като неговото пресмятане 
                // ще доведе до превъртането на uint в цикъла по-долу. (Не че някой ще стигне до
                // това пресмятане...)
                throw new ApplicationException($"Calculation is limited to: {uint.MaxValue - 1}");
            }
            for (uint i = 2; i <= searchedMember; i++)
            {
                BigInteger next = previous + current;
                previous = current;
                current = next;
            }
            return current;
        }
    }
}

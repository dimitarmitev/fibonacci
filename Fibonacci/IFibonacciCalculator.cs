using System.Numerics;

namespace Fibonacci
{
    /// <summary>
    /// Интерфейс за пресмятане на n-ият член на редицата на Фибоначи
    /// </summary>
    /// <typeparam name="T">Тип на приеманите числа</typeparam>
    public interface IFibonacciCalculator<T>
        where T : struct
    {
        /// <summary>
        /// Пресмята n-ият член на редицата на фибоначи
        /// </summary>
        /// <param name="searchedMember">Номер на член, който търсим</param>
        /// <returns>Намереният резултат</returns>
        BigInteger CalculateNth(T searchedMember);
    }
}

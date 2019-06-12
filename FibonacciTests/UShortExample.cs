using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciTests
{
    /// <summary>
    /// Тест демонстриращ какво би се случило, ако използваме ushort за индекс в 
    /// for цикъл при гранични случаи
    /// </summary>
    [TestClass]
    public class UShortExample
    {
        [TestMethod]
        public void TestUShortOverflow()
        {
            ushort s = ushort.MaxValue;
            Assert.AreNotEqual(ushort.MaxValue + 1, s++);
        }
    }
}

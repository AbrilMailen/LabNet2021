using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods_Exceptions_UT.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Exceptions_UT.Extensions.Tests
{
    [TestClass()]
    public class IntegerExtensionsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorZeroTest()
        {
            //arrange
            int value = 10;
            //act
            value.DividirPorZero();
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirTest() {
            //arrange
            int val1 = 10;
            int val2 = 0;

            //act
            val1.Dividir(val2);

        }
        [TestMethod()]
        public void DividirTestOK()
        {
            //arrange
            int val1 = 10;
            int val2 = 10;

            //act
           decimal resultado= val1.Dividir(val2);
            //
            Assert.AreEqual( 1, resultado);
        }
    }
}
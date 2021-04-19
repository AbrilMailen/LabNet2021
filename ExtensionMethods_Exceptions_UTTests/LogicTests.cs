using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethods_Exceptions_UT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtensionMethods_Exceptions_UT.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Excepcion3Test()
        {
            Logic.Excepcion3();
        }

        [TestMethod()]
        [ExpectedException(typeof(CustomExceptions))]
        public void Excepcion4Test()
        {
            Logic.Excepcion4();
        }
    }
}
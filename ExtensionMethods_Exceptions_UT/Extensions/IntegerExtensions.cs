using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Exceptions_UT.Extensions
{
    public static class IntegerExtensions
    {
        public static int DividirPorZero(this int numero)
        {
            return numero / 0;
        }

        public static decimal Dividir(this int dividendo, int divisor)
        {
            return
                 (decimal)dividendo / (decimal)divisor;

        }
    }
}

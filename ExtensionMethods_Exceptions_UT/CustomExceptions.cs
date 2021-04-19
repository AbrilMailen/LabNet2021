using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Exceptions_UT
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions(string mensajePersonalizado) : base($"{mensajePersonalizado} CustomException.")
        {
        }
    }
}

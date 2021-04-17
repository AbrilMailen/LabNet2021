using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_POO_con_Interface
{
    interface ITransporte
    {
        int pasajeros { get; set; }

        string Avanzar();
        string Detenerse();
    }
}

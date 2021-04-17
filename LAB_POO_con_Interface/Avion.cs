using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB_POO_con_Interface
{
    public class Avion : ITransporte
    {
        public int pasajeros { get; set; }

        public Avion(int cantPasajeros) {
            pasajeros = cantPasajeros;
        }

        public string Avanzar()
        {
            return $"Volando con {pasajeros} pasajeros a bordo.";
        }

        public string Detenerse()
        {
            return $"Aterrizando sobre la pista.";
        }
    }
}

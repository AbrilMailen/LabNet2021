using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB_POO_con_Interface
{
    public class Automovil : ITransporte
    {

        public int pasajeros { get; set; }

        public Automovil(int cantPasajeros) {
            pasajeros = cantPasajeros;
        }
        public string Avanzar()
        {
            return $"Avanzando sobre ruedas con {pasajeros} pasajeros.";
        }

        public string Detenerse()
        {
            return $"Frenando.";
        }
    }
}
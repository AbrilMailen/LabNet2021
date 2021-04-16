using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO_LAB_Transporte
{
    public class Automovil : Transporte
    {
        public Automovil(int cantPasajeros) : base(cantPasajeros)
        {

        }

        public override string Avanzar()
        {
            return $"Avanzando sobre ruedas con {GetPasajeros()} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"Frenando.";
        }
    }
}
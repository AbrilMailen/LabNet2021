using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO_LAB_Transporte
{
    public class Avion : Transporte
    {
        public Avion(int cantPasajeros) : base(cantPasajeros)
        {
        }

        public override string Avanzar()
        {
            return $"Volando con {GetPasajeros()} pasajeros a bordo.";
        }

        public override string Detenerse()
        {
            return $"Aterrizando sobre la pista.";
        }
    }
}
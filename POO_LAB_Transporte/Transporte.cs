using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO_LAB_Transporte
{
    public abstract class Transporte
    {
       private int pasajeros { get; }

        public int GetPasajeros()
        {
            return pasajeros;
        }

        public Transporte (int cantPasajeros)
        {
            pasajeros = cantPasajeros;
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

    }
}
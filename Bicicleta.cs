using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class Bicicleta : Vehiculos
    {
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; } // ya definido
        }

        public Bicicleta(string codigo, int capacidadMaxima, string marca, string modelo, double costo, Estado estado, double precio) : base(codigo, capacidadMaxima, marca, modelo, estado)
        {

        }
    }
}

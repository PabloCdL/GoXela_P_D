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
            set { precio = value; }
        }

        public Bicicleta(string codigo, string marca, string modelo, Estado estado) : base(codigo, 10, marca, modelo, 5, estado)
        {
            Precio = 10;
        }
    }
}

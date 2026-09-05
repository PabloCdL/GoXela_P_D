using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class Documento : Paquete
    {
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int cantidadLimite;

        public int CantidadLimite
        {
            get { return cantidadLimite; }
            set { cantidadLimite = value; }
        }

        public Documento(string codigo, string descripcion, double peso, string direccionOrigen, string direccionDestino, EstadoPaquete estado)
            : base(codigo, descripcion, peso, direccionOrigen, direccionDestino, estado)
        {
            Precio = 5;
            CantidadLimite = 20;
        }
    }
}

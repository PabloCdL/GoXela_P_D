using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class PaqueteFragil : Paquete
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

        public PaqueteFragil(string codigo, string descripcion, double peso, double valorDeclarado, string direccionOrigen, string direccionDestino, EstadoPaquete estado)
            : base(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado)
        {
            Precio = 25;
            CantidadLimite = 5;

        }
    }
}

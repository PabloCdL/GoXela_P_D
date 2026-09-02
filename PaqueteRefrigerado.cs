using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class PaqueteRefrigerado : Paquete
    {
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; } // valor especifico
        }

        private int peso;

        public int Peso
        {
            get { return peso; }
            set { peso = value; } // valor especifico
        }

        private int cantidadLimite;

        public int CantidadLimite
        {
            get { return cantidadLimite; }
            set 
            {
                if(value < 0 || value > 5)
                {
                    Console.WriteLine($"Cantidad no permitida");
                }else
                {
                    cantidadLimite = value;
                }
            } // valor especifico
        }

        public PaqueteRefrigerado(string codigo, string descripcion, double peso, string direccionOri, string direccionDes, EstadoPaquete estado, int precio, int pase, int cantidadLimite)
            : base(codigo, descripcion, peso, direccionOri, direccionOri, estado)
        {

        }
    }
}

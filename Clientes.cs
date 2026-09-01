using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class Clientes : Persona
    {
        private int cantidadSolicitudes;

        public int CantidadSolicitudes
        {
            get { return cantidadSolicitudes; }
            set
            {
                if (value > 0 && value < 5)
                {
                    Console.WriteLine("Cantidad de solicitudes válida");
                    cantidadSolicitudes = value;
                }
                else
                {
                    Console.WriteLine("Cantidad de solicitudes inválida");
                }

        public Clientes(string codigo, string nombreCompleto, int numeroTelefonico, string direccion, string correo, int cantidadSolicitudes) : base(codigo, nombreCompleto, numeroTelefonico, direccion, correo)
        {
            CantidadSolicitudes = cantidadSolicitudes;
        }
    }
}

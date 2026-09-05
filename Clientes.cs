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
                if (value > 0 && value <= 5)
                {
                    cantidadSolicitudes = value;
                }
                else
                {
                    Console.WriteLine("Cantidad de solicitudes inválida");
                }
            }
        }
       
        public Clientes(string codigo, string nombreCompleto, string numeroTelefonico, string direccion, string correo, int cantidadSolicitudes) : base(codigo, nombreCompleto, numeroTelefonico, direccion, correo)
        {
            CantidadSolicitudes = cantidadSolicitudes;
        }

        public void MostrarInformacion()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"El codigo es: {Codigo}");
            Console.WriteLine($"El nombre es: {NombreCompleto}");
            Console.WriteLine($"El numero telefonico es: {NumeroTelefonico}");
            Console.WriteLine($"La direccion es: {Direccion}");
            Console.WriteLine($"El correo es: {Correo}");
            Console.WriteLine($"La cantidad de solicitudes es: {CantidadSolicitudes}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class Motocicleta : Vehiculos
    {
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; } // ya definido
        }

        private string placa;

        public string Placa
        {
            get { return placa; }
            set 
            {
                if (value.Length < 10 && value != null)
                {
                    Console.WriteLine("Placa válida");
                    placa = value;
                }
                else
                {
                    Console.WriteLine("Placa inválida");
                    placa = null;
                }
            }
        }

        public Motocicleta(string codigo, int capacidadMaxima, string marca, string modelo, double costo, Estado estado, double precio, string placa) : base(codigo, capacidadMaxima, marca, modelo, estado)
        {
            Placa = placa;
        }
    }
}

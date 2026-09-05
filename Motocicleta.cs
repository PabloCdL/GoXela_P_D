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
            set { precio = value; }
        }

        private string placa;

        public string Placa
        {
            get { return placa; }
            set 
            {
                if (value != null && value.Length <= 10)
                {
                    placa = value;
                }
                else
                {
                    Console.WriteLine("Placa inválida");
                }
            }
        }

        public Motocicleta(string codigo, string marca, string modelo, Estado estado, double precio, string placa) : base(codigo, 30, marca, modelo, 15, estado)
        {
            Precio = 25;
            Placa = placa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class Automovil : Vehiculos
    {
        
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

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Placa: {Placa}");
            Console.ResetColor();
        }


        public Automovil(string codigo, string marca, string modelo, Estado estado, double precio, string placa) : base(codigo, 80, marca, modelo, precio, estado)
        {
            Placa = placa;
        }
    }
}

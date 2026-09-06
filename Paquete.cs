using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    public enum EstadoPaquete
    {
        Admitido, EnCamino, Entregado
    }
    internal class Paquete
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 5)
                {
                    codigo = value;
                }
                else
                {
                    Console.WriteLine("Código inválido");
                }
            }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 50) 
                {
                    descripcion = value;
                }
                else
                {
                    Console.WriteLine("Descripción inválida");
                }
            }
        }

        private double peso;

        public double Peso
        {
            get { return peso; }
            set 
            {
                if (value >0)
                {
                    peso = value;
                }
                else
                {
                    Console.WriteLine("Peso inválido");
                }
            }
        }
        private double valorDeclarado;

        public double ValorDeclarado
        {
            get { return valorDeclarado; }
            set
            {
                if (value >= 0)
                {
                    valorDeclarado = value;
                }
                else
                {
                    Console.WriteLine("Valor declarado inválido");
                }
            }
        }
        private string direccionOrigen;

        public string DireccionOrigen
        {
            get { return direccionOrigen; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 50)
                {
                    direccionOrigen = value;
                }
                else
                {
                    Console.WriteLine("Dirección de origen inválida");
                }
            }
        }

        private string direccionDestino;

        public string DireccionDestino
        {
            get { return direccionDestino; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 50)
                {
                    direccionDestino = value;
                }
                else
                {
                    Console.WriteLine("Dirección de destino inválida");
                }
            }
        }

        private EstadoPaquete estado;

        public EstadoPaquete Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Paquete(string codigo, string descripcion, double peso, double valorDeclarado, string direccionOrigen, string direccionDestino, EstadoPaquete estado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Peso = peso;
            ValorDeclarado = valorDeclarado;
            DireccionOrigen = direccionOrigen;
            DireccionDestino = direccionDestino;
            Estado = estado;
        }
        public void MostrarInformacion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Valor Declarado: Q{ValorDeclarado}");
            Console.WriteLine($"Dirección Origen: {DireccionOrigen}");
            Console.WriteLine($"Dirección Destino: {DireccionDestino}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}

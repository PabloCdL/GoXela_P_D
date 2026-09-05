using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    public enum EstadoPaquete
    {
        admitido, encamino, entregado
    }
    internal class Paquete
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value != null && value.Length <= 5)
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
                if (value != null && value.Length <= 50) 
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

        private string direccionOrigen;

        public string DireccionOrigen
        {
            get { return direccionOrigen; }
            set 
            {
                if (value != null && value.Length <= 50)
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
                if (value != null && value.Length <= 50)
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

        public Paquete(string codigo, string descripcion, double peso, string direccionOrigen, string direccionDestino, EstadoPaquete estado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Peso = peso;
            DireccionOrigen = direccionOrigen;
            DireccionDestino = direccionDestino;
            Estado = estado;
        }
    }
}

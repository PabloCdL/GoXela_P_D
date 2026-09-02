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
                if (value.Length > 5 && value != null)
                {
                    Console.WriteLine("Código válido");
                    codigo = value;
                }
                else
                {
                    Console.WriteLine("Código inválido");
                    codigo = null;
                }
            }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (value.Length > 50 && value != null) 
                {
                    Console.WriteLine("Descripción válida");
                    descripcion = value;
                }
                else
                {
                    Console.WriteLine("Descripción inválida");
                    descripcion = null;
                }
            }
        }

        private double peso;

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        private string direccionOrigen;

        public string DireccionOrigen
        {
            get { return direccionOrigen; }
            set 
            {
                if (value.Length > 50 && value != null)
                {
                    Console.WriteLine("Dirección de origen válida");
                    direccionOrigen = value;
                }
                else
                {
                    Console.WriteLine("Dirección de origen inválida");
                    direccionOrigen = null; 
                }
            }
        }

        private string direccionDestino;

        public string DireccionDestino
        {
            get { return direccionDestino; }
            set 
            {
                if (value.Length > 50 && value != null)
                {
                    Console.WriteLine("Dirección de destino válida");
                    direccionDestino = value;
                }
                else
                {
                    Console.WriteLine("Dirección de destino inválida");
                    direccionDestino = null;
                }
            }
        }

        private EstadoPaquete estado;

        public EstadoPaquete Estado
        {
            get { return estado; }
            set
            {
                if (value != EstadoPaquete.admitido && value != EstadoPaquete.encamino && value != EstadoPaquete.entregado)
                {
                    Console.WriteLine("Estado inválido");
                    estado = 0;
                }
                else
                {
                    Console.WriteLine("Estado válido");
                    estado = value;
                }
            }
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

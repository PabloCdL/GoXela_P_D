using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    public enum EstadoPaquete
    {
        bueno, bonito , barato
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

        private string direccionOri;

        public string DireccionOri
        {
            get { return direccionOri; }
            set 
            {
                if (value.Length > 50 && value != null)
                {
                    Console.WriteLine("Dirección de origen válida");
                    direccionOri = value;
                }
                else
                {
                    Console.WriteLine("Dirección de origen inválida");
                    direccionOri = null; 
                }
            }
        }

        private string direccionDes;

        public string DireccionDes
        {
            get { return direccionDes; }
            set 
            {
                if (value.Length > 50 && value != null)
                {
                    Console.WriteLine("Dirección de destino válida");
                    direccionDes = value;
                }
                else
                {
                    Console.WriteLine("Dirección de destino inválida");
                    direccionDes = null;
                }
            }
        }

        private EstadoPaquete estado;

        public EstadoPaquete Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Paquete(string codigo, string descripcion, double peso, string direccionOri, string direccionDes, EstadoPaquete estado)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Peso = peso;
            DireccionOri = direccionOri;
            DireccionDes = direccionDes;
            Estado = estado;
        }
    }
}

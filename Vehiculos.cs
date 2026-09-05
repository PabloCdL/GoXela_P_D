using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    public enum Estado
    {
        Libre, Ocupado
    }
    internal class Vehiculos
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

        private int capacidadMaxima;

        public int CapacidadMaxima
        {
            get { return capacidadMaxima; }
            set 
            {
                if (value > 0)
                {
                    capacidadMaxima = value;
                }
                else
                {
                    Console.WriteLine("Capacidad máxima inválida");
                }
            }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set 
            {
                if (value != null && value.Length <= 10)
                {
                    marca = value;
                }
                else
                {
                    Console.WriteLine("Marca inválida");
                }
            }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set 
            {
                if (value != null && value.Length <= 10)
                {
                    modelo = value;
                }
                else
                {
                    Console.WriteLine("Modelo inválido");
                }
            }
        }

        private double costo;

        public double Costo
        {
            get { return costo; }
            set 
            {
                if (value >= 0)
                {
                    costo = value;
                }
                else
                {
                    Console.WriteLine("Costo inválido");
                }
            }
        }


        private Estado estado;

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Vehiculos(string codigo, int capacidadMaxima, string marca, string modelo, double costo,Estado estado)
        {
            Codigo = codigo;
            CapacidadMaxima = capacidadMaxima;
            Marca = marca;
            Modelo = modelo;
            Costo = costo;
            Estado = estado;
        }
    }
}

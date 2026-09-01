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
                if (value.Length < 5 && value != null)
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

        private int capacidadMaxima;

        public int CapacidadMaxima
        {
            get { return capacidadMaxima; }
            set { capacidadMaxima = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set 
            {
                if (value.Length < 10 && value != null) {
                    Console.WriteLine("Marca válida");
                    marca = value;
                }
                else
                {
                    Console.WriteLine("Marca inválida");
                    marca = null;
                }
            }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set 
            {
                if (value.Length < 10 && value != null)
                {
                    Console.WriteLine("Modelo válido");
                    modelo = value;
                }
                else
                {
                    Console.WriteLine("Modelo inválido");
                    modelo = null;
                }
            }
        }

        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }


        private Estado estado;

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Vehiculos(string codigo, int capacidadMaxima, string marca, string modelo, Estado estado)
        {
            Codigo = codigo;
            CapacidadMaxima = capacidadMaxima;
            Marca = marca;
            Modelo = modelo;
            Estado = estado;
        }
    }
}

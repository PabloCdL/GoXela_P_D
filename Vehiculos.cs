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
            set { codigo = value; }
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
            set { marca = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
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

        public Vehiculo(string codigo, int capacidadMaxima, string marca, string modelo, Estado estado)
        {
            Codigo = codigo;
            CapacidadMaxima = capacidadMaxima;
            Marca = marca;
            Modelo = modelo;
            Estado = estado;
        }
    }
}

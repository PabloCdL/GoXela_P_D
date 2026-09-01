using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    public enum EstadoPaquete
    {
        //estados
    }
    internal class Paquete
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
            set { direccionOri = value; }
        }

        private string direccionDes;

        public string DireccionDes
        {
            get { return direccionDes; }
            set { direccionDes = value; }
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

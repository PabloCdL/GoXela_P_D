using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class Persona
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        private int numeroTelefonico;

        public int NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public Persona(string codigo, string nombreCompleto, int numeroTelefonico, string direccion, string correo)
        {
            Codigo = codigo;
            NombreCompleto = nombreCompleto;
            NumeroTelefonico = numeroTelefonico;
            Direccion = direccion;
            Correo = correo;
        }
    }
}

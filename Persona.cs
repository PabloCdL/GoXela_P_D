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

        private string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set 
            {
                if (value != null && value.Length <= 50)
                {
                    nombreCompleto = value;
                }
                else
                {
                    Console.WriteLine("Nombre completo inválido");
                }
            }
        }

        private string numeroTelefonico;

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set 
            {
                if (value != null && value.Length == 8)
                {
                    numeroTelefonico = value;
                }
                else
                {
                    Console.WriteLine("Número telefónico inválido");
                }
            }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set 
            {
                if (value != null && value.Length <= 50)
                {
                    direccion = value;
                }
                else
                {
                    Console.WriteLine("Dirección inválida");
                }
            }
        }

        private string correo;

        public string Correo
        {
            get { return correo; }
            set 
            {
                if (value != null && value.Contains("@") && value.Length <= 50)
                {
                    correo = value;
                }
                else
                {
                    Console.WriteLine("Correo inválido");
                }
            }
        }

        public Persona(string codigo, string nombreCompleto, string numeroTelefonico, string direccion, string correo)
        {
            Codigo = codigo;
            NombreCompleto = nombreCompleto;
            NumeroTelefonico = numeroTelefonico;
            Direccion = direccion;
            Correo = correo;
        }
    }
}

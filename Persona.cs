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

        private string nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set 
            {
                if (value.Length < 50 && value != null)
                {
                    Console.WriteLine("Nombre completo válido");
                    nombreCompleto = value;
                }
                else
                {
                    Console.WriteLine("Nombre completo inválido");
                    nombreCompleto = null;
                }
            }
        }

        private string numeroTelefonico;

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set 
            {
                if (value.Length == 8 && value != null)
                {
                    Console.WriteLine("Número telefónico válido");
                    numeroTelefonico = value;
                }
                else
                {
                    Console.WriteLine("Número telefónico inválido");
                    numeroTelefonico = null;
                }
            }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set 
            {
                if (value.Length < 50 && value != null)
                {
                    Console.WriteLine("Dirección válida");
                    direccion = value;
                }
                else
                {
                    Console.WriteLine("Dirección inválida");
                    direccion = null;
                }
            }
        }

        private string correo;

        public string Correo
        {
            get { return correo; }
            set 
            {
                if (value.Contains("@") && value != null)
                {
                    Console.WriteLine("Correo válido");
                    correo = value;
                }
                else
                {
                    Console.WriteLine("Correo inválido");
                    correo = null;
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

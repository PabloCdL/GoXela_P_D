using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    public enum TipoLicencia
    {
        M, C, B, A
    }

    public enum Disponibilidad
    {
        Disponible, Nodisponible
    }
    internal class Repartidores : Persona
    {
        private TipoLicencia tipoLicencia;

        public TipoLicencia TipoLicencia
        {
            get { return tipoLicencia; }
            set
            {
                if (value != TipoLicencia.M && value != TipoLicencia.C && value != TipoLicencia.B && value != TipoLicencia.A)
                {
                    Console.WriteLine("Tipo de licencia inválido");
                    tipoLicencia = null;
                }
                else
                {
                    Console.WriteLine("Tipo de licencia válido");
                    tipoLicencia = value;
                }
            }
        }

        private Disponibilidad disponibilidad;

        public Disponibilidad Disponibilidad
        {
            get { return disponibilidad; }
            set
            {
                if (value != Disponibilidad.Disponible && value != Disponibilidad.Nodisponible)
                {
                    Console.WriteLine("Disponibilidad inválida");
                    disponibilidad = null;
                }
                else
                {
                    Console.WriteLine("Disponibilidad válida");
                    disponibilidad = value;
                }
            }
        }

        private int cantidadEntregas;

        public int CantidadEntregas
        {
            get { return cantidadEntregas; }
            set
            {
                if (value < 0 && value != 5)
                {
                    Console.WriteLine("Cantidad de entregas inválida");
                }
                else
                {
                    Console.WriteLine("Cantidad de entregas válida");
                    cantidadEntregas = value;
                }
            }
        }

        private int calificacion;

        public int Calificacion
        {
            get { return calificacion; }
            set
            {
                if (value < 0 && value != 5)
                {
                    Console.WriteLine("Cantidad de entregas inválida");
                }
                else
                {
                    Console.WriteLine("Cantidad de entregas válida");
                    cantidadEntregas = value;
                }
            }
        }

        public Repartidores(string codigo, string nombreCompleto, int numeroTelefonico, string direccion, string correo, TipoLicencia tipoLicencia, Disponibilidad disponibilidad, int cantidadEntregas, int calificacion)
            : base(codigo, nombreCompleto, numeroTelefonico, direccion, correo)
        {
            Disponibilidad = disponibilidad;
            CantidadEntregas = cantidadEntregas;
            Calificacion = calificacion;
            TipoLicencia = tipoLicencia;
        }
    }
}

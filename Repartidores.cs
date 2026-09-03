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
            set { tipoLicencia = value; }
        }

        private Disponibilidad disponibilidad;

        public Disponibilidad Disponibilidad
        {
            get { return disponibilidad; }
            set { disponibilidad = value; }
        }

        private int cantidadEntregas;

        public int CantidadEntregas
        {
            get { return cantidadEntregas; }
            set
            {
                if (value >= 0)
                {
                    cantidadEntregas = value;
                }
                else
                {
                    Console.WriteLine("Cantidad de entregas inválida");
                }
            }
        }

        private int calificacion;

        public int Calificacion
        {
            get { return calificacion; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    calificacion = value;
                }
                else
                {
                    Console.WriteLine("Cantidad de entregas inválida");
                }
            }
        }

        public Repartidores(string codigo, string nombreCompleto, string numeroTelefonico, string direccion, string correo, TipoLicencia tipoLicencia, Disponibilidad disponibilidad, int cantidadEntregas, int calificacion)
            : base(codigo, nombreCompleto, numeroTelefonico, direccion, correo)
        {
            Disponibilidad = disponibilidad;
            CantidadEntregas = cantidadEntregas;
            Calificacion = calificacion;
            TipoLicencia = tipoLicencia;
        }
    }
}

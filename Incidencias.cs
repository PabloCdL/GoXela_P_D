using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    public enum TipoIncidencia
    {
        ClienteAusente, DireccionIncorrecta, PaqueteDanado, VehiculoAveriado, Retraso, ProblemasClimaticos, RechazoRecepcion
    }

    public enum EstadoIncidencia
    {
        Pendiente, Resuelta
    }

    internal class Incidencias
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

        private TipoIncidencia tipo;

        public TipoIncidencia Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (value != null && value.Length <= 50)
                {
                    descripcion = value;
                }
                else
                {
                    Console.WriteLine("Descripción inválida");
                }
            }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                if (value <= DateTime.Today)
                {
                    fecha = value;
                }
                else
                {
                    Console.WriteLine("Fecha inválida");
                }
            }
        }

        private EstadoIncidencia estado;

        public EstadoIncidencia Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string accionTomada;

        public string AccionTomada
        {
            get { return accionTomada; }
            set
            {
                if (value != null && value.Length <= 50)
                {
                    accionTomada = value;
                }
                else
                {
                    Console.WriteLine("Acción inválida");
                }
            }
        }

        public Incidencias(string codigo, TipoIncidencia tipo, string descripcion, DateTime fecha, EstadoIncidencia estado, string accionTomada)
        {
            Codigo = codigo;
            Tipo = tipo;
            Descripcion = descripcion;
            Fecha = fecha;
            Estado = estado;
            AccionTomada = accionTomada;
        }
    }
}
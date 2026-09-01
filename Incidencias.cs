using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class Incidencias
    {
        class Incidencia
        {
            private string codigo;
            private string descripcion;
            private DateTime fecha;
            public string Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }
            public string Descripcion
            {
                get { return descripcion; }
                set { descripcion = value; }
            }
            public DateTime Fecha
            {
                get { return fecha; }
                set { fecha = value; }
            }
        }
    }
}

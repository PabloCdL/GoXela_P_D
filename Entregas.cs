using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    public enum TipoServicio
    {
        Normal, Prioritario, Urgente
    }

    public enum EstadoEntrega
    {
        Pendiente, EnProceso, Entregado, Cancelado
    }
    internal class Entregas
    {
        private Clientes cliente;

        public Clientes Cliente
        {
            get { return cliente; }
            set 
            {
                if (value != null)
                {
                    cliente = value;
                }
                else
                {
                    Console.WriteLine("Debe asignar un cliente");
                }
            }
        }

        private Paquete paquete;

        public Paquete Paquete
        {
            get { return paquete; }
            set 
            {
                if (value != null)
                {
                    paquete = value;
                }
                else
                {
                    Console.WriteLine("Debe asignar un paquete");
                }
            }
        }

        private Repartidores repartidor;

        public Repartidores Repartidor
        {
            get { return repartidor; }
            set 
            {
                if (value != null)
                {
                    repartidor = value;
                }
                else
                {
                    Console.WriteLine("Debe asignar un repartidor");
                }
            }
        }
        private Vehiculos vehiculo;

        public Vehiculos Vehiculo
        {
            get { return vehiculo; }
            set
            {
                if (value != null)
                {
                    vehiculo = value;
                }
                else
                {
                    Console.WriteLine("Debe asignar un vehículo");
                }
            }
        }
        private DateTime fechaSolicitud;

        public DateTime FechaSolicitud
        {
            get { return fechaSolicitud; }
            set
            {
                if (value <= DateTime.Now)
                {
                    fechaSolicitud = value;
                }
                else
                {
                    Console.WriteLine("Fecha de solicitud inválida");
                }
            }
        }
        private double distancia;

        public double Distancia
        {
            get { return distancia; }
            set
            {
                if (value > 0)
                {
                    distancia = value;
                }
                else
                {
                    Console.WriteLine("Distancia inválida");
                }
            }
        }
        private TipoServicio tipoServicio;

        public TipoServicio TipoServicio
        {
            get { return tipoServicio; }
            set { tipoServicio = value; }
        }
        private EstadoEntrega estado;

        public EstadoEntrega Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private int tarifaBase;

        public int TarifaBase
        {
            get { return tarifaBase; }
            set 
            {
                if (value >= 0)
                {
                    tarifaBase = value;
                }
                else
                {
                    Console.WriteLine("Tarifa inválida");
                }
            }
        }
        private double recargos;

        public double Recargos
        {
            get { return recargos; }
            set 
            {
                if (value >= 0)
                {
                    recargos = value;
                }
                else
                {
                    Console.WriteLine("Recargo inválido");
                }
            }
        }
        private double total; //Se eliminara dependiendo de la tarifa base y los recargos, no se asignara manualmente

        public double Total
        {
            get { return total; }
            set 
            {
                if (value >= 0)
                {
                    total = value;
                }
                else
                {
                    Console.WriteLine("Total inválido");
                }   
            }
        }

        public Entregas (Clientes cliente, Paquete paquete, Repartidores repartidor, Vehiculos vehiculo, DateTime fechaSolicitud, double distancia, TipoServicio tipoServicio, EstadoEntrega estado, int tarifaBase, double recargos, double total)
        {
            Cliente = cliente;
            Paquete = paquete;
            Repartidor = repartidor;
            Vehiculo = vehiculo;
            FechaSolicitud = fechaSolicitud;
            Distancia = distancia;
            TipoServicio = tipoServicio;
            Estado = estado;
            TarifaBase = tarifaBase;
            Recargos = recargos; 

            Total = TarifaBase + Recargos;


            Paquete.Estado = EstadoPaquete.EnCamino;
            Repartidor.Disponibilidad = Disponibilidad.Nodisponible;
            Repartidor.CantidadEntregas = Repartidor.CantidadEntregas + 1;

            Vehiculo.Estado = GoXela_P__D.Estado.Ocupado;

        }

        public void MostrarInformacion()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"===== DETALLE DE ENTREGA =====");
            Console.WriteLine($"Fecha Solicitud: {FechaSolicitud}");
            Console.WriteLine($"Cliente: {Cliente.NombreCompleto}");
            Console.WriteLine($"Paquete: {Paquete.Codigo} - {Paquete.Descripcion}");
            Console.WriteLine($"Repartidor: {Repartidor.NombreCompleto}");
            Console.WriteLine($"Vehículo: {Vehiculo.TipoVehiculo} [{Vehiculo.Marca}]");
            Console.WriteLine($"Distancia: {Distancia} km");
            Console.WriteLine($"Tipo de Servicio: {TipoServicio}");
            Console.WriteLine($"Estado de Entrega: {Estado}");
            Console.WriteLine($"Tarifa Base: Q{TarifaBase}");
            Console.WriteLine($"Recargos: Q{Recargos}");
            Console.WriteLine($"Total a Pagar: Q{Total}"); 
            Console.ResetColor();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoXela_P__D
{
    internal class VerificarEntrega
    {
        public static void RegistrarNuevaEntrega(
            List<Clientes> listaClientes,
            List<Paquete> listaPaquetes,
            List<Repartidores> listaRepartidores,
            List<Vehiculos> listaVehiculos,
            List<Entregas> listaEntregas)
        {
            Console.WriteLine($"REGISTRO DE NUEVA ENTREGA");
                        
            List<Paquete> paquetesAdmitidos = new List<Paquete>();
            foreach (Paquete p in listaPaquetes)
            {
                if (p.Estado == EstadoPaquete.Admitido)
                {
                    paquetesAdmitidos.Add(p);
                }
            }

            if (paquetesAdmitidos.Count == 0)
            {
                Console.WriteLine("No hay paquetes en estado 'Admitido'.");
                return;
            }

            Console.WriteLine($"Paquetes disponibles:");
            for (int i = 0; i < paquetesAdmitidos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Código: {paquetesAdmitidos[i].Codigo} | Desc: {paquetesAdmitidos[i].Descripcion} | Peso: {paquetesAdmitidos[i].Peso} kg");
            }
            Console.Write("Seleccione el número del paquete: ");
            int opcPaquete = Convert.ToInt32(Console.ReadLine()) - 1;

            if (opcPaquete < 0 || opcPaquete >= paquetesAdmitidos.Count)
            {
                Console.WriteLine("Selección de paquete inválida.");
                return;
            }
            Paquete paqueteSeleccionado = paquetesAdmitidos[opcPaquete];

           
            if (listaClientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
                return;
            }

            Console.WriteLine("Clientes registrados:");
            for (int i = 0; i < listaClientes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Código: {listaClientes[i].Codigo} | Nombre: {listaClientes[i].NombreCompleto}");
            }
            Console.Write("Seleccione el número del cliente: ");
            int opcCliente = Convert.ToInt32(Console.ReadLine()) - 1;

            if (opcCliente < 0 || opcCliente >= listaClientes.Count)
            {
                Console.WriteLine("Selección de cliente inválida.");
                return;
            }
            Clientes clienteSeleccionado = listaClientes[opcCliente];

           
            List<Repartidores> repartidoresLibres = new List<Repartidores>();
            foreach (Repartidores r in listaRepartidores)
            {
                if (r.Disponibilidad == Disponibilidad.Disponible)
                {
                    repartidoresLibres.Add(r);
                }
            }

            if (repartidoresLibres.Count == 0)
            {
                Console.WriteLine("No hay repartidores disponibles.");
                return;
            }

            Console.WriteLine("Repartidores disponibles:");
            for (int i = 0; i < repartidoresLibres.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Código: {repartidoresLibres[i].Codigo} | Nombre: {repartidoresLibres[i].NombreCompleto}");
            }
            Console.Write("Seleccione el número del repartidor: ");
            int opcRepartidor = Convert.ToInt32(Console.ReadLine()) - 1;

            if (opcRepartidor < 0 || opcRepartidor >= repartidoresLibres.Count)
            {
                Console.WriteLine("Selección de repartidor inválida.");
                return;
            }
            Repartidores repartidorSeleccionado = repartidoresLibres[opcRepartidor];

            
            List<Vehiculos> vehiculosAptos = new List<Vehiculos>();
            foreach (Vehiculos v in listaVehiculos)
            {
                if (v.Estado == GoXela_P__D.Estado.Libre && v.CapacidadMaxima >= paqueteSeleccionado.Peso)
                {
                    vehiculosAptos.Add(v);
                }
            }

            if (vehiculosAptos.Count == 0)
            {
                Console.WriteLine("No hay vehículos libres con la capacidad necesaria.");
                return;
            }

            Console.WriteLine($"Vehículos disponibles:");
            for (int i = 0; i < vehiculosAptos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Tipo: {vehiculosAptos[i].TipoVehiculo} | Marca: {vehiculosAptos[i].Marca} | Cap. Máx: {vehiculosAptos[i].CapacidadMaxima} kg");
            }
            Console.Write("Seleccione el número del vehículo: ");
            int opcVehiculo = Convert.ToInt32(Console.ReadLine()) - 1;

            if (opcVehiculo < 0 || opcVehiculo >= vehiculosAptos.Count)
            {
                Console.WriteLine("Selección de vehículo inválida.");
                return;
            }
            Vehiculos vehiculoSeleccionado = vehiculosAptos[opcVehiculo];

            
            Console.WriteLine($"Ingrese la distancia del viaje (en km): ");
            double distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Seleccione Tipo de Servicio (1. Normal | 2. Prioritario | 3. Urgente): ");
            int opcServicio = Convert.ToInt32(Console.ReadLine());
            TipoServicio tipoServicio = TipoServicio.Normal;

            if (opcServicio == 2) tipoServicio = TipoServicio.Prioritario;
            else if (opcServicio == 3) tipoServicio = TipoServicio.Urgente;

            Console.WriteLine($"Ingrese la tarifa base (Q): ");
            int tarifaBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese los recargos (Q): ");
            double recargos = Convert.ToDouble(Console.ReadLine());

            
            Entregas nuevaEntrega = new Entregas(
                clienteSeleccionado,
                paqueteSeleccionado,
                repartidorSeleccionado,
                vehiculoSeleccionado,
                DateTime.Now,
                distancia,
                tipoServicio,
                EstadoEntrega.EnProceso,
                tarifaBase,
                recargos,
                tarifaBase + recargos
            );

            paqueteSeleccionado.Estado = EstadoPaquete.EnCamino; 
            repartidorSeleccionado.Disponibilidad = Disponibilidad.Nodisponible;
            repartidorSeleccionado.CantidadEntregas++;
            vehiculoSeleccionado.Estado = GoXela_P__D.Estado.Ocupado;

            listaEntregas.Add(nuevaEntrega);

            Console.WriteLine($"Entrega registrada exitosamente");
            nuevaEntrega.MostrarInformacion();

            Console.WriteLine($"Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public static void FinalizarEntrega(List<Entregas> listaEntregas)
        {
            Console.WriteLine($"FINALIZAR ENTREGA");

            List<Entregas> entregasActivas = new List<Entregas>();
            foreach (Entregas e in listaEntregas)
            {
                if (e.Estado == EstadoEntrega.EnProceso || e.Estado == EstadoEntrega.Pendiente)
                {
                    entregasActivas.Add(e);
                }
            }

            if (entregasActivas.Count == 0)
            {
                Console.WriteLine("No hay entregas activas para finalizar.");
                return;
            }

            for (int i = 0; i < entregasActivas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Cliente: {entregasActivas[i].Cliente.NombreCompleto} | Paquete: {entregasActivas[i].Paquete.Codigo}");
            }

            Console.Write("Seleccione el número de la entrega a finalizar: ");
            int opc = Convert.ToInt32(Console.ReadLine()) - 1;

            if (opc >= 0 && opc < entregasActivas.Count)
            {
                Entregas entrega = entregasActivas[opc];
                 
                entrega.Estado = EstadoEntrega.Entregado;
                entrega.Paquete.Estado = EstadoPaquete.Entregado;
                entrega.Repartidor.Disponibilidad = Disponibilidad.Disponible;
                entrega.Vehiculo.Estado = GoXela_P__D.Estado.Libre;

                Console.WriteLine($"Entrega completada");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        public static void MostrarTodasLasEntregas(List<Entregas> listaEntregas)
        {
            if (listaEntregas.Count == 0)
            {
                Console.WriteLine($"No hay entregas registradas.");
                return;
            }

            foreach (Entregas e in listaEntregas)
            {
                e.MostrarInformacion();
            }
        }

        public static void BorrarEntrega(List<Entregas> listaEntregas)
        {
            Console.WriteLine($"ELIMINAR ENTREGA");

            if (listaEntregas.Count == 0)
            {
                Console.WriteLine("No hay entregas registradas para eliminar.");
                return;
            }


            Console.WriteLine($"Entregas registradas:");
            for (int i = 0; i < listaEntregas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Cliente: {listaEntregas[i].Cliente.NombreCompleto} | Paquete: {listaEntregas[i].Paquete.Codigo} | Estado: {listaEntregas[i].Estado}");
            }

            Console.Write($"Seleccione el número de la entrega que desea ELIMINAR: ");
            int opc = Convert.ToInt32(Console.ReadLine()) - 1;

            if (opc >= 0 && opc < listaEntregas.Count)
            {
                Entregas entregaAEliminar = listaEntregas[opc];


                if (entregaAEliminar.Estado != EstadoEntrega.Entregado)
                {
                    entregaAEliminar.Paquete.Estado = EstadoPaquete.Admitido;
                    entregaAEliminar.Repartidor.Disponibilidad = Disponibilidad.Disponible;
                    entregaAEliminar.Vehiculo.Estado = GoXela_P__D.Estado.Libre; 

                    if (entregaAEliminar.Repartidor.CantidadEntregas > 0)
                    {
                        entregaAEliminar.Repartidor.CantidadEntregas--;
                    }
                }
                 
                listaEntregas.RemoveAt(opc);

                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"Entrega eliminada"); 
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        public static void BuscarEntrega(List<Entregas> listaEntregas)
        {
            Console.WriteLine($"BUSCAR ENTREGA");

            if (listaEntregas.Count == 0)
            {
                Console.WriteLine("No hay entregas registradas en el sistema.");
                return;
            }

            bool encontrada = false;

            
                Console.WriteLine($"Ingrese el Nombre del Cliente (o parte de él): ");
                string nombreBuscado = Console.ReadLine();

                foreach (Entregas e in listaEntregas)
                {
                    if (e.Cliente.NombreCompleto.ToLower().Contains(nombreBuscado.ToLower()))
                    {
                        e.MostrarInformacion();
                        encontrada = true;
                    }
                }
            
            
            if (!encontrada)
            {
                Console.WriteLine("No se encontró ninguna entrega con los criterios ingresados.");
            }
        }
    }
  }


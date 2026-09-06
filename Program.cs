using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace GoXela_P__D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, op1, op2, op3,op4,op5;
            List<Clientes> listaClientes = new List<Clientes>();
            List<Repartidores> listaRepartidores = new List<Repartidores>();
            List<Vehiculos> listaVehiculos = new List<Vehiculos>();
            List<Automovil> listaAutomovil = new List<Automovil>();
            List<Motocicleta> listaMotocicleta = new List<Motocicleta>();
            List<Bicicleta> listaBicicleta = new List<Bicicleta>();
            List<Paquete> listaPaquetes = new List<Paquete>();
            do
            {            
                Console.WriteLine($"=========================");
                Console.WriteLine($"      GOXELA DELIVERY    ");
                Console.WriteLine($"=========================");
                Console.WriteLine($"1. Gestión de clientes");
                Console.WriteLine($"2. Gestión de repartidores");
                Console.WriteLine($"3. Gestión de vehículos");
                Console.WriteLine($"4. Gestión de paquetes");
                Console.WriteLine($"5. Gestión de entregas");
                Console.WriteLine($"6. Gestión de incidencias");
                Console.WriteLine($"7. Reportes");
                Console.WriteLine($"8. Salir");

                if(!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine($"Dato inválido... Intente de nuevo");
                }
                else 
                {
                    switch (op)
                    {
                        case 1:
                            //Clientes
                            string codigo; string nombreCliente; string numeroTelefonico; string direccion; string correo; int cantidadSoli;
                            do
                            {
                                Console.WriteLine("===== CLIENTES =====");
                                Console.WriteLine($"1. Nuevo Cliente");
                                Console.WriteLine($"2. Mostrar Clientes");
                                Console.WriteLine($"3. Buscar Cliente");
                                Console.WriteLine($"4. Actualizar Información");
                                Console.WriteLine($"5. Borrar Información");
                                Console.WriteLine($"6. Salir");
                                
                                if(!int.TryParse(Console.ReadLine(), out op1))
                                {
                                    Console.WriteLine($"Opción no válida (No es un valor numérico)");
                                } else
                                {
                                    switch (op1)
                                    {
                                        case 1:
                                            do
                                            {  
                                                Console.WriteLine($"NUEVO CLIENTE");
                                                Console.WriteLine($"Ingrese el código");
                                                codigo = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(codigo) && codigo.Length <= 5)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Código inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese el nombre");
                                                nombreCliente = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(nombreCliente) && nombreCliente.Length <= 50)
                                                {
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nombre inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese el numero telefonico");
                                                numeroTelefonico = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(numeroTelefonico) && numeroTelefonico.Length <= 8)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Numero telefonico inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese la dirección");
                                                direccion = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(direccion) && direccion.Length <= 50)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Direccion inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese el correo");
                                                correo = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(correo) && correo.Length <= 50 && correo.Contains("@"))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Correo inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese la cantidad de solicitudes");
                                                if (!int.TryParse(Console.ReadLine(), out cantidadSoli))
                                                {
                                                    Console.WriteLine($"Dato no valido");
                                                }
                                                else
                                                {
                                                    if (cantidadSoli > 0 && cantidadSoli <= 5)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Cantidad de solicitudes inválida");
                                                    }
                                                }
                                            } while (true);

                                            listaClientes.Add(new Clientes(codigo, nombreCliente, numeroTelefonico, direccion, correo, cantidadSoli));

                                            break;
                                        case 2:
                                            Console.WriteLine($"===== CLIENTES =====");
                                            if (listaClientes.Count == 0)
                                            {
                                                Console.WriteLine($"No existen clientes registrados");
                                            }
                                            else
                                            {
                                                foreach (var item in listaClientes)
                                                {
                                                    item.MostrarInformacion();
                                                }
                                            }

                                            Console.WriteLine($"Precione cualquier tecla para continuar");
                                            Console.ReadKey();
                                            break;
                                        case 3:
                                            //Buscar cliente
                                            string codBuscar;
                                            Console.WriteLine($"===== BUSCAR CLIENTE =====");
                                            do
                                            {
                                                Console.WriteLine("Ingrese el código del cliente a buscar: ");
                                                codBuscar = Console.ReadLine();
                                                if(!string.IsNullOrWhiteSpace(codBuscar) && codBuscar.Length <= 50)
                                                {
                                                    break;
                                                } else
                                                {
                                                    Console.WriteLine($"Dato no valido");
                                                }

                                            } while (true); 
                                            

                                            int posBuscada = -1;

                                            for(int i = 0; i < listaClientes.Count ; i++)
                                            {
                                                if (listaClientes[i].Codigo == codBuscar)
                                                {
                                                    posBuscada = i;
                                                    break;
                                                }
                                            }

                                            if(posBuscada != -1)
                                            {
                                                Console.WriteLine($"Cliente encontrado en la posición: {posBuscada}");
                                                listaClientes[posBuscada].MostrarInformacion();
                                            } else
                                            {
                                                Console.WriteLine($"El cliente no esta registrado"); 
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                        case 4:
                                            Console.WriteLine($"===== ACTUALIZAR INFORMACIÓN =====");
                                            Console.Write("Ingrese el código del cliente a modificar: ");
                                            string codModificar = Console.ReadLine();

                                            int posModificar = -1;
                                                                                        
                                            for (int i = 0; i < listaClientes.Count; i++)
                                            {
                                                if (listaClientes[i].Codigo == codModificar)
                                                {
                                                    posModificar = i;
                                                    break;
                                                }
                                            }

                                            if (posModificar != -1)
                                            {
                                                Console.WriteLine($"Cliente encontrado. Ingrese los nuevos datos:");
                                                                                                
                                                do
                                                {
                                                    Console.WriteLine("Nuevo Nombre: ");
                                                    string nuevoNombre = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(nuevoNombre) && nuevoNombre.Length <= 50)
                                                    {
                                                        listaClientes[posModificar].NombreCompleto = nuevoNombre;
                                                        break;
                                                    }
                                                    Console.WriteLine("Nombre inválido.");
                                                } while (true);
                                                                                                
                                                do
                                                {
                                                    Console.WriteLine("Nuevo Teléfono: ");
                                                    string nuevoTel = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(nuevoTel) && nuevoTel.Length <= 8)
                                                    {
                                                        listaClientes[posModificar].NumeroTelefonico = nuevoTel;
                                                        break;
                                                    }
                                                    Console.WriteLine("Número inválido.");
                                                } while (true);
                                                                                                
                                                do
                                                {
                                                    Console.WriteLine("Nueva Dirección: ");
                                                    string nuevaDir = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(nuevaDir) && nuevaDir.Length <= 50)
                                                    {
                                                        listaClientes[posModificar].Direccion = nuevaDir;
                                                        break;
                                                    }
                                                    Console.WriteLine("Dirección inválida.");
                                                } while (true);
                                                                                                
                                                do
                                                {
                                                    Console.WriteLine("Nuevo Correo: ");
                                                    string nuevoCorreo = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(nuevoCorreo) && nuevoCorreo.Contains("@") && nuevoCorreo.Length <= 50)
                                                    {
                                                        listaClientes[posModificar].Correo = nuevoCorreo;
                                                        break;
                                                    }
                                                    Console.WriteLine("Correo inválido.");
                                                } while (true);
                                                                                                
                                                do
                                                {
                                                    Console.WriteLine("Nueva Cantidad de Solicitudes: ");
                                                    if (int.TryParse(Console.ReadLine(), out int nuevaSoli) && nuevaSoli > 0 && nuevaSoli <= 5)
                                                    {
                                                        listaClientes[posModificar].CantidadSolicitudes = nuevaSoli;
                                                        break;
                                                    }
                                                    Console.WriteLine("Cantidad de solicitudes inválida.");
                                                } while (true);

                                                Console.WriteLine("¡Cliente actualizado exitosamente!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Cliente no encontrado.");
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                                                                        
                                        case 5:
                                            Console.WriteLine($"===== ELMINAR INFOMRACIÓN =====");
                                            Console.Write("Ingrese el código del cliente a eliminar: ");
                                            string codEliminar = Console.ReadLine();

                                            int posEliminar = -1;

                                            for (int i = 0; i < listaClientes.Count; i++)
                                            {
                                                if (listaClientes[i].Codigo == codEliminar)
                                                {
                                                    posEliminar = i;
                                                    break;
                                                }
                                            }

                                            if (posEliminar != -1)
                                            {
                                                listaClientes.RemoveAt(posEliminar);
                                                Console.WriteLine($"Eliminado Correctamente");
                                            }else
                                            {
                                                Console.WriteLine($"Cliente no encontrado");
                                            }

                                            Console.WriteLine($"Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                                break;
                                        case 6:
                                            Console.WriteLine($"Saliendo...");
                                            break;
                                        default:
                                            Console.WriteLine($"Opcion invalida... intente de nuevo");
                                            break;
                                    }
                                }
                            } while (op1 != 6);
                            
                            break;
                        case 2:
                            //Repartidores
                            string codigoR; string nombreClienteR; string numeroTelefonicoR; string direccionR; string correoR; int cantidadEntre; int calificacion;
                            TipoLicencia licenciaSeleccionada;
                            Disponibilidad disponibilidadSeleccionada;
                            do
                            {
                                Console.WriteLine("===== REPARTIDORES =====");
                                Console.WriteLine($"1. Nuevo Repartidor");
                                Console.WriteLine($"2. Mostrar Repartidores");
                                Console.WriteLine($"3. Buscar Repartidor");
                                Console.WriteLine($"4. Actualizar Información");
                                Console.WriteLine($"5. Borrar Información");
                                Console.WriteLine($"6. Salir");

                                if (!int.TryParse(Console.ReadLine(), out op2))
                                {
                                    Console.WriteLine($"Opcion no valida (No es un valor numerico)");
                                }
                                else
                                {
                                    switch (op2)
                                    {
                                        case 1:
                                            do
                                            {
                                                Console.WriteLine($"NUEVO REPARTIDOR");
                                                Console.WriteLine($"Ingrese el código");
                                                codigoR = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(codigoR) && codigoR.Length <= 5)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Código inválido");
                                                }
                                            } while (true);

                                            do 
                                            {
                                                Console.WriteLine($"Ingrese el nombre");
                                                nombreClienteR = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(nombreClienteR) && nombreClienteR.Length <= 50)
                                                {
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Nombre inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese el numero telefonico");
                                                numeroTelefonicoR = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(numeroTelefonicoR) && numeroTelefonicoR.Length <= 8)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Numero telefonico inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese la dirección");
                                                direccionR = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(direccionR) && direccionR.Length <= 50)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Direccion inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese el correo");
                                                correoR = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(correoR) && correoR.Length <= 50 && correoR.Contains("@"))
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Correo inválido");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese la cantidad de entregas");
                                                if (!int.TryParse(Console.ReadLine(), out cantidadEntre))
                                                {
                                                    Console.WriteLine($"Dato no valido");
                                                }
                                                else
                                                {
                                                    if (cantidadEntre > 0 && cantidadEntre <= 5)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Cantidad de solicitudes inválida");
                                                    }
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese la cantidad calificación");
                                                if (!int.TryParse(Console.ReadLine(), out calificacion))
                                                {
                                                    Console.WriteLine($"Dato no valido");
                                                }
                                                else
                                                {
                                                    if (calificacion > 0 && calificacion <= 5)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Cantidad de solicitudes inválida");
                                                    }
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Seleccione la disponibilidad:");
                                                Console.WriteLine("1. Disponible");
                                                Console.WriteLine("2. No disponible");
                                                Console.Write("Opción: ");

                                                string opcion = Console.ReadLine();

                                                if (opcion == "1")
                                                {
                                                    disponibilidadSeleccionada = Disponibilidad.Disponible;
                                                    break;
                                                }
                                                else if (opcion == "2")
                                                {
                                                    disponibilidadSeleccionada = Disponibilidad.Nodisponible;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                                                }
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Seleccione el  tipo de licencia");
                                                Console.WriteLine($"1. M");
                                                Console.WriteLine($"2. C");
                                                Console.WriteLine($"3. B");
                                                Console.WriteLine($"4. A");

                                                string opcion = Console.ReadLine();

                                                if (opcion == "1")
                                                {
                                                    licenciaSeleccionada = TipoLicencia.M;
                                                    break;
                                                }
                                                else if (opcion == "2")
                                                {
                                                    licenciaSeleccionada = TipoLicencia.C;
                                                    break;
                                                }
                                                else if (opcion == "3")
                                                {
                                                    licenciaSeleccionada = TipoLicencia.B;
                                                    break;
                                                }
                                                else if (opcion == "4")
                                                {
                                                    licenciaSeleccionada = TipoLicencia.A;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Opcion no valida. Intente de nuevo");
                                                } 
                                            } while (true);

                                            listaRepartidores.Add(new Repartidores(codigoR, nombreClienteR, numeroTelefonicoR, direccionR, correoR, licenciaSeleccionada, disponibilidadSeleccionada, 
                                                cantidadEntre, calificacion));

                                            break;
                                        case 2:
                                            Console.WriteLine($"===== REPARTIDORES =====");
                                            if (listaRepartidores.Count == 0)
                                            {
                                                Console.WriteLine($"No existen respartidores registrados");
                                            }
                                            else
                                            {
                                                foreach (var item in listaRepartidores)
                                                {
                                                    item.MostrarInformacion();
                                                }
                                            }

                                            Console.WriteLine($"Precione cualquier tecla para continuar");
                                            Console.ReadKey();
                                            break;
                                        case 3:
                                            string codBuscar;
                                            Console.WriteLine($"===== BUSCAR REPARTIDOR =====");
                                            do
                                            {
                                                Console.WriteLine("Ingrese el código del cliente a buscar: ");
                                                codBuscar = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(codBuscar) && codBuscar.Length <= 50)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Dato no valido");
                                                }

                                            } while (true);


                                            int posBuscada = -1;

                                            for (int i = 0; i < listaRepartidores.Count; i++)
                                            {
                                                if (listaRepartidores[i].Codigo == codBuscar)
                                                {
                                                    posBuscada = i;
                                                    break;
                                                }
                                            }

                                            if (posBuscada != -1)
                                            {
                                                Console.WriteLine($"Cliente encontrado en la posición: {posBuscada}");
                                                listaRepartidores[posBuscada].MostrarInformacion();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"El cliente no esta registrado");
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                        case 4:
                                            Console.WriteLine($"===== ACTUALIZAR INFORMACIÓN =====");
                                            Console.Write("Ingrese el código del repartidor a modificar: ");
                                            string codModificar = Console.ReadLine();

                                            int posModificar = -1;

                                            for (int i = 0; i < listaRepartidores.Count; i++)
                                            {
                                                if (listaRepartidores[i].Codigo == codModificar)
                                                {
                                                    posModificar = i;
                                                    break;
                                                }
                                            }

                                            if (posModificar != -1)
                                            {
                                                Console.WriteLine($"Repartidor encontrado. Ingrese los nuevos datos:");

                                                do
                                                {
                                                    Console.WriteLine("Nuevo Nombre: ");
                                                    string nuevoNombre = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(nuevoNombre) && nuevoNombre.Length <= 50)
                                                    {
                                                        listaRepartidores[posModificar].NombreCompleto = nuevoNombre;
                                                        break;
                                                    }
                                                    Console.WriteLine("Nombre inválido.");
                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Nuevo Teléfono: ");
                                                    string nuevoTel = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(nuevoTel) && nuevoTel.Length <= 8)
                                                    {
                                                        listaRepartidores[posModificar].NumeroTelefonico = nuevoTel;
                                                        break;
                                                    }
                                                    Console.WriteLine("Número inválido.");
                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Nueva Dirección: ");
                                                    string nuevaDir = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(nuevaDir) && nuevaDir.Length <= 50)
                                                    {
                                                        listaRepartidores[posModificar].Direccion = nuevaDir;
                                                        break;
                                                    }
                                                    Console.WriteLine("Dirección inválida.");
                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Nuevo Correo: ");
                                                    string nuevoCorreo = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(nuevoCorreo) && nuevoCorreo.Contains("@") && nuevoCorreo.Length <= 50)
                                                    {
                                                        listaRepartidores[posModificar].Correo = nuevoCorreo;
                                                        break;
                                                    }
                                                    Console.WriteLine("Correo inválido.");
                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Nueva Cantidad de entregas:");
                                                    if (int.TryParse(Console.ReadLine(), out int nuevaEntre) && nuevaEntre > 0 && nuevaEntre <= 5)
                                                    {
                                                        listaRepartidores[posModificar].CantidadEntregas = nuevaEntre;
                                                        break;
                                                    }
                                                    Console.WriteLine("Cantidad de entregas inválida.");
                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine($"Ingrese la nueva licencia: ");
                                                    Console.WriteLine($"1. M");
                                                    Console.WriteLine($"2. C");
                                                    Console.WriteLine($"3. B");
                                                    Console.WriteLine($"4. A");

                                                    string opcion = Console.ReadLine();

                                                    if (opcion == "1")
                                                    {
                                                        listaRepartidores[posModificar].TipoLicencia = TipoLicencia.M;
                                                        break;
                                                    }
                                                    else if (opcion == "2")
                                                    {
                                                        listaRepartidores[posModificar].TipoLicencia = TipoLicencia.C;
                                                        break;
                                                    }
                                                    else if (opcion == "3")
                                                    {
                                                        listaRepartidores[posModificar].TipoLicencia = TipoLicencia.B;
                                                        break;
                                                    }
                                                    else if (opcion == "4")
                                                    {
                                                        listaRepartidores[posModificar].TipoLicencia = TipoLicencia.A;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"Opcion no valida. Intente de nuevo");
                                                    }
                                                } while (true);


                                                do
                                                {
                                                    Console.WriteLine($"Ingrese la nueva disponibilidad: ");
                                                    Console.WriteLine($"1. Disponible");
                                                    Console.WriteLine($"2. No disponible"); 

                                                    string opcion = Console.ReadLine();

                                                    if (opcion == "1")
                                                    {
                                                        listaRepartidores[posModificar].Disponibilidad = Disponibilidad.Disponible;
                                                        break;
                                                    }
                                                    else if (opcion == "2")
                                                    {
                                                        listaRepartidores[posModificar].Disponibilidad = Disponibilidad.Nodisponible;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"Opcion no valida. Intente de nuevo");
                                                    }
                                                } while (true);

                                                Console.WriteLine("¡Repartidor actualizado exitosamente!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Repartidor no encontrado.");
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                        case 5:
                                            Console.WriteLine($"===== ELMINAR INFOMRACIÓN =====");
                                            Console.Write("Ingrese el código del repartidor a eliminar: ");
                                            string codEliminar = Console.ReadLine();

                                            int posEliminar = -1;

                                            for (int i = 0; i < listaRepartidores.Count; i++)
                                            {
                                                if (listaRepartidores[i].Codigo == codEliminar)
                                                {
                                                    posEliminar = i;
                                                    break;
                                                }
                                            }

                                            if (posEliminar != -1)
                                            {
                                                listaRepartidores.RemoveAt(posEliminar);
                                                Console.WriteLine($"Eliminado Correctamente");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Repartidor no encontrado");
                                            }

                                            Console.WriteLine($"Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                        case 6:
                                            Console.WriteLine($"Saliendo...");
                                            break;
                                        default:
                                            Console.WriteLine($"Opcion invalida... Intente de nuevo");
                                            break;
                                    }
                                }
                            } while (op2 != 6);
                            break;
                        case 3:
                            //Vehículos
                            do
                            {
                                Console.WriteLine("===== VEHICULOS =====");
                                Console.WriteLine($"1. Nuevo Vehículo");
                                Console.WriteLine($"2. Mostrar Vehículos");
                                Console.WriteLine($"3. Buscar Vehiculo");
                                Console.WriteLine($"4. Actualizar Información");
                                Console.WriteLine($"5. Borrar Información");
                                Console.WriteLine($"6. Salir");

                                if (!int.TryParse(Console.ReadLine(), out op3))
                                {
                                    Console.WriteLine($"Opcion no valida (No es un valor numerico)");
                                }
                                else
                                {
                                    switch (op3)
                                    {
                                        case 1:
                                            string codigoV; string marca; string modelo; double costo = 0; string placa = "";
                                            Estado estadoSeleccionado;
                                            Console.WriteLine($"===== REGISTRO DE VEHÍCULOS =====");
                                                                                      

                                            do
                                            {
                                                Console.WriteLine($"Ingrese el código: ");
                                                codigoV = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(codigoV) && codigoV.Length <= 5)
                                                {
                                                    break;
                                                }
                                                Console.WriteLine($"Código inválido");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese la marca: ");
                                                marca = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(marca) && marca.Length <= 10)
                                                {
                                                    break;
                                                }
                                                Console.WriteLine($"Marca inválida");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine($"Ingrese el modelo: ");
                                                modelo = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(modelo) && modelo.Length <= 10)
                                                {
                                                    break;
                                                }
                                                Console.WriteLine($"Modelo inválido");
                                            } while (true);


                                            do
                                            {
                                                Console.WriteLine($"Ingrese el estado:");
                                                Console.WriteLine($"1. Libre");
                                                Console.WriteLine($"2. Ocupado");
                                                Console.WriteLine($"Opción: ");
                                                string opcionEstado = Console.ReadLine();

                                                if (opcionEstado == "1")
                                                {
                                                    estadoSeleccionado = Estado.Libre;
                                                    break;
                                                }
                                                else if (opcionEstado == "2")
                                                {
                                                    estadoSeleccionado = Estado.Ocupado;
                                                    break;
                                                }
                                                Console.WriteLine($"Opción no válida. Intente de nuevo.");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Seleccione el tipo de vehículo:");
                                                Console.WriteLine($"1. Automóvil");
                                                Console.WriteLine($"2. Motocicleta");
                                                Console.WriteLine($"3. Bicicleta");
                                                Console.WriteLine($"Opciónes: ");
                                                string tipoVehiculo = Console.ReadLine();

                                                if (tipoVehiculo != "1" && tipoVehiculo != "2" && tipoVehiculo != "3")
                                                {
                                                    Console.WriteLine("Opción de vehículo no válida");
                                                    Console.WriteLine("Presione cualquier tecla para continuar...");
                                                    Console.ReadKey();

                                                }
                                                else
                                                {
                                                    switch (tipoVehiculo)
                                                    {
                                                        case "1":
                                                            do
                                                            {
                                                                Console.WriteLine($"Ingrese la placa del automóvil:");
                                                                placa = Console.ReadLine();
                                                                if (!string.IsNullOrWhiteSpace(placa) && placa.Length <= 10)
                                                                {
                                                                    break;
                                                                }
                                                                Console.WriteLine($"Placa inválida");
                                                            } while (true);

                                                            costo = 40.0;
                                                            listaVehiculos.Add(new Automovil(codigoV, marca, modelo, estadoSeleccionado, costo, placa));
                                                            Console.WriteLine($"Automóvil registrado exitosamente");
                                                            break;

                                                        case "2":
                                                            do
                                                            {
                                                                Console.WriteLine($"Ingrese la placa de la motocicleta: ");
                                                                placa = Console.ReadLine();
                                                                if (!string.IsNullOrWhiteSpace(placa) && placa.Length <= 10)
                                                                {
                                                                    break;
                                                                }
                                                                Console.WriteLine($"Placa inválida");
                                                            } while (true);

                                                            costo = 25.0;
                                                            listaVehiculos.Add(new Motocicleta(codigoV, marca, modelo, estadoSeleccionado, costo, placa));
                                                            Console.WriteLine($"Motocicleta registrada exitosamente");
                                                            break;

                                                        case "3":
                                                            costo = 10.0;
                                                            listaVehiculos.Add(new Bicicleta(codigoV, marca, modelo, estadoSeleccionado, costo));
                                                            Console.WriteLine($"Bicicleta registrada exitosamente");
                                                            break;
                                                    }
                                                    break;
                                                }
                                            } while (true);
                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                        case 2:
                                            Console.WriteLine($"===== MOSTRAR INFORMACION =====");

                                            if (listaVehiculos.Count == 0)
                                            {
                                                Console.WriteLine("No hay vehículos registrados.");
                                            }
                                            else
                                            {
                                                int contador = 1;
                                                foreach (Vehiculos vehiculo in listaVehiculos)
                                                {
                                                    Console.WriteLine($"Vehículo numero{contador}");
                                                                                                   
                                                    vehiculo.MostrarInformacion();
                                                    contador++;
                                                }
                                            }

                                            Console.WriteLine($"Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                        case 3:
                                            string codBuscar;
                                            Console.WriteLine($"===== BUSCAR VEHICULO =====");
                                            do
                                            {
                                                Console.WriteLine("Ingrese el código del vehiculo a buscar: ");
                                                codBuscar = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(codBuscar) && codBuscar.Length <= 50)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Dato no valido");
                                                }

                                            } while (true);


                                            int posBuscada = -1;

                                            for (int i = 0; i < listaVehiculos.Count; i++)
                                            {
                                                if (listaVehiculos[i].Codigo == codBuscar)
                                                {
                                                    posBuscada = i;
                                                    break;
                                                }
                                            }

                                            if (posBuscada != -1)
                                            {
                                                Console.WriteLine($"Vehiculo encontrado en la posición: {posBuscada}");
                                                listaVehiculos[posBuscada].MostrarInformacion();
                                            }
                                            else
                                            {
                                                Console.WriteLine($"El vehiculo no esta registrado");
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                        case 4:

                                            Console.WriteLine($"===== ACTUALIZAR INFORMACIÓN =====");
                                            Console.Write("Ingrese el código del vehiculo a modificar: ");
                                            string codModificar = Console.ReadLine();
    
                                            int posModificar = -1;

                                            for (int i = 0; i < listaVehiculos.Count; i++)
                                            {
                                                if (listaVehiculos[i].Codigo == codModificar)
                                                {
                                                    posModificar = i;
                                                    break;
                                                }
                                            }

                                            if (posModificar != -1)
                                            {
                                                Console.WriteLine("\nVehículo encontrado. Ingrese los nuevos datos:");

                                                string codigoN;
                                                string marcaN;
                                                string modeloN;
                                                string placaN = "";
                                                double costoN = 0;
                                                Estado estadoN;

                                                
                                                do
                                                {
                                                    Console.Write("Ingrese el nuevo código: ");
                                                    codigoN = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(codigoN) && codigoN.Length <= 5)
                                                    {
                                                        break;
                                                    }
                                                    Console.WriteLine("Código inválido");
                                                } while (true);

                                                
                                                do
                                                {
                                                    Console.Write("Ingrese la nueva marca: ");
                                                    marcaN = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(marcaN) && marcaN.Length <= 10)
                                                    {
                                                        break;
                                                    }
                                                    Console.WriteLine("Marca inválida");
                                                } while (true);

                                                
                                                do
                                                {
                                                    Console.Write("Ingrese el nuevo modelo: ");
                                                    modeloN = Console.ReadLine();
                                                    if (!string.IsNullOrWhiteSpace(modeloN) && modeloN.Length <= 10)
                                                    {
                                                        break;
                                                    }
                                                    Console.WriteLine("Modelo inválido");
                                                } while (true);


                                                do
                                                {
                                                    Console.WriteLine("Ingrese el nuevo estado:");
                                                    Console.WriteLine("1. Libre");
                                                    Console.WriteLine("2. Ocupado");
                                                    Console.WriteLine("Opción: ");
                                                    string opcionEstado = Console.ReadLine();

                                                    if (opcionEstado == "1")
                                                    {
                                                        estadoN = Estado.Libre;
                                                        break;
                                                    }
                                                    else if (opcionEstado == "2")
                                                    {
                                                        estadoN = Estado.Ocupado;
                                                        break;
                                                    }
                                                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                                                } while (true);
                                                
                                                do
                                                {
                                                    Console.WriteLine($"Seleccione el nuevo tipo de vehículo:");
                                                    Console.WriteLine($"1. Automóvil");
                                                    Console.WriteLine($"2. Motocicleta");
                                                    Console.WriteLine($"3. Bicicleta");
                                                    Console.WriteLine($"Opción: ");
                                                    string tipoVehiculo = Console.ReadLine();

                                                    if (tipoVehiculo == "1")
                                                    {
                                                        do
                                                        {
                                                            Console.Write("Ingrese la placa del automóvil: ");
                                                            placaN = Console.ReadLine();
                                                            if (!string.IsNullOrWhiteSpace(placaN) && placaN.Length <= 10)
                                                            {
                                                                break;
                                                            }
                                                            Console.WriteLine("Placa inválida.");
                                                        } while (true);

                                                        costoN = 40.0;
                                                        
                                                        listaVehiculos[posModificar] = new Automovil(codigoN, marcaN, modeloN, estadoN, costoN, placaN);
                                                        Console.WriteLine($"Vehículo actualizado a Automóvil exitosamente");
                                                        break;
                                                    }
                                                    else if (tipoVehiculo == "2") 
                                                    {
                                                        do
                                                        {
                                                            Console.Write("Ingrese la placa de la motocicleta: ");
                                                            placaN = Console.ReadLine();
                                                            if (!string.IsNullOrWhiteSpace(placaN) && placaN.Length <= 10)
                                                            {
                                                                break;
                                                            }
                                                            Console.WriteLine("Placa inválida.");
                                                        } while (true);

                                                        costoN = 25.0;
                                                        
                                                        listaVehiculos[posModificar] = new Motocicleta(codigoN, marcaN, modeloN, estadoN, costoN, placaN);
                                                        Console.WriteLine($"Vehículo actualizado a Motocicleta exitosamente");
                                                        break;
                                                    }
                                                    else if (tipoVehiculo == "3") // BICICLETA
                                                    {
                                                        costoN = 10.0;
                                                       
                                                        listaVehiculos[posModificar] = new Bicicleta(codigoN, marcaN, modeloN, estadoN, costoN);
                                                        Console.WriteLine($"Vehículo actualizado a Bicicleta exitosamente");
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"Opción de vehículo no válida. Intente de nuevo");
                                                    }
                                                } while (true);
                                            }
                                            else
                                            {
                                                Console.WriteLine($"El vehículo no se encuentra registrado.");
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;
                                        case 5:
                                            Console.WriteLine($"===== ELMINAR INFOMRACIÓN =====");
                                            Console.Write("Ingrese el código del vehiculo a eliminar: ");
                                            string codEliminar = Console.ReadLine();

                                            int posEliminar = -1;

                                            for (int i = 0; i < listaVehiculos.Count; i++)
                                            {
                                                if (listaVehiculos[i].Codigo == codEliminar)
                                                {
                                                    posEliminar = i;
                                                    break;
                                                }
                                            }

                                            if (posEliminar != -1)
                                            {
                                                listaVehiculos.RemoveAt(posEliminar);
                                                Console.WriteLine($"Eliminado Correctamente");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Repartidor no encontrado");
                                            }

                                            Console.WriteLine($"Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;                                      
                                        case 6:
                                            Console.WriteLine($"Saliendo...");
                                            break;
                                        default:
                                            Console.WriteLine($"Opción fuera de rango");  
                                            break;
                                    }
                                }
                            } while (op3 != 6);
                            break;
                        case 4:
                            //Paquetes
                            do
                            {
                                Console.WriteLine("===== PAQUETES =====");
                                Console.WriteLine($"1. Nuevo Paquete");
                                Console.WriteLine($"2. Mostrar Paquetes");
                                Console.WriteLine($"3. Buscar Paquete");
                                Console.WriteLine($"4. Actualizar Información");
                                Console.WriteLine($"5. Borrar Información");
                                Console.WriteLine($"6. Salir");

                                if (!int.TryParse(Console.ReadLine(), out op4))
                                {
                                    Console.WriteLine($"Opcion no valida (No es un valor numerico)");
                                }
                                else
                                {
                                    switch (op4)
                                    {
                                        case 1:

                                            string codigoP;
                                            string descripcionP;
                                            double pesoP;
                                            double valorDeclarado;
                                            string direccionOrigen;
                                            string direccionDestino;

                                            EstadoPaquete estadoSeleccionado;

                                            do
                                            {
                                                Console.WriteLine("Ingrese el código:");
                                                codigoP = Console.ReadLine();

                                                if (!string.IsNullOrWhiteSpace(codigoP) && codigoP.Length <= 5)
                                                {
                                                    break;
                                                }

                                                Console.WriteLine("Código inválido");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Ingrese la descripción:");
                                                descripcionP = Console.ReadLine();

                                                if (!string.IsNullOrWhiteSpace(descripcionP) && descripcionP.Length <= 50)
                                                {
                                                    break;
                                                }

                                                Console.WriteLine("Descripción inválida");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Ingrese el peso:");

                                                if (double.TryParse(Console.ReadLine(), out pesoP))
                                                {
                                                    if (pesoP > 0)
                                                    {
                                                        break;
                                                    }
                                                }

                                                Console.WriteLine("Peso inválido");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Ingrese el valor declarado:");

                                                if (double.TryParse(Console.ReadLine(), out valorDeclarado))
                                                {
                                                    if (valorDeclarado >= 0)
                                                    {
                                                        break;
                                                    }
                                                }

                                                Console.WriteLine("Valor declarado inválido");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Ingrese la dirección de origen:");

                                                direccionOrigen = Console.ReadLine();

                                                if (!string.IsNullOrWhiteSpace(direccionOrigen)
                                                    && direccionOrigen.Length <= 50)
                                                {
                                                    break;
                                                }

                                                Console.WriteLine("Dirección inválida");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Ingrese la dirección de destino:");

                                                direccionDestino = Console.ReadLine();

                                                if (!string.IsNullOrWhiteSpace(direccionDestino)
                                                    && direccionDestino.Length <= 50)
                                                {
                                                    break;
                                                }

                                                Console.WriteLine("Dirección inválida");
                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Seleccione el estado:");
                                                Console.WriteLine("1. Admitido");
                                                Console.WriteLine("2. En Camino");
                                                Console.WriteLine("3. Entregado");

                                                string opcionEstado = Console.ReadLine();

                                                if (opcionEstado == "1")
                                                {
                                                    estadoSeleccionado = EstadoPaquete.Admitido;
                                                    break;
                                                }
                                                else if (opcionEstado == "2")
                                                {
                                                    estadoSeleccionado = EstadoPaquete.EnCamino;
                                                    break;
                                                }
                                                else if (opcionEstado == "3")
                                                {
                                                    estadoSeleccionado = EstadoPaquete.Entregado;
                                                    break;
                                                }

                                                Console.WriteLine("Opción inválida");

                                            } while (true);

                                            do
                                            {
                                                Console.WriteLine("Seleccione el tipo de paquete:");
                                                Console.WriteLine("1. Documento");
                                                Console.WriteLine("2. Paquete Estándar");
                                                Console.WriteLine("3. Paquete Frágil");
                                                Console.WriteLine("4. Paquete Refrigerado");

                                                string tipoPaquete = Console.ReadLine();

                                                if (tipoPaquete == "1")
                                                {
                                                    listaPaquetes.Add(
                                                        new Documento(
                                                            codigoP, descripcionP, pesoP, valorDeclarado, direccionOrigen, direccionDestino, estadoSeleccionado
                                                        ));

                                                    Console.WriteLine("Documento registrado correctamente");
                                                    break;
                                                }
                                                else if (tipoPaquete == "2")
                                                {
                                                    listaPaquetes.Add(
                                                        new PaqueteEstandar(
                                                            codigoP, descripcionP, pesoP, valorDeclarado, direccionOrigen, direccionDestino, estadoSeleccionado
                                                        ));

                                                    Console.WriteLine("Paquete estándar registrado correctamente");
                                                    break;
                                                }
                                                else if (tipoPaquete == "3")
                                                {
                                                    listaPaquetes.Add(
                                                        new PaqueteFragil(codigoP, descripcionP, pesoP, valorDeclarado, direccionOrigen, direccionDestino, estadoSeleccionado
                                                        ));

                                                    Console.WriteLine("Paquete frágil registrado correctamente");
                                                    break;
                                                }
                                                else if (tipoPaquete == "4")
                                                {
                                                    listaPaquetes.Add(
                                                        new PaqueteRefrigerado(codigoP, descripcionP, pesoP, valorDeclarado, direccionOrigen, direccionDestino, estadoSeleccionado
                                                        ));

                                                    Console.WriteLine("Paquete refrigerado registrado correctamente");
                                                    break;
                                                }

                                                Console.WriteLine("Opción inválida");

                                            } while (true);

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;

                                        case 2:

                                            Console.WriteLine("===== PAQUETES =====");

                                            if (listaPaquetes.Count == 0)
                                            {
                                                Console.WriteLine("No existen paquetes registrados");
                                            }
                                            else
                                            {
                                                foreach (var item in listaPaquetes)
                                                {
                                                    item.MostrarInformacion();
                                                }
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;

                                        case 3:

                                            string codBuscar;

                                            Console.WriteLine("===== BUSCAR PAQUETE =====");

                                            do
                                            {
                                                Console.WriteLine("Ingrese el código del paquete:");

                                                codBuscar = Console.ReadLine();

                                                if (!string.IsNullOrWhiteSpace(codBuscar)
                                                    && codBuscar.Length <= 5)
                                                {
                                                    break;
                                                }

                                                Console.WriteLine("Código inválido");

                                            } while (true);

                                            int posBuscada = -1;

                                            for (int i = 0; i < listaPaquetes.Count; i++)
                                            {
                                                if (listaPaquetes[i].Codigo == codBuscar)
                                                {
                                                    posBuscada = i;
                                                    break;
                                                }
                                            }

                                            if (posBuscada != -1)
                                            {
                                                Console.WriteLine($"Paquete encontrado en la posición: {posBuscada}");

                                                listaPaquetes[posBuscada].MostrarInformacion();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Paquete no encontrado");
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;

                                        case 4:

                                            Console.WriteLine("===== ACTUALIZAR PAQUETE =====");

                                            Console.Write("Ingrese el código del paquete a modificar: ");

                                            string codModificar = Console.ReadLine();

                                            int posModificar = -1;

                                            for (int i = 0; i < listaPaquetes.Count; i++)
                                            {
                                                if (listaPaquetes[i].Codigo == codModificar)
                                                {
                                                    posModificar = i;
                                                    break;
                                                }
                                            }

                                            if (posModificar != -1)
                                            {
                                                Console.WriteLine("Paquete encontrado. Ingrese los nuevos datos:");

                                                do
                                                {
                                                    Console.WriteLine("Nueva descripción:");

                                                    string nuevaDescripcion = Console.ReadLine();

                                                    if (!string.IsNullOrWhiteSpace(nuevaDescripcion)
                                                        && nuevaDescripcion.Length <= 50)
                                                    {
                                                        listaPaquetes[posModificar].Descripcion = nuevaDescripcion;
                                                        break;
                                                    }

                                                    Console.WriteLine("Descripción inválida");

                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Nuevo peso:");

                                                    if (double.TryParse(Console.ReadLine(), out double nuevoPeso)
                                                        && nuevoPeso > 0)
                                                    {
                                                        listaPaquetes[posModificar].Peso = nuevoPeso;
                                                        break;
                                                    }

                                                    Console.WriteLine("Peso inválido");

                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Nuevo valor declarado:");

                                                    if (double.TryParse(Console.ReadLine(), out double nuevoValor)
                                                        && nuevoValor >= 0)
                                                    {
                                                        listaPaquetes[posModificar].ValorDeclarado = nuevoValor;
                                                        break;
                                                    }

                                                    Console.WriteLine("Valor declarado inválido");

                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Nueva dirección origen:");

                                                    string nuevaOrigen = Console.ReadLine();

                                                    if (!string.IsNullOrWhiteSpace(nuevaOrigen)
                                                        && nuevaOrigen.Length <= 50)
                                                    {
                                                        listaPaquetes[posModificar].DireccionOrigen = nuevaOrigen;
                                                        break;
                                                    }

                                                    Console.WriteLine("Dirección inválida");

                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Nueva dirección destino:");

                                                    string nuevaDestino = Console.ReadLine();

                                                    if (!string.IsNullOrWhiteSpace(nuevaDestino)
                                                        && nuevaDestino.Length <= 50)
                                                    {
                                                        listaPaquetes[posModificar].DireccionDestino = nuevaDestino;
                                                        break;
                                                    }

                                                    Console.WriteLine("Dirección inválida");

                                                } while (true);

                                                do
                                                {
                                                    Console.WriteLine("Seleccione el nuevo estado:");
                                                    Console.WriteLine("1. Admitido");
                                                    Console.WriteLine("2. En Camino");
                                                    Console.WriteLine("3. Entregado");

                                                    string opcionEstado = Console.ReadLine();

                                                    if (opcionEstado == "1")
                                                    {
                                                        listaPaquetes[posModificar].Estado = EstadoPaquete.Admitido;
                                                        break;
                                                    }
                                                    else if (opcionEstado == "2")
                                                    {
                                                        listaPaquetes[posModificar].Estado = EstadoPaquete.EnCamino;
                                                        break;
                                                    }
                                                    else if (opcionEstado == "3")
                                                    {
                                                        listaPaquetes[posModificar].Estado = EstadoPaquete.Entregado;
                                                        break;
                                                    }

                                                    Console.WriteLine("Opción inválida");

                                                } while (true);

                                                Console.WriteLine("¡Paquete actualizado exitosamente!");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Paquete no encontrado.");
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;

                                        case 5:

                                            Console.WriteLine("===== ELIMINAR PAQUETE =====");

                                            Console.Write("Ingrese el código del paquete a eliminar: ");

                                            string codEliminar = Console.ReadLine();

                                            int posEliminar = -1;

                                            for (int i = 0; i < listaPaquetes.Count; i++)
                                            {
                                                if (listaPaquetes[i].Codigo == codEliminar)
                                                {
                                                    posEliminar = i;
                                                    break;
                                                }
                                            }

                                            if (posEliminar != -1)
                                            {
                                                listaPaquetes.RemoveAt(posEliminar);

                                                Console.WriteLine("Paquete eliminado correctamente");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Paquete no encontrado");
                                            }

                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey();
                                            break;

                                        case 6:
                                            Console.WriteLine("Saliendo...");
                                            break;
                                        default:
                                            Console.WriteLine("Opción inválida");
                                            break;
                                    }
                                }
                            } while (op4 != 6);
                            break;
                        case 5:
                            //Entregas 
                            do
                            {
                                Console.WriteLine("===== ENTREGAS =====");
                                Console.WriteLine($"1. Nueva Entrega");
                                Console.WriteLine($"2. Mostrar Entregas");
                                Console.WriteLine($"3. Buscar Entrega");
                                Console.WriteLine($"4. Tiempo");
                                Console.WriteLine($"5. Borrar Entrega");
                                Console.WriteLine($"6. Salir");

                                if (!int.TryParse(Console.ReadLine(), out op5))
                                {
                                    Console.WriteLine($"Opcion no valida (No es un valor numerico)");
                                }
                                else
                                {
                                    switch (op5)
                                    {
                                        case 1:
                                            break;
                                        case 2:
                                            break;
                                        case 3:
                                            break;
                                        case 4:
                                            break;
                                        case 5:
                                            break;
                                        case 6:
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            } while (op5 != 6);
                            break;
                        case 6:
                            //Incidencias
                            break;
                        case 7: 
                            //Reportes
                            break;
                        case 8:
                            //Salir
                            break;
                        default:
                            break;
                    }
                }
                
            }while(op != 8);

        }
    }
}

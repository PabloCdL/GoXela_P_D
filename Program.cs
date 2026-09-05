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
            string codigo; string nombre; string numeroTelefonico; string direccion; string correo; int cantidadSoli;
            List<Clientes> listaClientes = new List<Clientes>();
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
                    Console.WriteLine($"Dato invalido... Intente de nuevo");
                }
                else 
                {
                    switch (op)
                    {
                        case 1:
                            //Clientes
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
                                    Console.WriteLine($"Opcion no valida (No es un valor numerico)");
                                } else
                                {
                                    switch(op1)
                                    {
                                        case 1:
                                            do
                                            {
                                                Console.WriteLine($"Ingrese el codigo");
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
                                                nombre = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(nombre) && nombre.Length <= 5)
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
                                                Console.WriteLine($"Ingrese el numero telefonico");
                                                numeroTelefonico = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(numeroTelefonico) && numeroTelefonico.Length <= 5)
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
                                                Console.WriteLine($"Ingrese la dirección");
                                                direccion = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(direccion) && direccion.Length <= 5)
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
                                                Console.WriteLine($"Ingrese el correo");
                                                correo = Console.ReadLine();
                                                if (!string.IsNullOrWhiteSpace(correo) && correo.Length <= 5)
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
                                                Console.WriteLine($"Ingrese la cantidad de solicitudes");
                                                if(!int.TryParse(Console.ReadLine(), out cantidadSoli))
                                                {
                                                    Console.WriteLine($"Dato no valido");
                                                }else
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

                                            listaClientes.Add(new Clientes(codigo, nombre, numeroTelefonico, direccion, correo, cantidadSoli));

                                            break;
                                        case 2:

                                            if(listaClientes.Count == 0)
                                            {
                                                Console.WriteLine($"No existen clientes registrados");
                                            }else
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
                            } while (op1 != 6);
                            
                            break;
                        case 2:
                            //Repartidores
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
                                            Console.WriteLine($"Opcion fuera de rango");
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
                                            Console.WriteLine($"Opcion fuera de rango");  
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

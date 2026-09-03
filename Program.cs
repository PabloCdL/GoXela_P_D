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

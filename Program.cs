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
            int op;
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
                            break;
                        case 2:
                            //Repartidores
                            break;
                        case 3:
                            //Vehículos
                            break;
                        case 4:
                            //Paquetes
                            break;
                        case 5:
                            //Entregas 
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

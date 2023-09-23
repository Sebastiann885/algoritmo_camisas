using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_ProgramaII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su nombre: ");
            String Nombre = Console.ReadLine();

            Console.WriteLine($"Bienvenido {Nombre}. Por favor ingrese la cantidad de camisas que desea comprar: ");
            int cantidadcamisas = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el precio por camisa: ");
            double Preciocamisa = double.Parse(Console.ReadLine());

            //Calcula el precio de la camisa sin descuento

            double PrecioTotal = cantidadcamisas * Preciocamisa;

            //Lo que hace es determinar el descuento de las camisas

            if (cantidadcamisas == 1)
            {
                // No hay descuento
                Console.WriteLine($"El precio total es: ${PrecioTotal:F2}");
            }
            else if (cantidadcamisas >= 2 && cantidadcamisas <= 5)
            {
                // Descuento del 15%
                double descuento = 0.15 * PrecioTotal;
                double precioFinal = PrecioTotal - descuento;
                Console.WriteLine($"El precio total con descuento del 15% es: ${precioFinal:F2}");
            }
            else
            {
                // Descuento del 20%
                double descuento = 0.20 * PrecioTotal;
                double precioFinal = PrecioTotal - descuento;
                Console.WriteLine($"El precio total con descuento del 20% es: ${precioFinal:F2}");

                
            }Console.ReadLine();
        }
    }
}


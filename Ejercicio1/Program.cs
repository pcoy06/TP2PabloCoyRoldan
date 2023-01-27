using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
             float valorprod, iva, valorFinal;


             Console.WriteLine("-------------------Bienvenido!------------------------\n");

             Console.Write("Por favor ingrese el valor del Producto elegido: $ ");
             valorprod = float.Parse(Console.ReadLine());

             iva = valorprod * 0.21f;
             valorFinal = valorprod + iva;

             Console.WriteLine("El IVA es de: $ " + iva);
             Console.WriteLine("El precio final a pagar con IVA es de: $ " + valorFinal);

             Console.ReadKey();
            
        }
        

        
    }
}

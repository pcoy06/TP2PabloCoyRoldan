using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {

        

        static void Main(string[] args)
        {
            
            float valorIva, precioCompra;
            
            Console.WriteLine("-------------------Bienvenidos!------------------------\n");
            Console.Write("Por favor ingrese el valor del Producto elegido: $ ");
            precioCompra = float.Parse(Console.ReadLine());

            valorIva = CalcularIva(precioCompra);

            Console.WriteLine("El valor final con IVA(21%) es de: $ " + (precioCompra + valorIva));
            Console.ReadKey();
        }
        static float CalcularIva(float p)
        {
            float IVA;
            IVA = p * 0.21f;
            return IVA;
        }

                
       
        
       

    }
}

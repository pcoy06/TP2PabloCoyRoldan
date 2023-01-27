using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while(num <= 100)
            {

                if (num % 2 != 0) 
                    
                    Console.WriteLine("Número del 0 al 100 no divisible por 2: " + num);
                                    
                num++;

            }
            Console.ReadKey();
        }
    }
}

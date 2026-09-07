using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recursividad.Logica;

namespace Recursividad.UI.CONSOLA
{
    public class Program 
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("\n Casos de recursividad");
            Console.WriteLine("\n Factorial de un número");

            Factorial oFactorial = new Factorial();
            int resultado = oFactorial.MiFactorial(6);
            Console.WriteLine($"El factorial de 6 es: {resultado}");


            Console.ReadKey();
        }
    }
}

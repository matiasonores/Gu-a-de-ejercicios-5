using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite una lista de números que corta cuando se
         //ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
         //en la que fue ingresado.

         int n, mayor = 0,contador=1,posicionMayor=0;

         Console.WriteLine("Ingrese valores para encontrar el mayor número (Ingrese 0 para salir):");
         n = int.Parse(Console.ReadLine());
         while (n != 0)
         {
            if (n > mayor)
            {
               mayor = n;
               posicionMayor = contador;
            }
            contador++;
            n = int.Parse(Console.ReadLine());
         }
         Console.WriteLine("El número de mayor valor ingresado es: {0} y su posición fue {1}", mayor, posicionMayor);
         Console.ReadKey();
      }
   }
}

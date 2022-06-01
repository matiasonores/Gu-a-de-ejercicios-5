using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite una lista de números que corta cuando se
         //ingresa un cero y luego emitir por pantalla el máximo de los números
         //negativos y el mínimo de los números positivos.

         int n, mayorNegativo=0, menorPositivo=0;
         bool n1=true;
         bool p1=true;

         Console.WriteLine("Ingrese valores, oprima 0 para salir:");

         n = int.Parse(Console.ReadLine());

         while (n != 0)
         {
            if (p1 && n > 0)
            {
               menorPositivo = n;
               p1 = false;
            }
            else if (n > 0 && n < menorPositivo)
               menorPositivo = n;
            else if (n1 && n < 0)
            {
               mayorNegativo = n;
               n1 = false;
            }
            else if (n < 0 && n > mayorNegativo)
               mayorNegativo = n;

            n = int.Parse(Console.ReadLine());
         }
         Console.WriteLine("El mayor de los números negativos fue: {0}",mayorNegativo);
         Console.WriteLine("El menor de los números positivos fue: {0}",menorPositivo);
         Console.ReadKey();
      }
   }
}

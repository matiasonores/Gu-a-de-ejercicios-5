using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
   class Program
   {
      static void Main(string[] args)
      {
         //Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la
         //posición en la que fue encontrado cada uno de los mínimos.

         int n, menor = 0, segundoMenor = 0, contador=1, posicionMenor=0, posicionSegundoMenor=0;
         bool m1 = true;
         bool m2 = true;

         Console.WriteLine("Ingrese valores para encontrar el menor número y el segundo menor número (Ingrese 0 para salir):");
         n = int.Parse(Console.ReadLine());
         while (n != 0)
         {
            if (m1)
            {
               menor = n;
               posicionMenor = contador;
               m1 = false;
            }
            else if (n < menor)
            {
               menor = n;
               posicionMenor = contador;
            }
            else if (m2) 
            { 
               segundoMenor = n;
               posicionSegundoMenor = contador;
               m2 = false;
            }
            else if (n<segundoMenor)
            {
               segundoMenor = n;
               posicionSegundoMenor = contador;
            }
            contador++;
            n = int.Parse(Console.ReadLine());
         }
         Console.WriteLine("El número de menor valor ingresado es: {0} y su posición fue: {1}", menor, posicionMenor);
         Console.WriteLine("El número de segundo menor valor ingresado es: {0} y su posición fue: {1}", segundoMenor,posicionSegundoMenor);
         Console.ReadKey();
      }
   }
}

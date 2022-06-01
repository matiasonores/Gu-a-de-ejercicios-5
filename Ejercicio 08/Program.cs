using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite una lista de números que corta cuando se
         //ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

         int n, menor = 0,segundoMenor=0;

         Console.WriteLine("Ingrese valores para encontrar el menor número y el segundo menor número (Ingrese 0 para salir):");
         n = int.Parse(Console.ReadLine());
         while (n != 0)
         {
            if (menor == 0 && segundoMenor == 0)
            {
               menor = n;
               segundoMenor = n + 1;
            }
            if (n < menor && n < segundoMenor)
               menor = n;
            else if (n < segundoMenor && n > menor)
               segundoMenor = n;

            n = int.Parse(Console.ReadLine());
         }
         Console.WriteLine("El número de menor valor ingresado es: {0}, el número con el segundo menor valor es: {1}", menor, segundoMenor);
         Console.ReadKey();
      }
   }
}

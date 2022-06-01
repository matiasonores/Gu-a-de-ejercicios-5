using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite UN número y luego calcule y emita un cartel
         //aclaratorio si el mismo es primo o no es primo.
         //Nota: usando While. Ya lo hicimos con FOR, ahora con While.

         int n,x;
         bool noPrimo = false;

         Console.WriteLine("Ingrese un número para saber si es primo:");
         n = int.Parse(Console.ReadLine());
         x = 2;
         while (x<n)
         {
            if (n % x == 0)
               noPrimo = true;
            x++;
         }
         if(noPrimo)
         Console.WriteLine("No es primo");
         else
            Console.WriteLine("Es primo");

         Console.ReadKey();
      }
   }
}

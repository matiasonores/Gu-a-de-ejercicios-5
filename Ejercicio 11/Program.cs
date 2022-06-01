using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para ingresar una lista de números que corta cuando se
         //ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
         //números pares, la cantidad de positivos y la cantidad de negativos.

         int n,x=1, negativos = 0, positivos = 0,pares=0,primos=0;
         bool noPrimo = true;

         Console.WriteLine("Ingrese valores, oprima 0 para salir:");

         n = int.Parse(Console.ReadLine());

         while (n != 0)
         {
            if (n % 2 == 0)
               pares++;
            else if (n < 0)
               negativos++;

            else if (n > 0)
            {
               positivos++;
               while (x < n)
               {
                  if (n % x == 0)
                     noPrimo = false;

                  x++;
               }
            }
            if (!noPrimo||n==1)
            {
               primos++;
               
            }
            x = 1;
            noPrimo = true;
            n = int.Parse(Console.ReadLine());
         }
         Console.WriteLine("La cantidad de números negativos fue: {0}", negativos);
         Console.WriteLine("La cantidad de números positivos fue: {0}", positivos);
         Console.WriteLine("La cantidad de números pares fue: {0}", pares);
         Console.WriteLine("La cantidad de números primos fue: {0}", primos);
         Console.ReadKey();
      }
   }
}
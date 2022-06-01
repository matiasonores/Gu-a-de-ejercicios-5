using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para mostrar los números del 10 al 1. No se debe realizar ningún pedido de datos. USANDO WHILE.

         int x = 10;

         while (x > 1)
         {
            Console.WriteLine(x);
            x--;
         }
         Console.ReadKey();
      }
   }
}

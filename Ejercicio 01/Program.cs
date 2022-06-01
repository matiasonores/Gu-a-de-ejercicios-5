using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos. USANDO WHILE.

         int x=0;

         while (x < 10)
         {
            x++;
            Console.WriteLine(x);
         }
         Console.ReadKey();
      }
   }
}

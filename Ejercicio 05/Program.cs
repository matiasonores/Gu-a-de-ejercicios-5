﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo: 0, 5, 10, 15, 20....100.Usando While.

         int n=0;

         while (n < 100)
         {
            n += 5;
            Console.WriteLine(n);
         }
         Console.ReadKey();
      }
   }
}

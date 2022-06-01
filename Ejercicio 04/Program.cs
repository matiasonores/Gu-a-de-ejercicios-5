using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite dos números y luego muestre los números
         //entre el menor y el mayor de ellos. Acordate, usando While.

         int a, b,rango;
         Console.WriteLine("Ingrese un valor para A:");
         a = int.Parse(Console.ReadLine());
         Console.WriteLine("Ingrese un valor para B:");
         b = int.Parse(Console.ReadLine());

         if (a > b)
         {
            Console.WriteLine("Los valores entre B y A son:");
            rango = b+1;
            while (rango < a)
            {
               Console.WriteLine(rango);
               rango++;
            }
         }
         else
         {
            Console.WriteLine("Los valores entre A y B son:");
            rango = a+1;
            while (rango < b)
            {
               Console.WriteLine(rango);
               rango++;
            }
         }
         Console.ReadKey();
      }
   }
}

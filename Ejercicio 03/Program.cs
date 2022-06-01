using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
   class Program
   {
      static void Main(string[] args)
      {
         //Hacer un programa que solicite la edad de un grupo de personas. El programa
         //deberá pedir edades hasta que se ingrese una edad menor a 18 años.Deberá
         //mostrar por pantalla cuántas personas mayores se registraron.

         int edad,mayores=0;

         Console.WriteLine("Ingrese las valores para las edades:");
         edad = int.Parse(Console.ReadLine());

         while (edad>=18)
         {
            mayores++;
            edad = int.Parse(Console.ReadLine());
         }
         Console.WriteLine("El valor ingresado corresponde al de un menor, la cantidad de adultos es de:");
         Console.WriteLine(mayores);
         Console.ReadKey();
      }
   }
}

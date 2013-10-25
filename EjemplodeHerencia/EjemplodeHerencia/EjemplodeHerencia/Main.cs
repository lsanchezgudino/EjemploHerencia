using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace EjemplodeHerencia
{
    class PruebaConstructor
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejemplo de herencia";
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
            EmpleadoPorComision4 empleado1 = new EmpleadoPorComision4("Bob",
   		"Lewis", "333-33-3333", 5000.00M, .04M);
 
            Console.WriteLine();
            EmpleadoBaseMasComision5 empleado2 =
               new EmpleadoBaseMasComision5("Lisa", "Jones",
               "555-55-5555", 2000.00M, .06M, 800.00M);
 
            Console.WriteLine();
            EmpleadoBaseMasComision5 empleado3 =
               new EmpleadoBaseMasComision5("Mark", "Sands",
               "888-88-8888", 8000.00M, .15M, 2000.00M);
            Console.ReadLine();
        }
    }
}
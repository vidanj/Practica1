using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

           // Trabajador trabajadorX = new Trabajador();
            Console.WriteLine();
            Jefe Jefe1 = new Jefe();
            Console.WriteLine();
            Supervisor Super1 = new Supervisor();
            Console.WriteLine();
            Empleado Empl1 = new Empleado();

           // trabajadorX.IngresarNombre("X");
            Jefe1.IngresarNombre("Pancho lopez");
            Super1.IngresarNombre("Esequiel Loquiere");
            Empl1.IngresarNombre("Bob Wulf");

            Console.WriteLine();

          //  Console.WriteLine(trabajadorX.Registrar());
            Console.WriteLine(Jefe1.Registrar());
            Console.WriteLine(Empl1.Registrar());
            Console.WriteLine(Super1.Registrar());

            Console.WriteLine();

            Console.WriteLine(Jefe1.Reportarse());
            Console.WriteLine(Empl1.Reportarse());
            Console.WriteLine(Super1.Reportarse());
            //  Console.WriteLine(trabajadorX.Reportarse());

            Console.WriteLine();

            Console.WriteLine(Jefe1.Ensamblar());
            Console.WriteLine(Empl1.Ensamblar());
            Console.WriteLine(Super1.Ensamblar());

            Console.WriteLine();

            Console.WriteLine(Jefe1.Inspeccionar());
            Console.WriteLine(Empl1.Inspeccionar());
            Console.WriteLine(Super1.Inspeccionar());

            Console.ReadKey();
        }
    }
}

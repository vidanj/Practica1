using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Empleado : Trabajador
    {
        bool tiempoCompleto;
        float sueldo;

        public Empleado()
        {
            System.Console.WriteLine("Instancia Empleado.");
        }
    }
}

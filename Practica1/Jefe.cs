using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Jefe : Trabajador
    {
        string area;
        Supervisor delegado;

        public Jefe()
        {
            System.Console.WriteLine("Instancia Jefe.");
        }
    }
}

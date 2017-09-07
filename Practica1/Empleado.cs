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

        public override int Ensamblar()
        {
            System.Console.WriteLine("Empleado " + this.nomb + " esta ensamblando");
            return 1;
        }

        public override int Inspeccionar()
        {
            System.Console.WriteLine("Empleado " + this.nomb + " esta Reportando");
            return 2;
        }

        public override ListaReporte Reportar()
        {
            throw new NotImplementedException();
        }
    }
}

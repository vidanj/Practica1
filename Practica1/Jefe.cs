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

        public override int Ensamblar()
        {
            System.Console.WriteLine("Jefe " + this.nomb + " esta ensamblando");
            return 1;
        }

        public override int Inspeccionar()
        {
            System.Console.WriteLine("Jefe " + this.nomb + " esta Reportando");
            return 2;
        }

        public override ListaReporte Reportar()
        {
            throw new NotImplementedException();
        }
    }
}

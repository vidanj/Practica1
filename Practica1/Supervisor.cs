using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Supervisor : Trabajador
    {
        string area;
        string horario;
        
        public Supervisor()
        {
            System.Console.WriteLine("Instancia Supervisor.");
        }

        public override int Ensamblar()
        {
            System.Console.WriteLine("Supervisor " + this.nomb + " esta ensamblando");
            return 1;
        }

        public override int Inspeccionar()
        {
            System.Console.WriteLine("Supervisor " + this.nomb + " esta Reportando");
            return 2;
        }

        public override ListaReporte Reportar()
        {
            throw new NotImplementedException();
        }
    }
}

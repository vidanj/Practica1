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
    }
}

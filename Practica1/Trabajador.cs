using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public enum Puestos
    {
        Gerente,
        JefeArea,
        Operador
    }

    public abstract class Trabajador:IEnsamblar
    {

        protected string nomb;
        protected string apPaterno;
        protected string apMaterno;
        protected string email;
        protected Puestos puesto;

        public Trabajador()
        {
            System.Console.WriteLine("Instancia Trabajador.");
        }

        public void IngresarNombre(string nombre)
        {
            this.nomb = nombre;
        }

        public string Registrar()
        {
            return nomb + " esta registrado.";
        }
                
        public string Reportarse()
        {
            return "Se Reporto "+ this.nomb;
        }


        public abstract int Ensamblar();
        public abstract int Inspeccionar();
        public abstract ListaReporte Reportar();
    }
}

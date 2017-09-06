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

    public  class Trabajador:IEnsamblar
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

        public int Ensamblar()
        {
            return 1;
        }

        public int Inspeccionar()
        {
            return 2;
        }
        public string Reportar()
        {
            return "Se Reporto "+ this.nomb;
        }
    }
}

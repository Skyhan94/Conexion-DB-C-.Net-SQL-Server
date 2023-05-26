using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Modelos
{
    internal class Persona
    {
        private int Cedula;

        public string Nombres;

        public string Apellidos;

        public string Telefono;

        public string Direccion;

        public Persona (int cedula, string nombres, string apellidos, string telefono, string direccion)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}

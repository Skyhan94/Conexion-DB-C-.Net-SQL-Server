using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Modelos
{
    internal class Visitante : Persona
    {
        private int idVisitante;

        public string HoraDeIngreso;
    
        public Visitante (int idVisitante, string horadeingreso, int cedula, string nombres, string apellidos, string telefono, string direccion)
            : base (cedula, nombres, apellidos, telefono, direccion)
        {
            this.idVisitante = idVisitante;

            HoraDeIngreso = horadeingreso;
        }
    }

}

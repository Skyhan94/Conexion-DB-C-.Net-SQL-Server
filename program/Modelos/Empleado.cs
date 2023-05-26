using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Modelos
{
    public class Empleado : Usuario
    {
        private int idEmpleado;

        public string Cargo;

        public Empleado (int idEmpleado, string cargo, int cedula, string nombres, string apellidos, string contraseña, string direccion, string telefono, string email)
            : base(cedula, nombres, apellidos, contraseña, direccion, telefono, email)
        {   
            this.idEmpleado = idEmpleado;

            Cargo = cargo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Modelos
{
    internal class Paciente : Persona
    {
        private int idPaciente;

        public string Padecimiento;

        public string FechaDeIngreso;

        public Paciente (int idPaciente, string padecimiento, string fechaDeIngreso, int cedula, string nombres, string apellidos, string telefono, string direccion)
            : base (cedula, nombres, apellidos, telefono, direccion)
        {
            this.idPaciente = idPaciente;

            Padecimiento = padecimiento;

            FechaDeIngreso = fechaDeIngreso;

        }
    }
}

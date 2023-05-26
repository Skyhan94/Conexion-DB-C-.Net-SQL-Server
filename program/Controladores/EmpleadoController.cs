using preAplicacion.Modelos;
using preAplicacion.Servicios;
using preAplicacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Controladores
{
    public class EmpleadoController
    {
        private EmpleadoServices services;

        private EmpleadoViews views;

        public EmpleadoController()
        {
            this.services = new EmpleadoServices();

            this.views = new EmpleadoViews();
        }

        public void RegistrarPersona()
        {
            int result = this.services.RegistrarPersona();

            if(result == 0)
            {
                this.views.RegistrarPaciente();
            }
            else if(result == 1)
            {
                this.views.RegistrarVisitante();
            }
            else if(result == 2)
            {
                this.views.LanzarError();
            }
            else
            {
                this.views.LanzarError();
            }
        }
    }
}

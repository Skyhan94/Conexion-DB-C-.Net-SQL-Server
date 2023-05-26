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
    public class UsuarioController
    {
        private UsuarioServices usuarioServices;

        private UsuarioView usuarioView;

        public UsuarioController()
        {
            this.usuarioServices = new UsuarioServices();

            this.usuarioView = new UsuarioView();
        }
        public void Agregar()
        {
            int result = this.usuarioServices.Agregar();

            if(result == 0)
            {
                this.usuarioView.Agregar();
            }
            else
            {
                this.usuarioView.LanzarError();
            }
        }

        public void Eliminar()
        {
            int result = this.usuarioServices.Eliminar();

            if(result == 0)
            {
                this.usuarioView.Eliminar();
            }
            else if(result == 1)
            {
                this.usuarioView.NoEliminar();
            }
            else
            {
                this.usuarioView.LanzarError();
            }
        }
    }
}

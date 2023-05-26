using preAplicacion.Modelos;
using preAplicacion.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Vistas
{
    public class UsuarioView
    {
        public void Agregar()
        {
            Console.WriteLine("El usuario ha sido registrado correctamente...");
        }

        public void Eliminar()
        {
            Console.WriteLine("El usuario seleccionado ha sido Eliminado...");
        }

        public void NoEliminar()
        {
            Console.WriteLine("No se ha eliminado el usuario seleccionado...");
        }

        public void LanzarError()
        {
            Console.WriteLine("Error....");
        }
    }
}

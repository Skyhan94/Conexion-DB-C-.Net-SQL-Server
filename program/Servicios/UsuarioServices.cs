using preAplicacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Servicios
{
    public class UsuarioServices
    {
        private Usuario usuario;

        public int cedula;

        //Usuario diccionario
        Dictionary<int, string> nombres = new Dictionary<int, string>();
        Dictionary<int, string> apellidos = new Dictionary<int, string>();
        Dictionary<int, string> contraseñas = new Dictionary<int, string>();
        Dictionary<int, string> direcciones = new Dictionary<int, string>();
        Dictionary<int, string> telefonos = new Dictionary<int, string>();
        Dictionary<int, string> emails = new Dictionary<int, string>();

        public int Agregar()
        {
            //Crear usuario

            Console.WriteLine("Ingresa el numero de identificacion del usuario: ");
            cedula = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa los nombres del usuario: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa los apellidos del usuario: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresa la contraseña del usuario: ");
            string contraseña = Console.ReadLine();
            Console.WriteLine("Ingresa la direccion del usuario: ");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingresa el telefono del usuario: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingresa el email del usuario: ");
            string email = Console.ReadLine();


            usuario = new Usuario(cedula, nombre, apellido, contraseña, direccion, telefono, email);

            nombres.Add(cedula, usuario.Nombres);
            apellidos.Add(cedula, usuario.Apellidos);
            contraseñas.Add(cedula, usuario.Contraseña);
            direcciones.Add(cedula, usuario.Direccion);
            telefonos.Add(cedula, usuario.Telefono);
            emails.Add(cedula, usuario.Email);

            return 0;
        }

        public void MostrarUsuarioAgregado()
        {
            Console.WriteLine("Nombre: " + nombres[cedula] + " " + apellidos[cedula] + "\nContraseña: " + contraseñas[cedula] + "\nDireccion: " + direcciones[cedula] + "\nTelefono: " + telefonos[cedula] + "\nEmail: " + emails[cedula]);
        }

        public int Eliminar()
        {
            Console.WriteLine("Ingrese el numero de cedula del usuario que desea eliminar: ");
            int idUsuario = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Se eliminara el siguiente usuario: " + "\nNombre: " + nombres[idUsuario] + " " + apellidos[idUsuario] + "\nContraseña: " + contraseñas[idUsuario] + "\nDireccion: " + direcciones[idUsuario] + "\nTelefono: " + telefonos[idUsuario] + "\nEmail: " + emails[idUsuario]);

            Console.WriteLine("\nDesea continuar?  1. Si 2. No");
            int option = Int32.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    nombres.Remove(idUsuario);
                    apellidos.Remove(idUsuario);
                    contraseñas.Remove(idUsuario);
                    direcciones.Remove(idUsuario);
                    telefonos.Remove(idUsuario);
                    emails.Remove(idUsuario);

                    return 0;

                case 2:

                    return 1;

                default:

                    return 2;
            }

            

        }
    }
}

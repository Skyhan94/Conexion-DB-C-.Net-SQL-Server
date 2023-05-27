using preAplicacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace preAplicacion.Servicios
{
    public class UsuarioServices
    {
        private Usuario usuario;

        int retorno = 0;


        //Usuario diccionario
        //Dictionary<int, string> nombres = new Dictionary<int, string>();
        //Dictionary<int, string> apellidos = new Dictionary<int, string>();
        //Dictionary<int, string> contraseñas = new Dictionary<int, string>();
        //Dictionary<int, string> direcciones = new Dictionary<int, string>();
        //Dictionary<int, string> telefonos = new Dictionary<int, string>();
        //Dictionary<int, string> emails = new Dictionary<int, string>();

        public int Agregar()
        {
            //Crear usuario

            Console.WriteLine("Ingresa el numero de identificacion del usuario: ");
            int cedula = Int32.Parse(Console.ReadLine());
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
 
            

            using (SqlConnection Conect = Conexion.ConectarBD())
            {
                
                SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Usuarios (Cedula, Nombres, Apellidos, Contraseñas, Direccion, Telefonos, Emails) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", 
                   cedula, nombre, apellido, contraseña, direccion, telefono, email), Conect);

                retorno = comando.ExecuteNonQuery();
                Conect.Close();
            }

            return retorno;

            //nombres.Add(cedula, usuario.Nombres);
            //apellidos.Add(cedula, usuario.Apellidos);
            //contraseñas.Add(cedula, usuario.Contraseña);
            //direcciones.Add(cedula, usuario.Direccion);
            //telefonos.Add(cedula, usuario.Telefono);
            //emails.Add(cedula, usuario.Email);
        }

        public void MostrarUsuarioAgregado()
        {
            using (SqlConnection Conect = Conexion.ConectarBD())
            {
                string cadena = "SELECT * FROM Usuarios";
                try
                {
                    SqlCommand comando = new SqlCommand(cadena, Conect);
                    SqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Console.WriteLine(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString() + " " + lector.GetValue(4).ToString() + " " + lector.GetValue(5).ToString() + " " + lector.GetValue(6).ToString());
                    }

                    Conect.Close();
                }
                catch
                {
                    Console.WriteLine("Error al ejecutar la consulta");
                }
            }
            
        }

        public int Eliminar()
        {
            Console.WriteLine("Ingrese el numero de cedula del usuario que desea eliminar: ");
            int idUsuario = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nDesea continuar?  1. Si 2. No");
            int option = Int32.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    using (SqlConnection Conect = Conexion.ConectarBD())
                    {

                        SqlCommand comando = new SqlCommand(string.Format("DELETE FROM Usuarios WHERE Cedula = {0}", idUsuario), Conect);

                        retorno = comando.ExecuteNonQuery();
                        Conect.Close();
                    }
                    //nombres.Remove(idUsuario);
                    //apellidos.Remove(idUsuario);
                    //contraseñas.Remove(idUsuario);
                    //direcciones.Remove(idUsuario);
                    //telefonos.Remove(idUsuario);
                    //emails.Remove(idUsuario);

                    return retorno;

                case 2:

                    return 2;

                default:

                    return 1;
            }

            

        }
    }
}

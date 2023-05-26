using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Modelos
{
    public class Usuario
    {
        private int Cedula;

        public string Nombres;

        public string Apellidos;

        public string Contraseña;

        public string Direccion;

        public string Telefono;

        public string Email;

        public Usuario(int cedula, string nombres, string apellidos, string contraseña, string direccion, string telefono, string email)
        {
            Cedula = cedula;

            Nombres = nombres;

            Apellidos = apellidos;

            Contraseña = contraseña;

            Direccion = direccion;

            Telefono = telefono;

            Email = email;
        }


        public void setCedula(int cedula)
        {
            this.Cedula = cedula;
        }

        public int getCedula()
        {
            return this.Cedula;
        }

        public void setNombres(string nombres)
        {
            this.Nombres = nombres;
        }

        public string getNombres()
        {
            return this.Nombres;
        }

        public void setApellidos(string apellidos)
        {
            this.Apellidos = apellidos;
        }

        public string getApellidos()
        {
            return this.Apellidos;
        }

        public void setContraseña(string contraseña)
        {
            this.Contraseña = contraseña;
        }

        public string getContraseña()
        {
            return this.Contraseña;
        }

        public void setDireccion(string direccion)
        {
            this.Direccion = direccion;
        }

        public string getDireccion()
        {
            return this.Direccion;
        }

        public void setTelefono (string telefono)
        {
            this.Telefono = telefono;
        }

        public string getTelefono()
        {
            return this.Telefono;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        public String getEmail()
        {
            return this.Email;
        }
    }
}

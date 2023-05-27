using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace preAplicacion
{
    public class Conexion
    {
        public static SqlConnection ConectarBD()
        {
            SqlConnection conect = new SqlConnection("Data source=DESKTOP-LT8JBCT\\SQLEXPRESS;Initial Catalog=RegistroHospital; Integrated Security=True");
            conect.Open();

            return conect;
        }

        //string CadenaConexion = "Data source=DESKTOP-LT8JBCT\\SQLEXPRESS;Initial Catalog=RegistroHospital; Integrated Security=True";
        //public SqlConnection Connection = new SqlConnection();
        //public Conexion()
        //{
        //    Connection.ConnectionString = CadenaConexion;
        //}

        //public void Abrir()
        //{
        //    try 
        //    { 
        //        Connection.Open();
        //        Console.WriteLine("Conexion abierta");
        //    } 
        //    catch 
        //    {
        //        Console.WriteLine("No se pudo establecer conexion");
        //    }

        //}
    }
}

using Microsoft.VisualBasic;
using preAplicacion.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preAplicacion.Servicios
{
    
    public class EmpleadoServices
    {
        private Paciente paciente;

        private Visitante visitante;

        //diccionarios pacientes
        Dictionary<int, string> documentosPacientes = new Dictionary<int, string>();
        Dictionary<int, string> nombresPacientes = new Dictionary<int, string>();
        Dictionary<int, string> apellidosPacientes = new Dictionary<int, string>();
        Dictionary<int, string> telefonosPacientes = new Dictionary<int, string>();
        Dictionary<int, string> direccionPacientes = new Dictionary<int, string>();
        Dictionary<int, string> padecimientoPacientes = new Dictionary<int, string>();
        Dictionary<int, string> fechaIngresoPacientes = new Dictionary<int, string>();

        //diccionarios visitantes
        Dictionary<int, string> nombresVisitantes = new Dictionary<int, string>();
        Dictionary<int, string> documentosVisitantes = new Dictionary<int, string>();
        Dictionary<int, string> apellidosVisitantes = new Dictionary<int, string>();
        Dictionary<int, string> telefonosVisitantes = new Dictionary<int, string>();
        Dictionary<int, string> direccionVisitantes = new Dictionary<int, string>();
        Dictionary<int, string> horaIngresoVisitantes = new Dictionary<int, string>();

        public int RegistrarPersona()
        {

            int persona;

            Console.WriteLine("¿Desea registrar un paciente o un visitante?  1. Paciente 2. Visitante");
            persona = Int32.Parse(Console.ReadLine());

            switch (persona)
            {
                case 1:

                    Console.WriteLine("Ingrese el id del paciente: ");
                    int idPaciente = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el padecimiento o enfermedad del paciente: ");
                    string padecimiento = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de ingreso: ");
                    string fechaIngreso = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del paciente: ");
                    int cedulaPaciente = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese los nombres del paciente: ");
                    string nombresPaciente = Console.ReadLine();
                    Console.WriteLine("Ingrese los apellidos del paciente: ");
                    string apellidosPaciente = Console.ReadLine();
                    Console.WriteLine("Ingrese el telefono del paciente: ");
                    string telefonoPaciente = Console.ReadLine();
                    Console.WriteLine("Ingrese la direccion del paciente: ");
                    string direccionPaciente = Console.ReadLine();



                    paciente = new Paciente(idPaciente, padecimiento, fechaIngreso, cedulaPaciente, nombresPaciente, apellidosPaciente, telefonoPaciente, direccionPaciente);

                    documentosPacientes.Add(idPaciente, cedulaPaciente.ToString());
                    nombresPacientes.Add(idPaciente, nombresPaciente);
                    apellidosPacientes.Add(idPaciente, apellidosPaciente);
                    fechaIngresoPacientes.Add(idPaciente, fechaIngreso);
                    padecimientoPacientes.Add(idPaciente, padecimiento);
                    telefonosPacientes.Add(idPaciente, telefonoPaciente);
                    direccionPacientes.Add(idPaciente, direccionPaciente);

                    return 0;


                case 2:

                    Console.WriteLine("Ingrese el id del visitante: ");
                    int idVisitante = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la fecha y hora de ingreso: ");
                    string horaIngreso = Console.ReadLine();
                    Console.WriteLine("Ingrese el documento del visitante: ");
                    int cedulaVisitante = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese los nombres del visitante: ");
                    string nombresVisitante = Console.ReadLine();
                    Console.WriteLine("Ingrese los apellidos del visitante: ");
                    string apellidosVisitante = Console.ReadLine();
                    Console.WriteLine("Ingrese el telefono del visitante: ");
                    string telefonoVisitante = Console.ReadLine();
                    Console.WriteLine("Ingrese la direccion del visitante: ");
                    string direccionVisitante = Console.ReadLine();


                    visitante = new Visitante(idVisitante, horaIngreso, cedulaVisitante, nombresVisitante, apellidosVisitante, telefonoVisitante, direccionVisitante);

                    documentosVisitantes.Add(idVisitante, cedulaVisitante.ToString());
                    nombresVisitantes.Add(idVisitante, nombresVisitante);
                    apellidosVisitantes.Add(idVisitante, apellidosVisitante);
                    horaIngresoVisitantes.Add(idVisitante, horaIngreso);
                    telefonosVisitantes.Add(idVisitante, telefonoVisitante);
                    direccionPacientes.Add(idVisitante, direccionVisitante);

                    return 1;



                default:

                    return 2;
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information
using preAplicacion.Modelos;
using preAplicacion.Servicios;

Console.WriteLine("Iniciar Programa...");
preAplicacion.Controladores.UsuarioController usuarioController = new preAplicacion.Controladores.UsuarioController();  
usuarioController.Agregar();
preAplicacion.Controladores.EmpleadoController empleadoController = new preAplicacion.Controladores.EmpleadoController();
empleadoController.RegistrarPersona();
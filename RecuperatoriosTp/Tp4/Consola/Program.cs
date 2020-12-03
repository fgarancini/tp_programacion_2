using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using Archivos;
using ServerDAO;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("UTNFRA");
            Usuario usuario = new Usuario("Franco123","nisman94");
            Usuario usuario2 = new Usuario("ReyDeLcHipI","nisman94");
            Asesina asesina = new Asesina(25, "Rayito", Personaje.EReino.Normal);
            Barbaro barbaro = new Barbaro(9, "Alijo", Personaje.EReino.Normal);
            Amazona amazona = new Amazona(99, "Javazon", Personaje.EReino.Infierno);
            Paladin paladin = new Paladin(80, "Turco", Personaje.EReino.Pesadilla);

            usuario2.AgregarPersonaje(asesina);
            usuario2.AgregarPersonaje(barbaro);
            usuario.AgregarPersonaje(paladin);
            usuario.AgregarPersonaje(amazona);


            _ = server + usuario;
            _ = server + usuario2;

            try
            {
                usuario.AgregarPersonaje(amazona);
            }
            catch (PersonajeYaExisteException ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {

                server.Serializar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                SqlServer sqlServer = new SqlServer();
                sqlServer.InsertarDatos(server, usuario, amazona);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(usuario.DatosCompletos());
            Console.WriteLine(usuario2.DatosCompletos());

            foreach (Usuario usuario1 in server.Usuarios)
            {
                foreach (Personaje personaje in usuario1.Personajes)
                {

                }
            }
            //Console.WriteLine("No se pudo agregar");

            Console.ReadKey();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;
using System.Security.AccessControl;
using ServerDAO;
namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(PersonajeYaExisteException))]
        public void AgregarPersonajeTest()
        {
            Usuario usuario = new Usuario("D2","123456");
            Amazona amazona = new Amazona(99,"Amazona",Personaje.EReino.Infierno);
            Asesina asesina = new Asesina(99,"Amazona",Personaje.EReino.Infierno);
            _ = usuario + amazona;
            _ = usuario + asesina;
        }

        [TestMethod]
        [ExpectedException(typeof(PersonajeSinNombre))]
        public void AgregarPersonajeSinNombre()
        {
            Amazona amazona = new Amazona(1, "", Personaje.EReino.Infierno);
        }

        [TestMethod]
        [ExpectedException(typeof(CuentaExisteException))]

        public void AgregarCuenta()
        {
            Server server = new Server("UTNFRA");
            Usuario usuario = new Usuario("D2", "123456");
            Usuario usuario2 = new Usuario("D2", "123456");

            _ = server + usuario;
            _ = server + usuario2;
        }
        [TestMethod]

        public void UsuariosNotNull()
        {
            Usuario usuario = new Usuario("D2", "123456");
            Amazona amazona = new Amazona(99, "Amazona", Personaje.EReino.Infierno);
            Asesina asesina = new Asesina(99, "Asesina", Personaje.EReino.Infierno);

            _ = usuario + amazona;
            _ = usuario + asesina;

            List<Personaje> personajes = usuario.Personajes;

            Assert.IsNotNull(personajes);
        }
        [TestMethod]
        public void PersonajeNotNull()
        {
            Amazona amazona = new Amazona(1, "Amazona",Personaje.EReino.Infierno);

            Assert.IsNotNull(amazona.Nombre);
            Assert.IsNotNull(amazona.Nivel);
            Assert.IsNotNull(amazona.Reino);
        }

        [TestMethod]

        public void Serlializado()
        {
            try
            {
                Server server = new Server("UTNFRA");

                Usuario usuario = new Usuario("D2", "123456");

                Amazona amazona = new Amazona(99, "Amazona", Personaje.EReino.Infierno);
                Asesina asesina = new Asesina(99, "Asesina", Personaje.EReino.Infierno);

                _ = usuario + amazona;
                _ = usuario + asesina;

                SqlServer sqlServer = new SqlServer();

                sqlServer.InsertarDatos(server, usuario, amazona);
                sqlServer.InsertarDatos(server, usuario, asesina);
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

    }
}

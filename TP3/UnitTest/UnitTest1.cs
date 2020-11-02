using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using ClasesInstanciables;
using Excepciones;
using Archivos;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UniversidadNoNull()
        {
            Universidad universidad = new Universidad();

            List<Alumno> alumnos = universidad.Alumnos;

            Assert.IsNotNull(alumnos);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]

        public void TestNacionalidadInvalida()
        {
            _ = new Profesor(1245, "Marcelo", "Modecca", "100000000", Persona.ENacionalidad.Argentino);
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]

        public void TestDniInvalido()
        {
            _ = new Profesor(7845, "Alejando", "Schiazzi", "45weq89", Persona.ENacionalidad.Argentino);
        }

        [TestMethod]
        public void ProfesorNotNull()
        {
            Profesor profesor = new Profesor(6589, "Martin", "Buro", "5689745", Persona.ENacionalidad.Argentino);

            Assert.IsNotNull(profesor.Nombre);
            Assert.IsNotNull(profesor.Apellido);
            Assert.IsNotNull(profesor.DNI);
            Assert.IsNotNull(profesor.Nacionalidad);
        }

        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestSinProfesor()
        {
            Universidad universidad = new Universidad();
            universidad += Universidad.EClases.Laboratorio;
        }

        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]

        public void TestAlumnoRepetido()
        {
            Universidad universidad = new Universidad();
            Alumno alumno = new Alumno(5, "nombre_1", "apellido_1", "38548745", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno2 = new Alumno(6, "nombre_1", "apellido_1", "38548745", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            universidad += alumno;
            universidad += alumno2;
        }
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TestArchivo()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            _ = xml.Leer("UniversidadNull.xml", out Universidad universidad);
        }
    }
}

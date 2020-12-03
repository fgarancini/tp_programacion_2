using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException() : base("Alumno repetido.")
        {

        }
    }
}
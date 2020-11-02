using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class SinProfesorException : Exception
    {
        public SinProfesorException() : base("No hay profesor para la clase.")
        {

        }
    }
}
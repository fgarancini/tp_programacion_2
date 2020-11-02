using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException() : base("DNI ingresado invalido")
        {

        }

        public DniInvalidoException(Exception e) : base("DNI ingresado invalido", e)
        {
        }

    }
}
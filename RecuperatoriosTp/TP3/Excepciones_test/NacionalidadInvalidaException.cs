using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class NacionalidadInvalidaException : Exception
    {

        public NacionalidadInvalidaException() : base("La nacionalidad no se condice con el DNI ingresado")
        {

        }
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }
    }
}
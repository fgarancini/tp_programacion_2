using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class CuentaExisteException : Exception
    {
        public CuentaExisteException() : base("Cuenta ya registrada.")
        {
        }

        public CuentaExisteException(Exception innerException) : base("Cuenta ya registrada", innerException)
        {
        }

    }
}
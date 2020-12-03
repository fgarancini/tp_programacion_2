using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    public class PersonajeYaExisteException : Exception
    {
        public PersonajeYaExisteException(Exception innerException) : base("Ese nombre ya esta en uso.",innerException)
        {
        }
        public PersonajeYaExisteException() : base("Ese nombre ya esta en uso.")
        {
        }
    }
}
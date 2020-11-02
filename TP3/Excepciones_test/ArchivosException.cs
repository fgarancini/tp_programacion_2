using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException) : base("No se puede abrir el archivo ", innerException)
        {

        }
    }
}
using System;
using System.Runtime.Serialization;

namespace Archivos
{
    [Serializable]
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException) : base("No se puede abrir el archivo ", innerException)
        {

        }
    }
}
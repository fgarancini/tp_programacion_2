using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class ArchivosException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        //Propiedades
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }


        public ArchivosException(string message, string nombreClase, string nombreMetodo , Exception innerException) : base(message, innerException)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        public ArchivosException(string message, string nombreClase, string nombreMetodo) : this(message, nombreClase, nombreMetodo, null)
        {
        }

        protected ArchivosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class SinProfesorException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

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


        public SinProfesorException(string message, string nombreClase, string nombreMetodo) : this(message, nombreClase, nombreMetodo, null)
        {
        }
        public SinProfesorException(string message, string nombreClase, string nombreMetodo, Exception innerException) : base(message, innerException)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        protected SinProfesorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
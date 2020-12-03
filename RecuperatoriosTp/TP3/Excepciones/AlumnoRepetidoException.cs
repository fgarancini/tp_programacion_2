using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class AlumnoRepetidoException : Exception
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


        public AlumnoRepetidoException(string message,string nombreClase, string nombreMetodo,Exception innerException) : base(message, innerException)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        public AlumnoRepetidoException(string message, string nombreClase, string nombreMetodo) : this(message, nombreClase, nombreMetodo, null)
        {
        }

        protected AlumnoRepetidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
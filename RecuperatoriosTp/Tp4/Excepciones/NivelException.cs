using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    [Serializable]
    public class NivelException : Exception
    {
        public NivelException() : base("Llego al maximo nivel")
        {

        }
        public NivelException(Exception innerException) : base("Llego al maximo nivel", innerException)
        {

        }
    }
}

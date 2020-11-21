using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    [Serializable]
    public class ErrorAlConectarException : Exception
    {
        public ErrorAlConectarException() : base("Base de datos cerrada o vacia.")
        {
        }

        public ErrorAlConectarException(Exception innerException) : base("Base de datos cerrada o vacia", innerException)
        {
        }

    }
}

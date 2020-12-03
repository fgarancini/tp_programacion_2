using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    [Serializable]
    public class UsuarioCaracteresErroneos : Exception
    {
        public UsuarioCaracteresErroneos(Exception innerException) : base("Usuario con caractes no permitidos (Espacios).", innerException)
        {

        }
        public UsuarioCaracteresErroneos(string message) : base(message)
        {

        }
    }
}

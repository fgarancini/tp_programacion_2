using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    [Serializable]
    public class PersonajeSinNombre : Exception
    {
        public PersonajeSinNombre(Exception innerException) : base("Personaje sin nombre o con caractes no permitidos (Espacios).", innerException)
        {

        }
        public PersonajeSinNombre() : base("Personaje sin nombre o con caractes no permitidos (Espacios).")
        {

        }
    }
}

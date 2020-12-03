using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//• Abstracta, con el atributo Legajo.
//• Método protegido y virtual MostrarDatos retornará todos los datos del Universitario.
//• Método protegido y abstracto ParticiparEnClase.
//• Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;
        public Universitario() :base()
        {

        }
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        protected virtual string MostarDatos()
        {
            StringBuilder datosUniv = new StringBuilder();
            datosUniv.AppendLine(base.ToString());
            datosUniv.AppendLine($"Legajo: {this.legajo}");

            return datosUniv.ToString();
        }

        protected abstract string ParticiparEnClase();

        public static bool operator ==(Universitario universitario1,Universitario universitario2)
        {
            return ((universitario1.DNI == universitario2.DNI || universitario1.legajo == universitario2.legajo) && universitario1.Equals(universitario2));
        }
        public static bool operator !=(Universitario universitario1, Universitario universitario2)
        {
            return !(universitario1 == universitario2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
//• Atributos ClaseQueToma del tipo EClase y EstadoCuenta del tipo EEstadoCuenta.
//• Sobreescribirá el método MostrarDatos con todos los datos del alumno.
//• ParticiparEnClase retornará la cadena "TOMA CLASE DE " junto al nombre de la clase que toma.
//• ToString hará públicos los datos del Alumno.
//• Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
//• Un Alumno será distinto a un EClase sólo si no toma esa clase.
namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) :base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma,EEstadoCuenta estadoCuenta) :this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostarDatos()
        {
            StringBuilder datosAlumno = new StringBuilder();
            string estadoCuenta = "";
            datosAlumno.AppendLine(base.MostarDatos());
            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    estadoCuenta = "Pagos al dia";
                    break;
                case EEstadoCuenta.Deudor:
                    estadoCuenta = "Adeuda cuotas";
                    break;
                case EEstadoCuenta.Becado:
                    estadoCuenta = "Fue Becado";
                    break;
            }
            datosAlumno.AppendLine($"Estado cuenta: {estadoCuenta}");
            return datosAlumno.ToString();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder datosClases = new StringBuilder();

            datosClases.AppendLine($"Toma clases de: {this.claseQueToma}");

            return datosClases.ToString();
        }

        public override string ToString()
        {
            return this.MostarDatos() + this.ParticiparEnClase();
        }

        public static bool operator ==(Alumno alumno,Universidad.EClases clases)
        {
            return (alumno.estadoCuenta != EEstadoCuenta.Deudor && alumno != clases);
        }
        public static bool operator !=(Alumno alumno, Universidad.EClases clases)
        {
            return !(alumno.claseQueToma == clases);
        }
    }
}

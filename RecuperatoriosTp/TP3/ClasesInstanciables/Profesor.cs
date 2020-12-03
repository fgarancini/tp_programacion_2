using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
//• Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
//• Sobrescribir el método MostrarDatos con todos los datos del profesor.
//• ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
//• ToString hará públicos los datos del Profesor.
//• Se inicializará a Random sólo en un constructor.
//• En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor mediante el método randomClases. Las dos clases pueden o no ser la misma.
//• Un Profesor será igual a un EClase si da esa clase.
namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        static Profesor()
        {
            Profesor.random = new Random();
        }
        private Profesor() : base()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad): base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }
        protected override string MostarDatos()
        {
            StringBuilder datosProfesor = new StringBuilder();
            datosProfesor.AppendLine(base.MostarDatos());
            datosProfesor.AppendLine(ParticiparEnClase()); 
            
            return datosProfesor.ToString();

        }
        protected override string ParticiparEnClase()
        {
            StringBuilder clases = new StringBuilder();
            clases.AppendLine("Clases:");
            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                clases.AppendLine($"{item}\n");
            }

            return clases.ToString();
        }
        public override string ToString()
        {
            return this.MostarDatos();
        }
        private void _randomClases()
        {
            Array clase = Enum.GetValues(typeof(Universidad.EClases));
            Universidad.EClases eClases = (Universidad.EClases)clase.GetValue(random.Next(clase.Length));
            this.clasesDelDia.Enqueue(eClases);
        }

        public static bool operator ==(Profesor profesor,Universidad.EClases clases)
        {
            bool aux = false;
            foreach (Universidad.EClases item in profesor.clasesDelDia)
            {
                if (item == clases)
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public static bool operator !=(Profesor profesor, Universidad.EClases clases)
        {
            return !(profesor == clases);
        }
    }
}

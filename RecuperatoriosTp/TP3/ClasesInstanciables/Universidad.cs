using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
//• Atributos Alumnos(lista de inscriptos), Profesores(lista de quienes pueden dar clases) y Jornadas.
//• Se accederá a una Jornada específica a través de un indexador.
//• Un Universidad será igual a un Alumno si el mismo está inscripto en él.
//• Un Universidad será igual a un Profesor si el mismo está dando clases en él.
//• Al agregar una clase a un Universidad se deberá generar y agregar una nueva Jornada indicando la clase, un Profesor que pueda darla (según su atributo ClasesDelDia) y la lista de alumnos que la toman (todos los que coincidan en su campo ClaseQueToma).
//• Se agregarán Alumnos y Profesores mediante el operador +, validando que no estén previamente cargados.
namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        #region Metodos
        private static string MostrarDatos(Universidad universidad)
        {
            StringBuilder retorno = new StringBuilder();
            foreach (Jornada item in universidad.Jornadas)
                retorno.Append(item.ToString());
            return retorno.ToString();
        }

        public static bool Guardar(Universidad universidad)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar(AppDomain.CurrentDomain.BaseDirectory + "Universidad.xml", universidad);
        }
        #endregion

        #region Propiedades

        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];

            }
            set
            {
                this.jornada[i] = value;
            }
        }
        public List<Profesor> Profesores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        #endregion

        #region Operadores
        public static Universidad operator +(Universidad universidad, EClases clases)
        {
            Profesor profesor;
            try
            {
                profesor = universidad == clases;
            }
            catch (Exception)
            {

                throw new SinProfesorException();
            }

            Jornada jornada = new Jornada(clases, profesor);
            foreach (Alumno item in universidad.Alumnos)
            {
                if (item == clases)
                {
                    jornada += item;
                    universidad.Jornadas.Add(jornada);
                }
            }

            return universidad;
        }
        public static Universidad operator +(Universidad universidad, Alumno alumno)
        {
            if (universidad != alumno)
            {
                universidad.Alumnos.Add(alumno);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return universidad;
        }

        public static Universidad operator +(Universidad universidad, Profesor profesor)
        {
            if (universidad != profesor)
            {
                universidad.Profesores.Add(profesor);
            }
            return universidad;
        }
        public static bool operator ==(Universidad universidad,Profesor profesor)
        {
            bool aux = false;
            foreach (Profesor item in universidad.Profesores)
            {
                if (item == profesor)
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public static bool operator !=(Universidad universidad, Profesor profesor)
        {
            return !(universidad == profesor);
        }

        public static Profesor operator ==(Universidad universidad,EClases clases)
        {
            foreach (Profesor item in universidad.Profesores)
            {
                if (item == clases)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }

        public static Profesor operator !=(Universidad universidad, EClases clases)
        {
            Profesor profesor = null;
            foreach (Profesor item in universidad.Profesores)
            {
                if (item != clases)
                {
                    profesor = item;
                }
            }
            return profesor;
        }
        public static bool operator ==(Universidad universidad,Alumno alumno)
        {
            bool aux = false;
            foreach (Alumno item in universidad.Alumnos)
            {
                if (item == alumno)
                {
                    aux = true;
                    break;
                }         
            }
            return aux;
        }
        public static bool operator !=(Universidad universidad, Alumno alumno)

        {
            return !(universidad == alumno);
        }
        #endregion

    }
}

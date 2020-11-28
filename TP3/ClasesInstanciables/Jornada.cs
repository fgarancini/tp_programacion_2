using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
//• Atributos Profesor, Clase y Alumnos que toman dicha clase.
//• Se inicializará la lista de alumnos en el constructor por defecto.
//• Una Jornada será igual a un Alumno si el mismo participa de la clase.
//• Agregar Alumnos a la clase por medio del operador +, validando que no estén previamente cargados.
//• ToString mostrará todos los datos de la Jornada.
//• Guardar de clase guardará los datos de la Jornada en un archivo de texto.
//• Leer de clase retornará los datos de la Jornada como texto.
namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clases,Profesor instructor) :this()
        {
            this.Clases = clases;
            this.instructor = instructor;
        }
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.Append("JORNADA: \n");
            retorno.Append("CLASE DE " + this.Clases);
            retorno.AppendLine(" POR " + this.Instructor);
            retorno.AppendLine("Alumnos:\n");

            foreach (Alumno item in this.Alumnos)
            {
                retorno.AppendLine(item.ToString());
            }
            retorno.AppendLine("<------------------------------------------------>");

            return retorno.ToString();
        }
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Jornada.txt";
            return texto.Guardar(ruta, jornada.ToString());
        }
        public static string Leer()
        {
            Texto texto = new Texto();
            if (!(texto.Leer("Jornada.txt", out string retorno)))
                retorno = null;
            return retorno;
        }
        #region Propiedades
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        public Universidad.EClases Clases
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        #endregion

        #region Operadores

        public static Jornada operator +(Jornada jornada,Alumno alumno)
        {
            if (jornada != alumno)
            {
                jornada.Alumnos.Add(alumno);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return jornada;
        }
        public static bool operator ==(Jornada jornada,Alumno alumno)
        {
            bool aux = false;
            foreach (Alumno item in jornada.alumnos)
            {
                if (item == alumno)
                {
                    aux = true;
                }
            }
            return aux;
        }
        public static bool operator !=(Jornada jornada, Alumno alumno)
        {
            return !(jornada == alumno);
        }
        #endregion
    }
}

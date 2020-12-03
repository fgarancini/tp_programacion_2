using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #region Propiedades

        public string StringToDNI
        {
            set
            {
                this.dni = this.ValidarDni(this.nacionalidad,value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.Nacionalidad,value);
            }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = ValidarNombreApellido(value); }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        #endregion
        public override string ToString()
        {
            StringBuilder datosPersona = new StringBuilder();
            datosPersona.Append($"Nombre: {this.Nombre} \n");
            datosPersona.Append($"Apellido: {this.Apellido} \n");
            datosPersona.Append($"Nacionalidad: {this.Nacionalidad} \n");

            return datosPersona.ToString();

        }

        private int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            return ValidarDni(nacionalidad, dato.ToString());
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int.TryParse(dato, out int res);
            if (res != 0)
            {
                if ((nacionalidad == ENacionalidad.Argentino && res >= 1 && res <= 89999999) || (nacionalidad == ENacionalidad.Extranjero && res >= 90000000 && res <= 99999999))
                {
                    return res;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
            else
            {
                throw new DniInvalidoException();

            }


        }

        private string ValidarNombreApellido(string dato)
        {
            char[] cadenaNumeros = dato.ToLower().ToCharArray();
            bool ok = false;
            for (int i = 0; i < cadenaNumeros.Length; i++)
            {
                if (cadenaNumeros[i] >= 'a' && cadenaNumeros[i] <= 'z' || cadenaNumeros[i] == ' ')
                {
                    ok = true;
                }
                else
                {
                    break;
                }
            }
            if (ok)
            {
                return dato;
            }
            else
            {
                return "N/N";
            }
        }
    }
}

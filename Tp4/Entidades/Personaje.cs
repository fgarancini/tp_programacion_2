using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;
namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Amazona))]
    [XmlInclude(typeof(Asesina))]
    [XmlInclude(typeof(Paladin))]
    [XmlInclude(typeof(Barbaro))]
    [XmlInclude(typeof(Hechicera))]
    [XmlInclude(typeof(Druida))]
    [XmlInclude(typeof(Nigromante))]

    public abstract class Personaje
    {
        public enum EReino
        {
            Normal,
            Pesadilla,
            Infierno,
        }
        public enum EClase
        {
            Amazona,
            Asesina,
            Barbaro,
            Druida,
            Hechicera,
            Paladin,
            Nigromante
        }

        public Personaje(string nombre, int nivel, EClase clase,EReino reino)
        {
            this.Nombre = nombre;
            this.Nivel = nivel;
            this.Clase = clase;
            this.Reino = reino;
        }

        public Personaje()
        {
                
        }

        private EReino reino;
        private EClase clase;
        private string nombre;
        private int nivel;
        private int vitalidad;
        private int fuerza;
        private int destreza;
        private int energia;
        private int vida;
        private int mana;
        private string jefesMuertos;

        #region Propiedades

        public virtual int Nivel
        {
            get 
            { 
                return this.nivel; 
            }
            set 
            {
                if (value <= 99)
                {
                    this.nivel = value;  
                }
                else
                {
                    throw new NivelException();
                }
            }
        }

        public virtual string Nombre
        {
            get 
            { 
                return this.nombre; 
            }
            set 
            {
                if (value.Length > 1 )
                {
                    this.nombre = value;
                }
                else
                {
                    throw new PersonajeSinNombre();
                }
            }
        }

        public EClase Clase
        {
            get
            {
                return clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public int Vitalidad
        {
            get
            {
                return vitalidad;
            }

            set
            {
                vitalidad = value;
            }
        }
        public int Fuerza
        {
            get
            {
                return fuerza;
            }

            set
            {
                fuerza = value;
            }
        }
        public int Destreza
        {
            get
            {
                return destreza;
            }
            set
            {
                destreza = value;
            }
        }
        public int Energia
        {
            get
            {
                return energia;
            }
            set
            {
                energia = value;
            }
        }
        public int Vida
        {
            get
            {
                return vida;
            }
            set
            {
                vida = value;
            }
        }
        public int Mana
        {
            get
            {
                return mana;
            }
            set
            {
                mana = value;
            }
        }

        public EReino Reino
        {
            get
            {
                return reino;
            }

            set
            {
                reino = value;
            }
        }

        public string JefesMuertos
        {
            get
            {
                return this.jefesMuertos;
            }

            set
            {
                this.jefesMuertos = value;
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Clase abstract heredada en los personajes para settear sus Stats
        /// </summary>
        /// <param name="nivel"></param>
        public abstract void StatsPersonaje(int nivel);
        public virtual string Descripcion(string descripcion)
        {
            StringBuilder jefes = new StringBuilder();

            jefes.Append($"{descripcion} en el acto {this.Reino}");

            return jefes.ToString();
        }
        protected virtual string Datos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Nombre: {this.Nombre}");
            datos.AppendLine($"Clase: {this.Clase}");
            datos.AppendLine($"Nivel: {this.Nivel}");
            datos.AppendLine($"Fuerza: {this.Fuerza}");
            datos.AppendLine($"Destreza: {this.Destreza}");
            datos.AppendLine($"Vitalidad: {this.Vitalidad}");
            datos.AppendLine($"Energia: {this.Energia}");
            datos.AppendLine($"Vida: {this.Vida}");
            datos.AppendLine($"Mana: {this.Mana}");
            datos.AppendLine($"Reino: {this.Reino}");

            return datos.ToString();
        }

        public override string ToString()
        {
            return this.Datos();
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Personaje personaje, Personaje personaje2)
        {
            return (personaje.nombre == personaje2.nombre);
        }

        public static bool operator !=(Personaje personaje, Personaje personaje2)
        {
            return !(personaje == personaje2);
        } 
        #endregion
    }
}

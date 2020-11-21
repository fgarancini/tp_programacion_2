using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
namespace Entidades
{

    public class Usuario<TPersonaje> where TPersonaje : Personaje
    {
        private string nombre;
        private string password;
        private List<TPersonaje> personajes;

        #region Constructores
        public Usuario()
        {
            this.personajes = new List<TPersonaje>();
        }
        public Usuario(string nombre, string password) : this()
        {
            this.Nombre = nombre;
            this.Password = password;
        } 
        #endregion

        #region Propiedades
        public Personaje this[int i]
        {
            get
            {
                return this.personajes[i];

            }
            set
            {
                this.personajes[i] = (TPersonaje)value;
            }
        }
        public List<TPersonaje> Personajes
        {
            get
            {
                return this.personajes;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (!value.Contains(" "))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new UsuarioCaracteresErroneos("Nombre de usuario con caracteres prohibidos");
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (!value.Contains(" "))
                {
                    this.password = value;
                }
                else
                {
                    throw new UsuarioCaracteresErroneos("Contraseña con caracteres prohibidos");
                }
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder datosUsuario = new StringBuilder();

            datosUsuario.AppendLine($"Nombre: {this.Nombre}");

            return datosUsuario.ToString();
        }

        public bool AgregarPersonaje(TPersonaje obj)
        {
            return this + obj;
        }

        public string DatosCompletos()
        {
            StringBuilder datosCompletos = new StringBuilder();
            datosCompletos.AppendLine($"Usuario: {this.Nombre}");
            datosCompletos.AppendLine($"<---------------------->");
            foreach (Personaje item in this.Personajes)
            {
                datosCompletos.AppendLine(item.ToString());
                datosCompletos.AppendLine($"<---------------------->");

            }

            return datosCompletos.ToString();
        }

        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Usuario<TPersonaje> usuario, Usuario<TPersonaje> usuario1)
        {
            return (usuario.nombre == usuario1.nombre);
        }
        public static bool operator !=(Usuario<TPersonaje> usuario, Usuario<TPersonaje> usuario1)
        {
            return !(usuario == usuario1);
        }

        public static bool operator ==(Usuario<TPersonaje> usuario, TPersonaje personaje)
        {
            bool aux = false;
            foreach (Personaje item in usuario.Personajes)
            {
                if (item == personaje)
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }

        public static bool operator !=(Usuario<TPersonaje> usuario, TPersonaje personaje)
        {
            return !(usuario == personaje);
        }
        public static bool operator +(Usuario<TPersonaje> usuario, TPersonaje personaje)
        {
            bool aux = false;
            if (usuario != personaje)
            {
                aux = true;
                usuario.Personajes.Add(personaje);
            }
            else
            {
                throw new PersonajeYaExisteException();

            }
            return aux;
        } 
        #endregion
    }
}

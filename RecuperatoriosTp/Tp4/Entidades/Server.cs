using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
namespace Entidades
{
    public delegate void GenerarArchivo(bool aux);
    public delegate void GenerarArchivoDeTexto(bool aux);
    public class Server 
    {
        public event GenerarArchivo GenerarArchivo;
        public event GenerarArchivoDeTexto GenerarArchivoTxt;
        private List<Usuario> usuarios;
        private string nombre;

        #region Constructores
        public Server()
        {
            this.usuarios = new List<Usuario>();
        } 
        public Server(string nombre) : this()
        {
            this.Nombre = nombre;
        }
        #endregion

        #region Propiedades
        public List<Usuario> Usuarios
        {
            get
            {
                return this.usuarios;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder datosServer = new StringBuilder();

            datosServer.AppendLine($"Nombre: {this.Nombre}");

            return datosServer.ToString();
        }
        /// <summary>
        ///             EVENTOS Y DELEGADOS
        /// </summary>
        public void GuardarTexto()
        {
            if (this.GenerarArchivoTxt != null)
            {
                Texto texto = new Texto();
                StringBuilder append = new StringBuilder();
                append.AppendLine($"Server:{this.nombre}");
                append.AppendLine($"<----------------->");
                foreach (Usuario usuario in this.Usuarios)
                {
                    append.AppendLine($"Usuario: {usuario.Nombre}");
                    foreach (Personaje personaje in usuario.Personajes)
                    {
                        append.AppendLine(personaje.ToString());
                    }
                }
                this.GenerarArchivoTxt.Invoke(texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Info.txt", append.ToString()));
            }
        }
        /// <summary>
        ///             EVENTOS Y DELEGADOS
        /// </summary>
        public void Serializar()
        {
            Xml<Server> xml = new Xml<Server>();
            if (this.GenerarArchivo != null)
            {
                this.GenerarArchivo.Invoke(xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "infoServer.xml", this));
            }
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Server server, Usuario usuario)
        {
            bool aux = false;
            foreach (Usuario item in server.usuarios)
            {
                if (item == usuario)
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public static bool operator !=(Server server, Usuario usuario)
        {
            return !(server == usuario);
        }

        public static bool operator +(Server server, Usuario usuario)
        {
            bool aux = false;
            if (server != usuario)
            {
                server.usuarios.Add(usuario);
                aux = true;
            }
            else
            {
                throw new CuentaExisteException();
            }
            return aux;
        } 
        #endregion

    }
}

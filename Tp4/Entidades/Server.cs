using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
namespace Entidades
{
    public delegate void GenerarArchivo();
    public delegate void GenerarArchivoDeTexto();
    public class Server 
    {
        public event GenerarArchivo GenerarArchivo;
        public event GenerarArchivoDeTexto GenerarArchivoTxt;
        private List<Usuario<Personaje>> usuarios;
        private string nombre;

        #region Constructores
        public Server()
        {
            this.usuarios = new List<Usuario<Personaje>>();
        } 
        public Server(string nombre) : this()
        {
            this.Nombre = nombre;
        }
        #endregion

        #region Propiedades
        public List<Usuario<Personaje>> Usuarios
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
        public void GuardarTexto()
        {
            if (this.GenerarArchivoTxt != null)
            {
                Texto texto = new Texto();
                StringBuilder append = new StringBuilder();
                append.AppendLine($"Server:{this.nombre}");
                append.AppendLine($"<----------------->");
                foreach (Usuario<Personaje> usuario in this.Usuarios)
                {
                    append.AppendLine($"Usuario: {usuario.Nombre}");
                    foreach (Personaje personaje in usuario.Personajes)
                    {
                        append.AppendLine(personaje.ToString());
                    }
                }
                texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Info.txt", append.ToString());
                this.GenerarArchivoTxt.Invoke();
            }
        }
        public void Serializar()
        {
            if (this.GenerarArchivo != null)
            {
                Xml<Server> xml = new Xml<Server>();
                if (xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "infoServer.xml", this))
                {
                    this.GenerarArchivo.Invoke();
                }
            }
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Server server, Usuario<Personaje> usuario)
        {
            bool aux = false;
            foreach (Usuario<Personaje> item in server.usuarios)
            {
                if (item == usuario)
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public static bool operator !=(Server server, Usuario<Personaje> usuario)
        {
            return !(server == usuario);
        }

        public static bool operator +(Server server, Usuario<Personaje> usuario)
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

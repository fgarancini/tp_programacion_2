using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StreamWriter guardar = new StreamWriter(archivo);
                serializer.Serialize(guardar, datos);
                guardar.Close();
                return true;
                
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StreamReader leer = new StreamReader(archivo);
                datos = (T)serializer.Deserialize(leer);
                leer.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
        }
    }
}

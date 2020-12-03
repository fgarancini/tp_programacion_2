using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Excepciones;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
            try
            {
                serializer.Serialize(writer, datos);
                return true;
                
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
            finally
            {
                writer.Close();
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlTextReader reader = new XmlTextReader(archivo);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                datos = (T)serializer.Deserialize(reader);
                return true;
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
            finally
            {
                reader.Close();
            }
        }
    }
}

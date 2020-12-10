using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto :IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(archivo,true);
                writer.Write(datos);
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close(); 
                }
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            StreamReader streamReader =null;
            try
            {
                streamReader = new StreamReader(archivo);
                datos = streamReader.ReadToEnd();
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close(); 
                }
            }
        }

    }
}

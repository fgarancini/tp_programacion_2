using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto :IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter writer = new StreamWriter(archivo,true);
            try
            {
                writer.Write(datos);
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

        public bool Leer(string archivo, out string datos)
        {
            StreamReader streamReader = new StreamReader(archivo);
            try
            {
                datos = streamReader.ReadToEnd();
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                streamReader.Close();
            }
        }

    }
}

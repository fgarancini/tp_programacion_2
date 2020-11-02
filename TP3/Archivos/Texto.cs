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
            try
            {
                StreamWriter writer = new StreamWriter(archivo);
                writer.Write(datos);
                writer.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            try
            {
                StreamReader streamReader = new StreamReader(archivo);
                datos = streamReader.ReadToEnd();
                streamReader.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }

    }
}

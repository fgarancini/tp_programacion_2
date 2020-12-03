using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivos<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool aux = false;
            FileStream file = new FileStream(archivo,FileMode.Create,FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(datos);
                writer.Close();
                aux = true;
            }
            return aux;
        }

        public bool Leer(string archivo, out string datos)
        {
            throw new NotImplementedException();
        }
    }
}

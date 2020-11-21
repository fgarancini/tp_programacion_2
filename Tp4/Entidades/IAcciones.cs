using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Esta interfaz se ocupa de crear el personaje, instanciandolo segun su clase
    /// Usando el tipo generico que aplica la herencia de Personaje
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAcciones<T> where T : Personaje
    {
        void CrearPersonaje(Personaje.EClase personajeClase, out T PersonajeCreado);
    }
}

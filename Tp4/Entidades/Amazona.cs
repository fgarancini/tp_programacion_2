using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Amazona : Personaje
    {
        public Amazona(int nivel, string nombre, EReino eReino) : base(nombre,nivel, EClase.Amazona, eReino)
        {

        }
        public Amazona()
        {

        }
        public override string Descripcion(string descripcion)
        {
            StringBuilder jefes = new StringBuilder();
            jefes.Append($"{this.Nombre} ");
            jefes.Append(base.Descripcion(descripcion));

            return jefes.ToString();
        }

        public override void StatsPersonaje(int nivel)
        {
            this.Fuerza = 20 + (2 * nivel);
            this.Destreza = 25 + (2 * nivel);
            this.Vitalidad = 20 + (2 * nivel);
            this.Energia = 15 + (2 * nivel);
            this.Mana = (int)((int)15 + (this.Energia * 1.5) + (1.5 * nivel));
            this.Vida = this.Vitalidad * 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paladin : Personaje
    {
        public Paladin(int nivel, string nombre,EReino eReino) : base(nombre,nivel,EClase.Paladin,eReino)
        {
            this.StatsPersonaje(base.Nivel);

        }
        public Paladin()
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
            base.Fuerza = 25 + (2 * nivel);
            base.Destreza = 20 + (2 * nivel);
            base.Vitalidad = 25 + (2 * nivel);
            base.Energia = 15 + (2 * nivel);
            base.Mana = (int)((int)15 + (this.Energia * 1.5)) + (2 * nivel / nivel);
            base.Vida = this.Vitalidad * 3;
        }

    }
}

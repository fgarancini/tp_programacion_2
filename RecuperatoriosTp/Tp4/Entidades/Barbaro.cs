using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Barbaro : Personaje
    {
        public Barbaro(int nivel, string nombre, EReino eReino) : base(nombre, nivel, EClase.Barbaro, eReino)
        {
            this.StatsPersonaje(base.Nivel);

        }
        public Barbaro()
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
            base.Fuerza = 30 + (2 * nivel);
            base.Destreza = 20 + (2 * nivel);
            base.Vitalidad = 25 + (2 * nivel);
            base.Energia = 10 + (2 * nivel);
            base.Mana = (int)((int)10 + (this.Energia * 1.5) + (1 * nivel / nivel));
            base.Vida = this.Vitalidad * 3;
        }
    }
}

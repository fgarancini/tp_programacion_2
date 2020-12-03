using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hechicera : Personaje
    {
        public Hechicera(int nivel, string nombre, EReino eReino) : base(nombre, nivel, EClase.Hechicera, eReino)
        {
            this.StatsPersonaje(base.Nivel);

        }
        public Hechicera()
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
            base.Fuerza = 4 + (2 * nivel);
            base.Destreza = 25 + (2 * nivel);
            base.Vitalidad = 10 + (2 * nivel);
            base.Energia = 35 + (2 * nivel);
            base.Mana = (int)((int)35 + (this.Energia * 1.5) + (1.5 * nivel / nivel));
            base.Vida = this.Vitalidad * 3;
        }
    }
}

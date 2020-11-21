using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Druida : Personaje
    {
        public Druida(int nivel, string nombre, EReino eReino) : base(nombre, nivel, EClase.Druida, eReino)
        {

        }
        public Druida()
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
            this.Fuerza = 15 + (2 * nivel);
            this.Destreza = 20 + (2 * nivel);
            this.Vitalidad = 25 + (2 * nivel);
            this.Energia = 20 + (2 * nivel);
            this.Mana = (int)((int)20 + (this.Energia * 1.5) + (1.5 * nivel / nivel));
            this.Vida = this.Vitalidad * 3;
        }
    }
}

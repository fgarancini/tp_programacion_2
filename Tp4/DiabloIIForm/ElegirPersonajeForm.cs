using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiabloIIForm.Properties;
using Entidades;
using Excepciones;

namespace DiabloIIForm
{
    public partial class ElegirPersonajeForm : Form , IAcciones<Personaje>
    {
        private Personaje.EClase clase;
        private Personaje personaje;
        private Usuario<Personaje> usuario1;
        public Server server1;
        private bool ok;
        public ElegirPersonajeForm(Server server,Usuario<Personaje> usuario)
        {
            InitializeComponent();
            cmbClases.DataSource = Enum.GetValues(typeof(Personaje.EClase));
            this.server1 = server;
            this.usuario1 = usuario;
        }

        private void ElegirPersonajeForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Diablo_rogue_;
            pictureBox2.Image = Resources.Assassin;
            pictureBox3.Image = Resources.barbarian;
            pictureBox4.Image = Resources.druid;
            pictureBox5.Image = Resources.Sorceress;
            pictureBox6.Image = Resources.paladin;
            pictureBox7.Image = Resources.Necromancer;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Enum.TryParse<Personaje.EClase>(cmbClases.SelectedValue.ToString(), out clase);
         
            
            try
            {
                switch (clase)
                {
                    case Personaje.EClase.Amazona:
                        CrearPersonaje(Personaje.EClase.Amazona, out personaje);
                        break;
                    case Personaje.EClase.Asesina:
                        CrearPersonaje(Personaje.EClase.Asesina, out personaje);
                        break;
                    case Personaje.EClase.Barbaro:
                        CrearPersonaje(Personaje.EClase.Barbaro, out personaje);
                        break;
                    case Personaje.EClase.Druida:
                        CrearPersonaje(Personaje.EClase.Druida, out personaje);
                        break;
                    case Personaje.EClase.Hechicera:
                        CrearPersonaje(Personaje.EClase.Hechicera, out personaje);
                        break;
                    case Personaje.EClase.Paladin:
                        CrearPersonaje(Personaje.EClase.Paladin, out personaje);
                        break;
                    case Personaje.EClase.Nigromante:
                        CrearPersonaje(Personaje.EClase.Nigromante, out personaje);
                        break;
                }
                // Si el txt label del nombre tiene caracteres 
                // permite el ingreso al juego
                if (txtPersonajeNombre.TextLength > 1 && !txtPersonajeNombre.Text.Contains(" "))
                {
                    ok = usuario1 + personaje;
                    if (ok)
                    {
                        MessageBox.Show($"Personaje creado exitosamente");
                    }
                    Diablo2 diablo2 = new Diablo2(server1, usuario1, personaje);
                    diablo2.ShowDialog();
                }
                else
                {
                    throw new PersonajeSinNombre();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Este metodo puede ser simplicado en el btnOK pero 
        /// lo uso como demostracion de interfaz + generics
        /// </summary>
        /// <param name="personajeClase"></param>
        /// <param name="PersonajeCreado"></param>
        public void CrearPersonaje(Personaje.EClase personajeClase, out Personaje PersonajeCreado)
        {
            switch (personajeClase)
            {
                case Personaje.EClase.Amazona:
                    PersonajeCreado = new Amazona(1, txtPersonajeNombre.Text, Personaje.EReino.Normal);
                    break;
                case Personaje.EClase.Asesina:
                    PersonajeCreado = new Asesina(1, txtPersonajeNombre.Text, Personaje.EReino.Normal);
                    break;
                case Personaje.EClase.Barbaro:
                    PersonajeCreado = new Barbaro(1, txtPersonajeNombre.Text, Personaje.EReino.Normal);
                    break;
                case Personaje.EClase.Druida:
                    PersonajeCreado = new Druida(1, txtPersonajeNombre.Text, Personaje.EReino.Normal);
                    break;
                case Personaje.EClase.Hechicera:
                    PersonajeCreado = new Hechicera(1, txtPersonajeNombre.Text, Personaje.EReino.Normal);
                    break;
                case Personaje.EClase.Paladin:
                    PersonajeCreado = new Paladin(1, txtPersonajeNombre.Text, Personaje.EReino.Normal);
                    break;
                case Personaje.EClase.Nigromante:
                    PersonajeCreado = new Nigromante(1, txtPersonajeNombre.Text, Personaje.EReino.Normal);
                    break;
                default:
                    PersonajeCreado = null;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPersonajeNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;


namespace DiabloIIForm
{
    public partial class IngresoForm : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        #region Atributos
        private Server server;
        private Usuario<Personaje> usuario;
        private string nombre;
        private string contraseña;
        #endregion

        #region Propiedades
        public Server Server
        {
            get
            {
                return server;
            }

            set
            {
                server = value;
            }
        }

        public Usuario<Personaje> Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        #endregion
        public IngresoForm()
        {
            InitializeComponent();
            player.SoundLocation = "bgMusic.wav";
            player.Play();
            Server = new Server("UTNFRA");
        }

        private void UsuarioSingUp_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {

            bool up = false;
            nombre = txtUser.Text;
            contraseña = txtPassword.Text;
            try
            {
                if (btnIniciaSesion.DialogResult == DialogResult.OK && nombre.Length > 0 && contraseña.Length > 0)
                {
                    usuario = new Usuario<Personaje>(nombre, contraseña);
                    up = this.Server + usuario;

                    if (up)
                    {
                        ElegirPersonajeForm personajeForm = new ElegirPersonajeForm(Server, Usuario);
                        personajeForm.ShowDialog();
                    }
                } 
            }
            catch (CuentaExisteException ex)
            {
                MessageBox.Show(ex.Message);              
            }
            catch (UsuarioCaracteresErroneos ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

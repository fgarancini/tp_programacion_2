using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiabloIIForm.Properties;

using Entidades;
using ServerDAO;
using Excepciones;

namespace DiabloIIForm
{
    public partial class Diablo2 : Form
    {
        //Instancia de las clases necesarias
        private Server Server;
        private Usuario<Personaje> jugador;
        private Personaje personajeElegido;
        private SqlServer sqlServer;
        //Instancia de los hilos y delegados
        private Thread hilo;
        public delegate void Callback();
        //Contador
        int count = 1;

        /// <summary>
        /// Este form toma en su constructor al nombre del servidor, al usuario y al personaje creado
        /// </summary>
        /// <param name="serverDiablo"></param>
        /// <param name="usuario"></param>
        /// <param name="personaje"></param>
        public Diablo2(Server serverDiablo, Usuario<Personaje> usuario, Personaje personaje)
        {
            InitializeComponent();

            //Instancio el hilo encargado de actualizar los datos del personaje
            this.hilo = new Thread(this.ActualizarDatos);

            //Instancio la coneccion a la clase que se ocupa de guardar y listar los datos
            sqlServer = new SqlServer();

            //Uso atributos de estas clases con los parametros pasados para poder usarlos en el form
            Server = serverDiablo;
            jugador = usuario;
            this.personajeElegido = personaje;

            //Cargo el pictureBox del personaje elegido segun su clase y su nombre
            CargarImagen(personaje.Clase);
            txtNombre.Text = personaje.Nombre;

        }
        /// <summary>
        /// Carga el picturebox segun la clase del personaje
        /// </summary>
        /// <param name="clase"></param>
        private void CargarImagen(Personaje.EClase clase)
        {
            switch (clase)
            {
                case Personaje.EClase.Amazona:
                    pictureBox1.Image = Resources.Diablo_rogue_;
                    break;
                case Personaje.EClase.Asesina:
                    pictureBox1.Image = Resources.Assassin;
                    break;
                case Personaje.EClase.Barbaro:
                    pictureBox1.Image = Resources.barbarian;
                    break;
                case Personaje.EClase.Druida:
                    pictureBox1.Image = Resources.druid;
                    break;
                case Personaje.EClase.Hechicera:
                    pictureBox1.Image = Resources.Sorceress;
                    break;
                case Personaje.EClase.Paladin:
                    pictureBox1.Image = Resources.paladin;
                    break;
                case Personaje.EClase.Nigromante:
                    pictureBox1.Image = Resources.Necromancer;
                    break;
            }
        }
        private void Diablo2_Load(object sender, EventArgs e)
        {
            //Intancia de hilos
            this.hilo.Start();

            //Eventos
            this.Server.GenerarArchivo += SerializarInfoDelServer;
            this.Server.GenerarArchivoTxt += GuardarArchivoDeTexto;
        }

        /// <summary>
        ///                         HILOS
        ///                ************************
        /// Encargada de tomar el nivel elegido por el usuario, actualizar los datos mostrados
        /// y los del personaje instanciado
        /// </summary>      
        public void ActualizarDatos()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(80);

                    //StatsPersonajes modifica las caracteristicas de la
                    //instancia segun su nivel, 

                    personajeElegido.StatsPersonaje((int)nudNivel.Value);

                    if (this.nudNivel.InvokeRequired)
                    {

                        //                       USO DEL DELEGADO
                        //                  **************************
                        //       La funcion del evento de cambio de nivel ejecuta el delegado
                        //  con su funcion especifica en este caso actualizar los datos del personaje
                        //
                        this.nudNivel.BeginInvoke((Callback)delegate ()
                        {
                            this.txtFuerza.Text = personajeElegido.Fuerza.ToString();
                            this.txtDestreza.Text = personajeElegido.Destreza.ToString();
                            this.txtVitalidad.Text = personajeElegido.Vitalidad.ToString();
                            this.txtEnergia.Text = personajeElegido.Energia.ToString();
                            this.txtVida.Text = personajeElegido.Vida.ToString();
                            this.txtMana.Text = personajeElegido.Mana.ToString();
                            this.txtReino.Text = personajeElegido.Reino.ToString();
                            if (nudNivel.Value == 99)
                            {
                                nudNivel.Enabled = false;
                            }
                        });
                        personajeElegido.Nivel = (int)nudNivel.Value;
                    }
                }
            }
            catch (NivelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Metodo encargado de mostrar la animacion cuando se tiene el nivel necesario para 
        /// matar al jefe.
        /// </summary>
        public void Quest()
        {
            if (cbxAndariel.Checked is true && personajeElegido.Nivel >= 18)
            {
                Jefes jefes = new Jefes(Resources.Andariel);
                personajeElegido.JefesMuertos = this.personajeElegido.Descripcion("Mato a Andariel ");
                jefes.ShowDialog();
                Thread.Sleep(1000);
                cbxAndariel.Enabled = false;
                cbxAndariel.Checked = false;
            }
            if (cbxDudriel.Checked is true && personajeElegido.Nivel >= 28)
            {
                Jefes jefes = new Jefes(Resources.Dudriel);
                this.personajeElegido.Descripcion("Mato a Dudriel ");
                jefes.ShowDialog();
                Thread.Sleep(1000);
                cbxDudriel.Enabled = false;
                cbxDudriel.Checked = false;
            }
            if (cbxMefisto.Checked is true && personajeElegido.Nivel >= 35)
            {
                Jefes jefes = new Jefes(Resources.Mefisto);
                personajeElegido.JefesMuertos = this.personajeElegido.Descripcion("Mato a Mefisto ");
                jefes.ShowDialog();
                Thread.Sleep(1000);                
                cbxMefisto.Enabled = false;
                cbxMefisto.Checked = false;
            }
            if (cbxDiablo.Checked is true && personajeElegido.Nivel >= 45)
            {
                Jefes jefes = new Jefes(Resources.diablo1);
                personajeElegido.JefesMuertos = this.personajeElegido.Descripcion("Mato a Diablo ");
                jefes.ShowDialog();
                Thread.Sleep(1000);
                cbxDiablo.Enabled = false;
                cbxDiablo.Checked = false;
            }
            if (cbxBaal.Checked is true && personajeElegido.Nivel >= 56)
            {
                Jefes jefes = new Jefes(Resources.Baal1);
                personajeElegido.JefesMuertos = this.personajeElegido.Descripcion("Mato a Baal ");
                jefes.ShowDialog();
                Thread.Sleep(1000);
                cbxBaal.Checked = false;
                cbxBaal.Enabled = false;
                count++;
                PasarDeNivel(count);
            }
        }
        /// <summary>
        /// Al Terminar un reino habilita los checkbox's de nuevo
        /// Segun la cantidad de veces que se llega al final del quest 
        /// cambia el reino del personaje y habilita los checkbox's de nuevo
        /// </summary>
        /// <param name="reino"></param>
        public void PasarDeNivel(int reino)
        {
            if (count == 2)
            {
                this.personajeElegido.Reino = Personaje.EReino.Pesadilla;
                cbxAndariel.Enabled = true;
                cbxDudriel.Enabled = true;
                cbxMefisto.Enabled = true;
                cbxDiablo.Enabled = true;
                cbxBaal.Enabled = true;
            }
            else if (count == 3)
            {
                this.personajeElegido.Reino = Personaje.EReino.Infierno;
                cbxAndariel.Enabled = true;
                cbxDudriel.Enabled = true;
                cbxMefisto.Enabled = true;
                cbxDiablo.Enabled = true;
                cbxBaal.Enabled = true;
            }
            else
            {
                cbxAndariel.Enabled = true;
                cbxDudriel.Enabled = true;
                cbxMefisto.Enabled = true;
                cbxDiablo.Enabled = true;
                cbxBaal.Enabled = true;
            }
        }

        private void nudNivel_ValueChanged(object sender, EventArgs e)
        {
            this.Quest();
        }
        
        private void Lista()
        {
            List<Personaje> personajes = sqlServer.Listar();
            listboxPersonajes.Items.Clear();
            foreach (Personaje item in personajes)
            {
                StringBuilder datos = new StringBuilder();
                datos.Append($"{item.Nombre} | {item.Clase} | {item.Nivel} | {item.Reino} | {item.JefesMuertos}");
                listboxPersonajes.Items.Add(datos.ToString());
            }
        }
        /// <summary>
        /// Guarda los datos de los personajes instanciados en la base de datos
        /// Tambien lista los personajes deserializados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarPJ_Click(object sender, EventArgs e)
        {
            sqlServer.InsertarDatos(Server, jugador, personajeElegido);
            this.Lista();
        }
        private void btnEliminarDato_Click(object sender, EventArgs e)
        {
            sqlServer.EliminarPersonaje(personajeElegido.Nombre);
            this.Lista();
        }

        private void Diablo2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.hilo.Abort();
        }
        private void btnSerializar_Click(object sender, EventArgs e)
        {
            this.Server.Serializar();          
        }
        private void btnGuardarTipoTexto_Click(object sender, EventArgs e)
        {
            this.Server.GuardarTexto();
        }

        public void SerializarInfoDelServer()
        {
            MessageBox.Show("Serializado");
        }

        
        public void GuardarArchivoDeTexto()
        {
            MessageBox.Show("Guardado como texto");
        }

        
    }

}


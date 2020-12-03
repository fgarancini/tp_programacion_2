using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEntidades;


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Agrego los caracteres al ComboBox y hago el focus sobre el TextBoxt principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
            this.ActiveControl = txtNumero1;
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");

        }
        /// <summary>
        /// Utilizado para limpiar todos los casilleros y el resultado
        /// </summary>
        private void Limpiar()
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
        }
        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// El boton cerrar llama al metodo Close() cerrando el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Esta seguro de salir?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Tomando el dato del resultado, validando que no este vacio llama al metodo de la clase Numero que devuelve un string
        /// caso contrario muestra un error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string decimales = lblResultado.Text;
            string respuesta;

            if (string.IsNullOrWhiteSpace(decimales))
            {
                MessageBox.Show($"Es necesario operar antes de convertir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                respuesta = Numero.DecimalBinario(decimales);
                lblResultado.Text = respuesta;
            }

        }
        /// <summary>
        /// Tomando el dato del resultado, validando que no este vacio ninguna de las entradas llama al metodo Operar que devuelve un double
        /// caso contrario muestra un error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador = cmbOperador.Text;
            double resultado;
            if(string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(operador))
            {
                MessageBox.Show($"Es necesario llenar todas las casillas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                resultado = Operar(txtNumero1.Text, txtNumero2.Text, operador);
                lblResultado.Text = resultado.ToString();
            }
           
        }
        /// <summary>
        /// Instancia ambos numeros pasados como parametros a la Clase Numero
        /// luego con el metodo Operar de la Calculadora retona un Double
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1,string numero2, string operador)
        {

            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador[0]);
        }
        /// <summary>
        /// Tomando el dato del resultado, validando que no este vacio llama al metodo de la clase Numero que devuelve un string
        /// caso contrario muestra un error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string binarios = lblResultado.Text;
            string respuesta;

            if (string.IsNullOrWhiteSpace(binarios))
            {
                MessageBox.Show($"Es necesario operar antes de convertir", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                respuesta = Numero.BinarioDecimal(binarios);
                lblResultado.Text = respuesta;
            }

        }
        /// <summary>
        /// El boton "btnLimpiar" llama al metodo Limpiar() que limpia todos los casilleros y el Label de resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNumero1;
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");

        }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private static double Operar(string numero1,string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

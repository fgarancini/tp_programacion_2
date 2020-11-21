using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiabloIIForm
{
    public partial class Jefes : Form
    {
        /// <summary>
        /// Se pasa como parametro la imagen del jefe
        /// </summary>
        /// <param name="image"></param>
        public Jefes(Image image)
        {
            InitializeComponent();
            pbJefes.Image = image;
        }

        private void Jefes_Load(object sender, EventArgs e)
        {

        }


    }
}

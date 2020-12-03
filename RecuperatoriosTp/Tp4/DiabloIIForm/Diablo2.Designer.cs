using System;
using System.Windows.Forms;

namespace DiabloIIForm
{
    partial class Diablo2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtVida = new System.Windows.Forms.TextBox();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.txtVitalidad = new System.Windows.Forms.TextBox();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtReino = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nudNivel = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbxBaal = new System.Windows.Forms.CheckBox();
            this.cbxDiablo = new System.Windows.Forms.CheckBox();
            this.cbxMefisto = new System.Windows.Forms.CheckBox();
            this.cbxDudriel = new System.Windows.Forms.CheckBox();
            this.cbxAndariel = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardarPJ = new System.Windows.Forms.Button();
            this.listboxPersonajes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(17, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtVida
            // 
            this.txtVida.Enabled = false;
            this.txtVida.Location = new System.Drawing.Point(283, 159);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(48, 20);
            this.txtVida.TabIndex = 4;
            // 
            // txtFuerza
            // 
            this.txtFuerza.Enabled = false;
            this.txtFuerza.Location = new System.Drawing.Point(433, 101);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(48, 20);
            this.txtFuerza.TabIndex = 6;
            // 
            // txtDestreza
            // 
            this.txtDestreza.Enabled = false;
            this.txtDestreza.Location = new System.Drawing.Point(433, 136);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(48, 20);
            this.txtDestreza.TabIndex = 7;
            // 
            // txtVitalidad
            // 
            this.txtVitalidad.Enabled = false;
            this.txtVitalidad.Location = new System.Drawing.Point(433, 173);
            this.txtVitalidad.Name = "txtVitalidad";
            this.txtVitalidad.Size = new System.Drawing.Size(48, 20);
            this.txtVitalidad.TabIndex = 8;
            // 
            // txtEnergia
            // 
            this.txtEnergia.Enabled = false;
            this.txtEnergia.Location = new System.Drawing.Point(433, 210);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(48, 20);
            this.txtEnergia.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(214, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMana);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(214, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vida / Mana";
            // 
            // txtMana
            // 
            this.txtMana.Enabled = false;
            this.txtMana.Location = new System.Drawing.Point(69, 52);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(48, 20);
            this.txtMana.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mana";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(353, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 163);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caracteristicas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Energia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vitalidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destreza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuerza:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtReino);
            this.groupBox5.Location = new System.Drawing.Point(353, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(147, 59);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reino";
            // 
            // txtReino
            // 
            this.txtReino.Enabled = false;
            this.txtReino.Location = new System.Drawing.Point(22, 24);
            this.txtReino.Name = "txtReino";
            this.txtReino.Size = new System.Drawing.Size(100, 20);
            this.txtReino.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nudNivel);
            this.groupBox6.Location = new System.Drawing.Point(214, 81);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 47);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nivel";
            // 
            // nudNivel
            // 
            this.nudNivel.Location = new System.Drawing.Point(7, 17);
            this.nudNivel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudNivel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNivel.Name = "nudNivel";
            this.nudNivel.Size = new System.Drawing.Size(120, 20);
            this.nudNivel.TabIndex = 0;
            this.nudNivel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNivel.ValueChanged += new System.EventHandler(this.nudNivel_ValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbxBaal);
            this.groupBox7.Controls.Add(this.cbxDiablo);
            this.groupBox7.Controls.Add(this.cbxMefisto);
            this.groupBox7.Controls.Add(this.cbxDudriel);
            this.groupBox7.Controls.Add(this.cbxAndariel);
            this.groupBox7.Location = new System.Drawing.Point(524, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(266, 394);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Quest";
            // 
            // cbxBaal
            // 
            this.cbxBaal.AutoSize = true;
            this.cbxBaal.Location = new System.Drawing.Point(36, 338);
            this.cbxBaal.Name = "cbxBaal";
            this.cbxBaal.Size = new System.Drawing.Size(77, 17);
            this.cbxBaal.TabIndex = 0;
            this.cbxBaal.Text = "Matar Baal";
            this.cbxBaal.UseVisualStyleBackColor = true;
            // 
            // cbxDiablo
            // 
            this.cbxDiablo.AutoSize = true;
            this.cbxDiablo.Location = new System.Drawing.Point(36, 265);
            this.cbxDiablo.Name = "cbxDiablo";
            this.cbxDiablo.Size = new System.Drawing.Size(86, 17);
            this.cbxDiablo.TabIndex = 0;
            this.cbxDiablo.Text = "Matar Diablo";
            this.cbxDiablo.UseVisualStyleBackColor = true;
            // 
            // cbxMefisto
            // 
            this.cbxMefisto.AutoSize = true;
            this.cbxMefisto.Location = new System.Drawing.Point(36, 192);
            this.cbxMefisto.Name = "cbxMefisto";
            this.cbxMefisto.Size = new System.Drawing.Size(90, 17);
            this.cbxMefisto.TabIndex = 0;
            this.cbxMefisto.Text = "Matar Mefisto";
            this.cbxMefisto.UseVisualStyleBackColor = true;
            // 
            // cbxDudriel
            // 
            this.cbxDudriel.AutoSize = true;
            this.cbxDudriel.Location = new System.Drawing.Point(36, 119);
            this.cbxDudriel.Name = "cbxDudriel";
            this.cbxDudriel.Size = new System.Drawing.Size(89, 17);
            this.cbxDudriel.TabIndex = 0;
            this.cbxDudriel.Text = "Matar Dudriel";
            this.cbxDudriel.UseVisualStyleBackColor = true;
            // 
            // cbxAndariel
            // 
            this.cbxAndariel.AutoSize = true;
            this.cbxAndariel.Location = new System.Drawing.Point(36, 46);
            this.cbxAndariel.Name = "cbxAndariel";
            this.cbxAndariel.Size = new System.Drawing.Size(94, 17);
            this.cbxAndariel.TabIndex = 0;
            this.cbxAndariel.Text = "Matar Andariel";
            this.cbxAndariel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DiabloIIForm.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardarPJ
            // 
            this.btnGuardarPJ.Location = new System.Drawing.Point(214, 253);
            this.btnGuardarPJ.Name = "btnGuardarPJ";
            this.btnGuardarPJ.Size = new System.Drawing.Size(286, 23);
            this.btnGuardarPJ.TabIndex = 20;
            this.btnGuardarPJ.Text = "Guardar personaje";
            this.btnGuardarPJ.UseVisualStyleBackColor = true;
            this.btnGuardarPJ.Click += new System.EventHandler(this.btnGuardarPJ_Click);
            // 
            // listboxPersonajes
            // 
            this.listboxPersonajes.FormattingEnabled = true;
            this.listboxPersonajes.Location = new System.Drawing.Point(25, 284);
            this.listboxPersonajes.Name = "listboxPersonajes";
            this.listboxPersonajes.Size = new System.Drawing.Size(493, 95);
            this.listboxPersonajes.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(493, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Eliminar dato del personaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEliminarDato_Click);
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(25, 412);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(493, 23);
            this.btnSerializar.TabIndex = 23;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(493, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Generar archivo .txt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGuardarTipoTexto_Click);
            // 
            // Diablo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 478);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listboxPersonajes);
            this.Controls.Add(this.btnGuardarPJ);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtEnergia);
            this.Controls.Add(this.txtVitalidad);
            this.Controls.Add(this.txtDestreza);
            this.Controls.Add(this.txtFuerza);
            this.Controls.Add(this.txtVida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diablo2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DIABLO II] (simulacion)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Diablo2_FormClosing);
            this.Load += new System.EventHandler(this.Diablo2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNivel)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pBxPersonaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personaje");
        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtVida;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.TextBox txtVitalidad;
        private System.Windows.Forms.TextBox txtEnergia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtReino;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbxBaal;
        private System.Windows.Forms.CheckBox cbxDiablo;
        private System.Windows.Forms.CheckBox cbxMefisto;
        private System.Windows.Forms.CheckBox cbxDudriel;
        private System.Windows.Forms.CheckBox cbxAndariel;
        private NumericUpDown nudNivel;
        private PictureBox pictureBox1;
        private Button btnGuardarPJ;
        private ListBox listboxPersonajes;
        private Button button1;
        private Button btnSerializar;
        private Button button2;
    }
}


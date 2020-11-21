namespace DiabloIIForm
{
    partial class Jefes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbJefes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbJefes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbJefes
            // 
            this.pbJefes.BackgroundImage = global::DiabloIIForm.Properties.Resources.background;
            this.pbJefes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbJefes.Location = new System.Drawing.Point(0, 0);
            this.pbJefes.Name = "pbJefes";
            this.pbJefes.Size = new System.Drawing.Size(352, 332);
            this.pbJefes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbJefes.TabIndex = 0;
            this.pbJefes.TabStop = false;
            // 
            // Jefes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiabloIIForm.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(352, 332);
            this.Controls.Add(this.pbJefes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jefes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jefes";
            this.Load += new System.EventHandler(this.Jefes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJefes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbJefes;
    }
}
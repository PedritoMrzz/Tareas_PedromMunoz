namespace EXMPARCIAL3_PedroMuñoz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pBarraCarga = new System.Windows.Forms.Panel();
            this.timeLoad = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(47, 336);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // pBarraCarga
            // 
            this.pBarraCarga.BackColor = System.Drawing.Color.DarkOrange;
            this.pBarraCarga.Location = new System.Drawing.Point(47, 336);
            this.pBarraCarga.Name = "pBarraCarga";
            this.pBarraCarga.Size = new System.Drawing.Size(23, 23);
            this.pBarraCarga.TabIndex = 2;
            // 
            // timeLoad
            // 
            this.timeLoad.Enabled = true;
            this.timeLoad.Interval = 200;
            this.timeLoad.Tick += new System.EventHandler(this.timeLoad_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EXMPARCIAL3_PedroMuñoz.Properties.Resources._49ddbed6_95fb_4f54_9e13_15aba3945663;
            this.pictureBox1.Location = new System.Drawing.Point(72, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(326, 407);
            this.Controls.Add(this.pBarraCarga);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pBarraCarga;
        private System.Windows.Forms.Timer timeLoad;
    }
}


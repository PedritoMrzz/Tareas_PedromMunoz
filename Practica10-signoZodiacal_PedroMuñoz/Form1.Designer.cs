namespace Practica10_signoZodiacal_PedroMuñoz
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbEnero = new System.Windows.Forms.RadioButton();
            this.rbFebrero = new System.Windows.Forms.RadioButton();
            this.rbAbril = new System.Windows.Forms.RadioButton();
            this.rbMarzo = new System.Windows.Forms.RadioButton();
            this.rbAgosto = new System.Windows.Forms.RadioButton();
            this.rbJulio = new System.Windows.Forms.RadioButton();
            this.rbJunio = new System.Windows.Forms.RadioButton();
            this.rbMayo = new System.Windows.Forms.RadioButton();
            this.rbDiciembre = new System.Windows.Forms.RadioButton();
            this.rbNoviembre = new System.Windows.Forms.RadioButton();
            this.rbOctubre = new System.Windows.Forms.RadioButton();
            this.rbSeptiembre = new System.Windows.Forms.RadioButton();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titleZodiacal = new System.Windows.Forms.Label();
            this.PictureBoxSignoZodiacal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSignoZodiacal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "MES DE NACIMIENTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbEnero
            // 
            this.rbEnero.AutoSize = true;
            this.rbEnero.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbEnero.Location = new System.Drawing.Point(35, 109);
            this.rbEnero.Name = "rbEnero";
            this.rbEnero.Size = new System.Drawing.Size(66, 21);
            this.rbEnero.TabIndex = 1;
            this.rbEnero.TabStop = true;
            this.rbEnero.Text = "ENERO";
            this.rbEnero.UseVisualStyleBackColor = true;
            this.rbEnero.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbFebrero
            // 
            this.rbFebrero.AutoSize = true;
            this.rbFebrero.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFebrero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFebrero.Location = new System.Drawing.Point(136, 109);
            this.rbFebrero.Name = "rbFebrero";
            this.rbFebrero.Size = new System.Drawing.Size(79, 21);
            this.rbFebrero.TabIndex = 2;
            this.rbFebrero.TabStop = true;
            this.rbFebrero.Text = "FEBRERO";
            this.rbFebrero.UseVisualStyleBackColor = true;
            this.rbFebrero.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbAbril
            // 
            this.rbAbril.AutoSize = true;
            this.rbAbril.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbril.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbAbril.Location = new System.Drawing.Point(136, 142);
            this.rbAbril.Name = "rbAbril";
            this.rbAbril.Size = new System.Drawing.Size(59, 21);
            this.rbAbril.TabIndex = 4;
            this.rbAbril.TabStop = true;
            this.rbAbril.Text = "ABRIL";
            this.rbAbril.UseVisualStyleBackColor = true;
            this.rbAbril.CheckedChanged += new System.EventHandler(this.rbAbril_CheckedChanged);
            // 
            // rbMarzo
            // 
            this.rbMarzo.AutoSize = true;
            this.rbMarzo.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMarzo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMarzo.Location = new System.Drawing.Point(35, 142);
            this.rbMarzo.Name = "rbMarzo";
            this.rbMarzo.Size = new System.Drawing.Size(68, 21);
            this.rbMarzo.TabIndex = 3;
            this.rbMarzo.TabStop = true;
            this.rbMarzo.Text = "MARZO";
            this.rbMarzo.UseVisualStyleBackColor = true;
            this.rbMarzo.CheckedChanged += new System.EventHandler(this.rbMarzo_CheckedChanged);
            // 
            // rbAgosto
            // 
            this.rbAgosto.AutoSize = true;
            this.rbAgosto.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAgosto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbAgosto.Location = new System.Drawing.Point(136, 209);
            this.rbAgosto.Name = "rbAgosto";
            this.rbAgosto.Size = new System.Drawing.Size(73, 21);
            this.rbAgosto.TabIndex = 8;
            this.rbAgosto.TabStop = true;
            this.rbAgosto.Text = "AGOSTO";
            this.rbAgosto.UseVisualStyleBackColor = true;
            this.rbAgosto.CheckedChanged += new System.EventHandler(this.rbAgosto_CheckedChanged);
            // 
            // rbJulio
            // 
            this.rbJulio.AutoSize = true;
            this.rbJulio.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJulio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbJulio.Location = new System.Drawing.Point(35, 209);
            this.rbJulio.Name = "rbJulio";
            this.rbJulio.Size = new System.Drawing.Size(57, 21);
            this.rbJulio.TabIndex = 7;
            this.rbJulio.TabStop = true;
            this.rbJulio.Text = "JULIO";
            this.rbJulio.UseVisualStyleBackColor = true;
            this.rbJulio.CheckedChanged += new System.EventHandler(this.rbJulio_CheckedChanged);
            // 
            // rbJunio
            // 
            this.rbJunio.AutoSize = true;
            this.rbJunio.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJunio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbJunio.Location = new System.Drawing.Point(136, 176);
            this.rbJunio.Name = "rbJunio";
            this.rbJunio.Size = new System.Drawing.Size(60, 21);
            this.rbJunio.TabIndex = 6;
            this.rbJunio.TabStop = true;
            this.rbJunio.Text = "JUNIO";
            this.rbJunio.UseVisualStyleBackColor = true;
            this.rbJunio.CheckedChanged += new System.EventHandler(this.rbJunio_CheckedChanged);
            // 
            // rbMayo
            // 
            this.rbMayo.AutoSize = true;
            this.rbMayo.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMayo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMayo.Location = new System.Drawing.Point(35, 176);
            this.rbMayo.Name = "rbMayo";
            this.rbMayo.Size = new System.Drawing.Size(59, 21);
            this.rbMayo.TabIndex = 5;
            this.rbMayo.TabStop = true;
            this.rbMayo.Text = "MAYO";
            this.rbMayo.UseVisualStyleBackColor = true;
            this.rbMayo.CheckedChanged += new System.EventHandler(this.rbMayo_CheckedChanged);
            // 
            // rbDiciembre
            // 
            this.rbDiciembre.AutoSize = true;
            this.rbDiciembre.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiciembre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbDiciembre.Location = new System.Drawing.Point(136, 281);
            this.rbDiciembre.Name = "rbDiciembre";
            this.rbDiciembre.Size = new System.Drawing.Size(89, 21);
            this.rbDiciembre.TabIndex = 12;
            this.rbDiciembre.TabStop = true;
            this.rbDiciembre.Text = "DICIEMBRE";
            this.rbDiciembre.UseVisualStyleBackColor = true;
            this.rbDiciembre.CheckedChanged += new System.EventHandler(this.rbDiciembre_CheckedChanged);
            // 
            // rbNoviembre
            // 
            this.rbNoviembre.AutoSize = true;
            this.rbNoviembre.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoviembre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbNoviembre.Location = new System.Drawing.Point(35, 281);
            this.rbNoviembre.Name = "rbNoviembre";
            this.rbNoviembre.Size = new System.Drawing.Size(95, 21);
            this.rbNoviembre.TabIndex = 11;
            this.rbNoviembre.TabStop = true;
            this.rbNoviembre.Text = "NOVIEMBRE";
            this.rbNoviembre.UseVisualStyleBackColor = true;
            this.rbNoviembre.CheckedChanged += new System.EventHandler(this.rbNoviembre_CheckedChanged);
            // 
            // rbOctubre
            // 
            this.rbOctubre.AutoSize = true;
            this.rbOctubre.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOctubre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbOctubre.Location = new System.Drawing.Point(136, 245);
            this.rbOctubre.Name = "rbOctubre";
            this.rbOctubre.Size = new System.Drawing.Size(80, 21);
            this.rbOctubre.TabIndex = 10;
            this.rbOctubre.TabStop = true;
            this.rbOctubre.Text = "OCTUBRE";
            this.rbOctubre.UseVisualStyleBackColor = true;
            this.rbOctubre.CheckedChanged += new System.EventHandler(this.rbOctubre_CheckedChanged);
            // 
            // rbSeptiembre
            // 
            this.rbSeptiembre.AutoSize = true;
            this.rbSeptiembre.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSeptiembre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbSeptiembre.Location = new System.Drawing.Point(35, 245);
            this.rbSeptiembre.Name = "rbSeptiembre";
            this.rbSeptiembre.Size = new System.Drawing.Size(96, 21);
            this.rbSeptiembre.TabIndex = 9;
            this.rbSeptiembre.TabStop = true;
            this.rbSeptiembre.Text = "SEPTIEMBRE";
            this.rbSeptiembre.UseVisualStyleBackColor = true;
            this.rbSeptiembre.CheckedChanged += new System.EventHandler(this.rbSeptiembre_CheckedChanged);
            // 
            // cmbDays
            // 
            this.cmbDays.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(485, 67);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(286, 33);
            this.cmbDays.TabIndex = 14;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(113, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(466, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "OBTENER SIGNO ZODIACAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "DIA DE NACIMIENTO";
            // 
            // titleZodiacal
            // 
            this.titleZodiacal.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleZodiacal.ForeColor = System.Drawing.Color.White;
            this.titleZodiacal.Location = new System.Drawing.Point(198, 9);
            this.titleZodiacal.Name = "titleZodiacal";
            this.titleZodiacal.Size = new System.Drawing.Size(358, 45);
            this.titleZodiacal.TabIndex = 17;
            this.titleZodiacal.Text = "DESCUBRE TU SIGNO ZODIACAL";
            this.titleZodiacal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleZodiacal.Click += new System.EventHandler(this.label3_Click);
            // 
            // PictureBoxSignoZodiacal
            // 
            this.PictureBoxSignoZodiacal.Location = new System.Drawing.Point(485, 124);
            this.PictureBoxSignoZodiacal.Name = "PictureBoxSignoZodiacal";
            this.PictureBoxSignoZodiacal.Size = new System.Drawing.Size(286, 219);
            this.PictureBoxSignoZodiacal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSignoZodiacal.TabIndex = 13;
            this.PictureBoxSignoZodiacal.TabStop = false;
            this.PictureBoxSignoZodiacal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Practica10_signoZodiacal_PedroMuñoz.Properties.Resources.RobloxScreenShot20250209_001651636;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleZodiacal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.PictureBoxSignoZodiacal);
            this.Controls.Add(this.rbDiciembre);
            this.Controls.Add(this.rbNoviembre);
            this.Controls.Add(this.rbOctubre);
            this.Controls.Add(this.rbSeptiembre);
            this.Controls.Add(this.rbAgosto);
            this.Controls.Add(this.rbJulio);
            this.Controls.Add(this.rbJunio);
            this.Controls.Add(this.rbMayo);
            this.Controls.Add(this.rbAbril);
            this.Controls.Add(this.rbMarzo);
            this.Controls.Add(this.rbFebrero);
            this.Controls.Add(this.rbEnero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSignoZodiacal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEnero;
        private System.Windows.Forms.RadioButton rbFebrero;
        private System.Windows.Forms.RadioButton rbAbril;
        private System.Windows.Forms.RadioButton rbMarzo;
        private System.Windows.Forms.RadioButton rbAgosto;
        private System.Windows.Forms.RadioButton rbJulio;
        private System.Windows.Forms.RadioButton rbJunio;
        private System.Windows.Forms.RadioButton rbMayo;
        private System.Windows.Forms.RadioButton rbDiciembre;
        private System.Windows.Forms.RadioButton rbNoviembre;
        private System.Windows.Forms.RadioButton rbOctubre;
        private System.Windows.Forms.RadioButton rbSeptiembre;
        private System.Windows.Forms.PictureBox PictureBoxSignoZodiacal;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleZodiacal;
    }
}


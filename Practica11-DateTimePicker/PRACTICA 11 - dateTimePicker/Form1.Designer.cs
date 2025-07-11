namespace PRACTICA_11___dateTimePicker
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
            this.dateTimePickerEdad = new System.Windows.Forms.DateTimePicker();
            this.LblCalcularEdadTitle = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.BtnCalcularEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerEdad
            // 
            this.dateTimePickerEdad.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEdad.Location = new System.Drawing.Point(308, 88);
            this.dateTimePickerEdad.Name = "dateTimePickerEdad";
            this.dateTimePickerEdad.Size = new System.Drawing.Size(217, 21);
            this.dateTimePickerEdad.TabIndex = 0;
            // 
            // LblCalcularEdadTitle
            // 
            this.LblCalcularEdadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalcularEdadTitle.Location = new System.Drawing.Point(289, 9);
            this.LblCalcularEdadTitle.Name = "LblCalcularEdadTitle";
            this.LblCalcularEdadTitle.Size = new System.Drawing.Size(236, 48);
            this.LblCalcularEdadTitle.TabIndex = 1;
            this.LblCalcularEdadTitle.Text = "CALCULAR EDAD";
            this.LblCalcularEdadTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Location = new System.Drawing.Point(294, 72);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(87, 13);
            this.LblEdad.TabIndex = 2;
            this.LblEdad.Text = "Ingresa tu edad: ";
            // 
            // BtnCalcularEdad
            // 
            this.BtnCalcularEdad.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCalcularEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCalcularEdad.Location = new System.Drawing.Point(354, 146);
            this.BtnCalcularEdad.Name = "BtnCalcularEdad";
            this.BtnCalcularEdad.Size = new System.Drawing.Size(111, 39);
            this.BtnCalcularEdad.TabIndex = 3;
            this.BtnCalcularEdad.Text = "Calcular";
            this.BtnCalcularEdad.UseVisualStyleBackColor = false;
            this.BtnCalcularEdad.Click += new System.EventHandler(this.BtnCalcularEdad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCalcularEdad);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblCalcularEdadTitle);
            this.Controls.Add(this.dateTimePickerEdad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerEdad;
        private System.Windows.Forms.Label LblCalcularEdadTitle;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Button BtnCalcularEdad;
    }
}


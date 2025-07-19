using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXMPARCIAL3_PedroMuñoz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // La panlla de inicio de sesión se centra
            this.StartPosition = FormStartPosition.CenterScreen;

            // Asociar el evento KeyPress a los TextBox
            txtNombre.KeyPress += TextBox_KeyPress_NoEnter;
            txtContraseña.KeyPress += TextBox_KeyPress_NoEnter;
        }

        // Método para evitar el salto de línea con Enter
        private void TextBox_KeyPress_NoEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Cancela el evento
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtNombre.Text;
            string contrasena = txtContraseña.Text;
            if (usuario == "admin" && contrasena == "admin")
            {
                Index frmIndex = new Index();
                frmIndex.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*'; 
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

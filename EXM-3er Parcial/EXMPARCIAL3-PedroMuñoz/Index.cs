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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            //Aqui se establece la posicion de inicio del formulario Index en el centro de la pantalla
            this.WindowState = FormWindowState.Maximized;
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreDelCliente_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void rbPayMango_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPayLimon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLicuadoPlatano_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLicuadoFresa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLicuadoMango_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPastelFrutas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPastelTresLeches_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPastelCumpleañero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Se definen datos para almacenar la informacion de los campos de texto y los botones seleccionados
            //Definicion de mis variables
            string vencargado = txtEncargado.Text;
            string vcliente = txtCliente.Text;
            string vfecha = dtpFecha.Text;
            string vprincipal = "";
            double vprecio1 = 0;
            string vbebida = ""; ;
            double vprecio2 = 0;
            string vpostre = ""; ;
            double vprecio3 = 0;

            //Se creo condicionales para validar que los campos de texto no esten vacios cada uno dependiendo
            //de lo que se selecciona el cliente eso se mostrara en ticket despues
            //------Postres --------
            if (rbPayOreo.Checked)
            {
                vprincipal = ("Pay de Oreo");

                vprecio1 = 45;
            }
            if (rbPayLimon.Checked)
            {
                vprincipal = ("Pay de Limon");

                vprecio1 = 48;
            }
            if (rbPayMango.Checked)
            {
                vprincipal = ("Pay De Mango");

                vprecio1 = 42;
            }

            //------Bebidas--------
            if (rbLicuadoPlatano.Checked)
            {
                vbebida = ("Licuado De Platano");

                vprecio2 = 35;
            }
            if (rbLicuadoFresa.Checked)
            {
                vbebida = ("Licuado De Fresa");

                vprecio2 = 38;
            }
            if (rbLicuadoMango.Checked)
            {
                vbebida = ("Licuado de Mango");

                vprecio2 = 40;
            }

            //------Pasteles--------
            if (rbPastelCumpleañero.Checked)
            {
                vpostre = ("Pastel Cumpleaños Personalizado");

                vprecio3 = 350;
            }
            if (rbPastelTresLeches.Checked)
            {
                vpostre = ("Pastel De 3 Leches");

                vprecio3 = 280;
            }
            if (rbPastelFrutas.Checked)
            {
                vpostre = ("Pastel De Frutas");

                vprecio3 = 300;
            }




            //Se crea el ticket y se le pasan los datos de las variables que se definieron arriba
            Ticket ticket = new Ticket(vencargado, vcliente, vfecha, vprincipal, vprecio1, vbebida, vprecio2, vpostre, vprecio3);
            ticket.ShowDialog(); //Se muestra el ticket con los datos que se seleccionaron  
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Al dar click en el boton de cerrar sesion se cierra la ventana actual y se abre la ventana de login
            Login login = new Login(); //Se creo una instancia de la clase Login
            login.Show(); //Muestra la ventana de login
            this.Hide(); //Oculta la ventana actual (Index) para que no se muestre al usuario
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtEncargado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

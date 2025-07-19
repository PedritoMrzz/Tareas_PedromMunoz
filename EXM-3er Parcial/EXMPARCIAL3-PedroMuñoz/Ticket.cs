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
    public partial class Ticket : Form
    {
        public Ticket(string vencargado, string vcliente, string vfecha, string vprincipal, double vprecio1, string vbebida, double vprecio2, string vpostre, double vprecio3)
        {//Se pasaron los datos de la ventana Index a la ventana Ticket son los mismos datos que se ingresaron en la ventana Index
            InitializeComponent();
            // Se establecio la posicion de inicio del formulario Ticket en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Se definieron datos para almacenar la informacion de los campos de texto y los botones seleccionados
            double subtotal = vprecio1 + vprecio2 + vprecio3; // Se calcula el subtotal sumando los precios de los productos seleccionados
            double IVA = subtotal * 0.016; // Calcula el IVA como el 1.6% del subtotal
            double total = subtotal + IVA; //Calcula el total sumando el subtotal y el IVA

            // Se asignaron los valores a las etiquetas del ticket
            //Por ejemplo, lblFecha muestra la fecha seleccionada, lblEncargado muestra el encargado
            lblFecha.Text = "Fecha: " + vfecha;
            lblEncargado.Text = "Encargado: " + vencargado;
            lblCliente.Text = "Cliente: " + vcliente;
            lblPostres.Text = "Postres: " + vprincipal;
            lblDinero1.Text = "$" + vprecio1;
            lblBebida.Text = "Bebida: " + vbebida;
            lblDinero2.Text = "$" + vprecio2;
            lblPostre.Text = "Pasteles: " + vpostre;
            lblDinero3.Text = "$" + vprecio3;
            lblSubtotal.Text = "Subtotal: " + subtotal;
            lblIVA.Text = "IVA 1.6%: " +IVA;
            lblTotal.Text = "Total: " + total;
        }

        private void zFecha_Click(object sender, EventArgs e)
        {

        }

        private void zSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zIva_Click(object sender, EventArgs e)
        {

        }

        private void lblPostres_Click(object sender, EventArgs e)
        {

        }

        private void zEnca_Click(object sender, EventArgs e)
        {

        }
    }
}

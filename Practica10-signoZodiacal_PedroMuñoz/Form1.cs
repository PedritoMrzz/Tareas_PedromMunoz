using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica10_signoZodiacal_PedroMuñoz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 31; i++)//Se crea un bucle que va del o al 31 para agregar los dias al comboBox y que el usuario elija
            {
                cmbDays.Items.Add(i + 1);//inicia en 1 para que no empiece en 0
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diaSeleccionado = cmbDays.SelectedItem != null ? Convert.ToInt32(cmbDays.SelectedItem) : 0; //Se hizo la conversion de los dias ya que no se puede comparar un valor de tipo string con un int, por lo que se convierte
                                                                                                            //a int para poder comparar los valores de los dias seleccionados por el usuario y se uso un operador ternario para comprobarlo.


            // Se comprueba que el usuario haya seleccionado un mes y un día antes de continuar tambien arroja una imagen pre importada del signo elejido dependiendo de que dia y mes haya seleccionado
            // se muestra un mensaje de error si no lo ha hecho.
            if ((rbMarzo.Checked && diaSeleccionado >= 21) || (rbAbril.Checked && diaSeleccionado <= 19))
            {
                MessageBox.Show("Su signo zodiacal es Aries");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Aries;
            }
            else if ((rbAbril.Checked && diaSeleccionado >= 20) || (rbMayo.Checked && diaSeleccionado <= 20))
            {
                MessageBox.Show("Su signo zodiacal es Tauro");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Tauro;
            }
            else if ((rbMayo.Checked && diaSeleccionado >= 21) || (rbJunio.Checked && diaSeleccionado <= 20))
            {
                MessageBox.Show("Su signo zodiacal es Géminis");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Geminis;
            }
            else if ((rbJunio.Checked && diaSeleccionado >= 21) || (rbJulio.Checked && diaSeleccionado <= 22))
            {
                MessageBox.Show("Su signo zodiacal es Cáncer");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Cancer;
            }
            else if ((rbJulio.Checked && diaSeleccionado >= 23) || (rbAgosto.Checked && diaSeleccionado <= 22))
            {
                MessageBox.Show("Su signo zodiacal es Leo");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Leo;
            }
            else if ((rbAgosto.Checked && diaSeleccionado >= 23) || (rbSeptiembre.Checked && diaSeleccionado <= 22))
            {
                MessageBox.Show("Su signo zodiacal es Virgo");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Virgo;
            }
            else if ((rbSeptiembre.Checked && diaSeleccionado >= 23) || (rbOctubre.Checked && diaSeleccionado <= 22))
            {
                MessageBox.Show("Su signo zodiacal es Libra");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Libra;
            }
            else if ((rbOctubre.Checked && diaSeleccionado >= 23) || (rbAgosto.Checked && diaSeleccionado <= 21))
            {
                MessageBox.Show("Su signo zodiacal es Escorpio");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Escorpio;
            }
            else if ((rbNoviembre.Checked && diaSeleccionado >= 22) || (rbDiciembre.Checked && diaSeleccionado <= 21))
            {
                MessageBox.Show("Su signo zodiacal es Sagitario");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Sagitario;
            }
            else if ((rbDiciembre.Checked && diaSeleccionado  >= 22) || (rbEnero.Checked && diaSeleccionado <= 19))
            {
                MessageBox.Show("Su signo zodiacal es Capricornio");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Capricornio;
            }
            else if ((rbEnero.Checked && diaSeleccionado >= 20) || (rbFebrero.Checked && diaSeleccionado <= 18))
            {
                MessageBox.Show("Su signo zodiacal es Acuario");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Acuario;
            }
            else if ((rbFebrero.Checked && diaSeleccionado >= 19) || (rbMarzo.Checked && diaSeleccionado <= 20))
            {
                MessageBox.Show("Su signo zodiacal es Piscis");
                PictureBoxSignoZodiacal.Image = Properties.Resources.Piscis;
            }
            else  // Si no se cumple ninguna de las condiciones, significa no se ha seleccionado un meso o dia y arrojara un mensaje de error es decir si no hay un dia seleccionado o un mes seleccionado se verificara.
            {
                if (cmbDays.SelectedItem == null
               || !(rbEnero.Checked
               || rbFebrero.Checked
               || rbMarzo.Checked
               || rbAbril.Checked
               || rbMayo.Checked
               || rbJunio.Checked
               || rbJulio.Checked
               || rbAgosto.Checked
               || rbSeptiembre.Checked
               || rbOctubre.Checked
               || rbNoviembre.Checked
               || rbDiciembre.Checked))

                {
                    MessageBox.Show("Por favor, seleccione un dia y un mes");
                    return;
                }
            }


        }
        
        private void rbMarzo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAbril_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMayo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbJulio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAgosto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbJunio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSeptiembre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOctubre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNoviembre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbDiciembre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

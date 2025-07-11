using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_11___dateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcularEdad_Click(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dateTimePickerEdad.Value; //Se usa el tipo de dato DateTime para guardar la fecha de nacimiento seleccionada por el usuario.
            DateTime fechaActual = DateTime.Today;//Aqui tambien se uso DateTime solamente que para guardar la fecha actual con Dateime.Today.

            int edad = fechaActual.Year - fechaNacimiento.Year; //Se creo una variable entero para guardar la edad calculada restando el año de la fecha de nacimiento al año actual.

            //Se creo una condicion if para verificar...
            if (fechaNacimiento > fechaActual.AddYears(-edad)) //...si la fecha de naicimiento es mayor a la fecha actual menos los años obtenidos...
            {
                edad--; //...se resta uno a la edad calculada para obtener la edad correcta y no se pase por meses o dias.
            }

            MessageBox.Show( $"Tienes {edad} años"); //Se muestra un mensaje al usuario con la edad correcta calculada.
        }
    }
}

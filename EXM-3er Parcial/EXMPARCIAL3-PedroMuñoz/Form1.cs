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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;// Ajusta la posición de inicio del formulario en el centro de la pantalla
        }

        private void timeLoad_Tick(object sender, EventArgs e)
        {
            // Este evento se ejecuta cada vez que el temporizador `timeLoad' haga clic
            int incremento = 15; // Define el incremento de ancho para la barra de carga
            if (pBarraCarga.Width + incremento >= 235) // Se creo una condicional que verifica si la barra de carga ha alcanzado o superado el ancho máximo
            {
                // Si la barra de carga ha alcanzado el ancho máximo, se detiene el temporizador y se muestra el formulario de inicio de sesión
                pBarraCarga.Width = 235; // Asegura que la barra de carga no exceda el ancho máximo
                timeLoad.Stop(); // Detiene el temporizador para que no siga incrementando el ancho de la barra de carga
                Login frmIndex = new Login(); // Crea una nueva instancia del formulario de inicio de sesión
                frmIndex.Show(); // Muestra el formulario de inicio de sesión
                this.Hide(); // Oculta el formulario actual Form1 para que no se muestre al usuario
            }
            else // Si la barra de carga aún no ha alcanzado el ancho máximo, se incrementa su ancho
            {
                pBarraCarga.Width += incremento; // Incrementa el ancho de la barra de carga en el valor definido
                timeLoad.Start(); // Reinicia el temporizador para que continúe incrementando el ancho de la barra de carga
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGit2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste = 0;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            // Añade esta parte para establecer el tipo de telegrama
            if (rbOrdinario.Checked)
                tipoTelegrama = 'o';
            else if (rbUrgente.Checked)
                tipoTelegrama = 'u';

            // Obtengo el número de palabras que forma el telegrama 
            numPalabras = textoTelegrama.Split(' ').Length;

            // Calcula el costo según el tipo de telegrama
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            }
            else if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            }
            else
            {
                coste = 0;
            }

            txtPrecio.Text = coste.ToString("C2"); // Muestra el costo en formato de moneda


        }
    }
}

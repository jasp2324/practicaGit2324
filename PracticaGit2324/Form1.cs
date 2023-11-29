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
            string textoTelegrama = txtTelegrama.Text;
            int numPalabras = 0;
            double coste = 0;
            // Obtener el número de palabras que forma el telegrama
            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            numPalabras = textoTelegrama.Split(delimitadores,
            StringSplitOptions.RemoveEmptyEntries).Length;
            // Calcular el costo del telegrama
            if (cbUrgente.Checked)
            {
                // Telegrama urgente
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }
            else
            {
                // Telegrama ordinario
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            // Mostrar el costo en el TextBox de precio
            txtPrecio.Text = coste.ToString("C") + " euros"; // "C" formatea como moneda
        }
    }
}

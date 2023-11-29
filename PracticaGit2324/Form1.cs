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
                    coste = 25;
                else
                    coste = 0.5 * numPalabras;
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}

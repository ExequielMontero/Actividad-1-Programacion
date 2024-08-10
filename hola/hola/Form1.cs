using hola.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hola
{
    public partial class Form1 : Form
    {
        Cocinera cocinera;
        Alacena alacena;
        Amasador amasador;
        double frutas, harinas;
        double cantmasa;
        bool masacortada = false, molde = false, hornear = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Cocinera lacocinera = new Cocinera();
            Alacena elalacena = new Alacena();
            Amasador elamasador = new Amasador();
            Cocina micocina = new Cocina(elalacena, elamasador, lacocinera);
            alacena = micocina.Mialacena;
            amasador = micocina.MiAmasador;
            cocinera = micocina.Micocinera;
            gb1.Visible = true;
            btnCocina.Enabled = false;
        }

        private void btnHarina_Click(object sender, EventArgs e)
        {
                double cant = Convert.ToDouble(tbHarina.Text);
                alacena.reponerharina(cant);
                tbHarina.Clear();

        }

        private void btnFruta_Click(object sender, EventArgs e)
        {
            double cant = Convert.ToDouble(tbFruta.Text);
            alacena.reponerfruta(cant);
            tbFruta.Clear();
        }

        private void btnTomarHarina_Click(object sender, EventArgs e)
        {
            if (alacena.Harina >= 1)
            {
                double cant = Convert.ToDouble(tbTomarHarina.Text);
                harinas = alacena.tomarharina(cant);
                tbTomarHarina.Clear();
            }
            else
            {
                MessageBox.Show("Primero Anna debe reponer la alacena de harina");
            }
        }

        private void btnTomarFruta_Click(object sender, EventArgs e)
        {
            if(alacena.Fruta >= 1)
            {
                double cant = Convert.ToDouble(tbTomarFruta.Text);
                frutas = alacena.tomarfruta(cant);
                tbTomarFruta.Clear();
            }
            else
            {
                MessageBox.Show("Primero Anna debe reponer la alacena de frutas");
            }
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            if (cantmasa > 0)
            {
                masacortada = cocinera.cortarmasa();
                MessageBox.Show("Anna corto la masa con exito");

            }
            else
            {
                MessageBox.Show("Anna primero debe amasar la masa");
            }
        }

        private void btnHornear_Click(object sender, EventArgs e)
        {
            if (molde != false)
            {
                hornear = cocinera.hornear();
                MessageBox.Show("Anna horneo con exito");
            }
            else
            {
                MessageBox.Show("Anna primero debe moldear la masa");

            }
        }

        private void btnFormar_Click(object sender, EventArgs e)
        {
            if (masacortada != false)
            {
                molde = cocinera.formarmolde();
                MessageBox.Show("Anna termino de formar los moldes de la masa");
            }
            else
            {
                MessageBox.Show("Anna primero debe cortar la masa");
            }
        }

        private void btnAmasar_Click(object sender, EventArgs e)
        {
            if (harinas > 0)
            {
                cantmasa = amasador.amasar(harinas);
                MessageBox.Show("Anna amaso la masa con exito");

            }
            else
            {
                MessageBox.Show("Anna debe sacar harina de la alacena primero");
            }
        }
    }
}






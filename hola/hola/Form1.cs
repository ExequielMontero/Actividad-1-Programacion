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
        Alacena alacena;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Alacena mialacena = new Alacena();
           
            Cocina micocina = new Cocina(mialacena);
            alacena = micocina.Mialacena;
        }

        private void btnHarina_Click(object sender, EventArgs e)
        {
            double cant = Convert.ToInt32(tbHarina.Text);
            alacena.reponerharina(cant);
        }
    }
}

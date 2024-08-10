using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hola.Models
{
    internal class Alacena
    {
        private double harina;
        private double fruta;

        public void reponerharina(double harina)
        {
            this.harina = this.harina + harina;
        }

        public double Harina { get { return this.harina; } }

        public void reponerfruta(double fruta)
        {
            this.fruta = this.fruta + fruta;
        }

        public double Fruta { get { return this.fruta; } }

        public double tomarharina(double cant)
        {
            double devuelto = 0;
            if (cant > harina && harina>0)
            {
                devuelto = harina;
                 harina-= devuelto;
                MessageBox.Show($"Anna saco {devuelto}kg de harina en la alacena");
            }
            else if(cant == harina && harina > 0)
            {
                devuelto = harina;
                 harina-= devuelto;
                MessageBox.Show($"Anna saco {devuelto}kg de harina en la alacena");

            }
            else if(cant<harina && harina > 0)
            {
                devuelto = cant;
                 harina-= devuelto;
                MessageBox.Show($"Anna saco {devuelto}kg de harina en la alacena");
            }
            return devuelto;
        }

        public double tomarfruta(double cant)
        {
            double devuelto = 0;
            if (cant > fruta && fruta > 0)
            {
                devuelto = fruta;
                fruta -= devuelto;
                MessageBox.Show($"Anna saco {devuelto}kg de fruta en la alacena");

            }
            else if (cant == fruta && fruta > 0)
            {
                devuelto = fruta;
                fruta -= devuelto;
                MessageBox.Show($"Anna saco {devuelto}kg de fruta en la alacena");

            }
            else if (cant < fruta && fruta > 0)
            {
                devuelto = cant;
                fruta -= devuelto;
                MessageBox.Show($"Anna saco {devuelto}kg de fruta en la alacena");

            }
            return devuelto;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}

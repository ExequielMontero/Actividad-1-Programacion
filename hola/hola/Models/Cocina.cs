using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace hola.Models
{
    internal class Cocina
    {
        private Alacena mialacena;
        private Amasador miamasador;
        private Cocinera micocinera;
        public Cocina(Alacena a, Amasador m, Cocinera k)
        {
            mialacena = a;
            miamasador = m;
            micocinera = k;
        }

        public Alacena Mialacena { get { return mialacena; } }
        public Amasador MiAmasador { get { return miamasador; } }
        public Cocinera Micocinera {  get { return micocinera; } }

    }
}


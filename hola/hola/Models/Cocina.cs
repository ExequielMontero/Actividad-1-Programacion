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
        public Cocina(Alacena a)
        {
            mialacena = a;
        }

        public Alacena Mialacena { get { return mialacena; } }

    }
}


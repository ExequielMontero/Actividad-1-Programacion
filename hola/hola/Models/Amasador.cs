using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hola.Models
{
    internal class Amasador
    { 
        public double amasar(double kgharina)
        {
            double harinaamasada = 0;
            if (kgharina > 0)
            {
                harinaamasada = kgharina * 1.3;
            }
            return harinaamasada;
        } 
    }
}

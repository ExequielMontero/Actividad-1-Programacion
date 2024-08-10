using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hola.Models
{
    internal class Cocinera
    {
        public bool cortarmasa()
        {
            bool masa = false; ;
            if(masa == false)
            {
                masa = true;
            }
            return masa;
        }

        public bool formarmolde()
        {
            bool molde = false; ;
            if (molde == false)
            {
                molde = true;
            }
            return molde;
        }

        public bool hornear()
        {
            bool hornea = false;
            if(hornea == false)
            {
                hornea = true;
            }
            return hornea;
        }
    }
}

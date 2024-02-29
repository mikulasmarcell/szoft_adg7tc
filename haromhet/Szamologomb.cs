using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromhet
{
    internal class Szamologomb: Villogogomb
    {
        public int szam = 1;   
        public Szamologomb() 
        {
            MouseClick += Szamologomb_MouseClick;
        }

        private void Szamologomb_MouseClick(object? sender, MouseEventArgs e)
        {
            
        }
    }
}

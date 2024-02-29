using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromhet
{
    internal class Villogogomb: Button
    {
        public Villogogomb()
        {
            MouseEnter += Villogogomb_MouseEnter;
            MouseLeave += Villogogomb_MouseLeave;
        }

        private void Villogogomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
        private void Villogogomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace FastBeats.DB
{
    class Focus
    {
        public void foco(MetroTextBox mtxt, string texto)
        {
            if (mtxt.Text == texto)
            {
                mtxt.Clear();
            }
        }
        public void foraDeFoco(MetroTextBox mtxt, string texto)
        {
            if (mtxt.Text == "")
            {
                mtxt.Text = texto;
            }
        }
    }
}

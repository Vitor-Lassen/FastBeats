using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace FastBeats.Utilities
{
    class PropriedadesTextBox
    {
        public void somenteNum(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        public void numerosVirgula(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == ',') || ((Keys)e.KeyChar == Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void retornarMascara(object sender, EventArgs e)
        {
            try
            {
                MetroTextBox txt = (MetroTextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
            catch { }
        }
        private void tirarMascara(object sender, EventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        public void tirarMascara(MetroTextBox mtxt)
        {
            mtxt.Text = mtxt.Text.Replace("R$", "").Trim();
            mtxt.Text = mtxt.Text.Replace(".", "");
            mtxt.Text = mtxt.Text.Replace(",", ".");
            
        }
     
        private void apenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        public void aplicarDinheiro(MetroTextBox txt)
        {
            txt.Enter += tirarMascara;
            txt.Leave += retornarMascara;
            txt.KeyPress += apenasValorNumerico;
            
            

        }

    }
}

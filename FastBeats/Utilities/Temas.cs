using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;


namespace FastBeats.DB
{
    class Temas
    {
        public int cores(string cor)
        {
            if (cor == "Cinza")
            {
                return 3;
            }
            else if (cor == "Azul")
            {
                return 4;
            }
            else if (cor == "Verde")
            {
                return 5;
            }
            else if (cor == "Verde-Limão")
            {
                return 6;
            }
            else if (cor == "Verde-Azulado")
            {
                return 7;
            }
            else if (cor == "Laranja")
            {
                return 8;
            }
            else if (cor == "Marrom")
            {
                return 9;
            }
            else if (cor == "Rosa")
            {
                return 10;
            }
            else if (cor == "Magenta")
            {
                return 11;
            }
            else if (cor == "Roxo")
            {
                return 12;
            }
            else if (cor == "Vermelho")
            {
                return 13;
            }
            else if (cor == "Amarelo")
            {
                return 14;
            }
            return 4;
        }


        //agardar conexão bd, ou não...
        public string cores(int cor)
        {
            if (cor == 3)
            {
                return "Cinza";
            }
            else if (cor == 4)
            {
                return "Azul";
            }
            else if (cor == 5)
            {
                return "Verde";
            }
            else if (cor == 6)
            {
                return "Verde-Limão";
            }
            else if (cor == 7)
            {
                return "Verde-Azulado";
            }
            else if (cor == 8)
            {
                return "Laranja";
            }
            else if (cor == 9)
            {
                return "Marrom";
            }
            else if (cor == 10)
            {
                return "Rosa";
            }
            else if (cor == 11)
            {
                return "Magenta";
            }
            else if (cor == 12)
            {
                return "Roxo";
            }
            else if (cor == 13)
            {
                return "Vermelho";
            }
            else if (cor == 14 )
            {
                return "Amarelo";
            }
            return "Azul";
        }
        //agardar conexão bd, ou não...
        public string tema (int tema)
        {
            if (tema == 2)
            {
                return "Preto";
            }
            else
            {
                return "Branco";
            }
        }
        
        public void temaComponente(MaskedTextBox comp, int numTema)
        {
          //  MetroThemeStyle msmm = msm.Theme;
            if (numTema == 1) 
            {
                comp.BackColor = System.Drawing.Color.Gainsboro;
                comp.ForeColor = System.Drawing.Color.Black;
            }
        }
        public void temaComponente(ComboBox comp, int numTema)
        {
            //  MetroThemeStyle msmm = msm.Theme;
            if (numTema == 1)
            {
                comp.BackColor = System.Drawing.Color.Gainsboro;
                comp.ForeColor = System.Drawing.Color.Black;
            }
        }
        public void temaComponente(NumericUpDown comp, int numTema)
        {
            //  MetroThemeStyle msmm = msm.Theme;
            if (numTema == 1)
            {
                comp.BackColor = System.Drawing.Color.Gainsboro;
                comp.ForeColor = System.Drawing.Color.Black;
            }
        }
       
    }
    
}

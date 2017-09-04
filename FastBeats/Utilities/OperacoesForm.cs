using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;

namespace FastBeats
{
    class OperacoesForm
    {
        public void chamarFrm(Form frm, Form frm2)
        {
            if (frm.WindowState == FormWindowState.Maximized)
            {
                frm2.MdiParent = frm;
                frm2.Show();
                frm.WindowState = FormWindowState.Minimized;
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm2.MdiParent = frm;
                frm2.Show();
                frm.Width += 1;
                frm.Width -= 1;
            } 
        }
       
        public void chamarFrm(Form frm, View.frmMenuPrincipal frm2, MetroStyleManager msm)
        {
            if (frm.WindowState == FormWindowState.Maximized)
            {
                frm2.MdiParent = frm;
                frm2.Show();
                frm.WindowState = FormWindowState.Minimized;
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm2.MdiParent = frm;
                frm2.Show();
                frm.Width += 1;
                frm.Width -= 1;
            }
           
           
        }
         
        public void correcaoInicialForm( Form frm)
        {
              frm.ControlBox = false;
              frm.Width += 1;
              frm.WindowState = FormWindowState.Maximized;
        }
        public void retornarFrm(Form frm)
        {
            if (frm.WindowState == FormWindowState.Maximized)
            {
                
                frm.WindowState = FormWindowState.Minimized;
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.Width += 1;
                frm.Width -= 1;
            }
        }
       
    }
}

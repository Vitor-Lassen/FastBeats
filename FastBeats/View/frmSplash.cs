using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastBeats.View;

namespace FastBeats
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           if (Opacity < 1)
            {
                Opacity += 0.08;

            }
            else
            {
                timer1.Stop();
                frmPrincipal princi = new frmPrincipal();
                princi.Show();
                Visible = false;
            }
        }

    }
}

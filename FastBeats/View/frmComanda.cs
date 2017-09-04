using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastBeats.DB;
using MetroFramework;

namespace FastBeats.View
{
    public partial class frmComanda : MetroFramework.Forms.MetroForm
    {
        frmRecepcao contextoRecep = new frmRecepcao();
        frmPrincipal contexto = new frmPrincipal();
        Comanda coman = new Comanda();

        public frmComanda(frmRecepcao contextoRecep,frmPrincipal contexto)
        {
            InitializeComponent();
            this.contextoRecep = contextoRecep;
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
        }

        private void mbtnAddComanda_Click(object sender, EventArgs e)
        {
            try
            {
                coman.cadComanda(Convert.ToInt32(mtxtComanda.Text));
                contextoRecep.mtxtComanda.Text = mtxtComanda.Text;
                Close();
            }
            catch
            {
                mlblAvisos.Text = "Comanda já cadastrada!";
            }
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

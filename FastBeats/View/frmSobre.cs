using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

using FastBeats.DB;
using System.Data.SqlClient;


namespace FastBeats.View
{
    public partial class frmSobre : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();

        Limpar limpar = new Limpar();
        public frmSobre(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
        }

        public frmSobre()
        {
            // TODO: Complete member initialization
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);

        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal(contexto);

            forms.chamarFrm(contexto, voltar);
            voltar.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            voltar.metroStyleManager.Style = contexto.metroStyleManager.Style;
            this.Close();
        }
    }
}

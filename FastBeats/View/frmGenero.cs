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

namespace FastBeats.View
{
    public partial class frmGenero : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Genero gen = new Genero();
        frmArtistas contextoArtistas = new frmArtistas();
        public frmGenero(frmPrincipal contexto, frmArtistas contextoArtistas)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.contextoArtistas = contextoArtistas;
            this.StyleManager = metroStyleManager;
        }

        private void frmGenero_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);

        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            Close();
            forms.retornarFrm(contexto);

        }

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {
            gen.cadGenero(mtxtGenero.Text);
            
            contextoArtistas.mcboGenero.DataSource = gen.consGenero().Tables[0];
            contextoArtistas.mcboGenero.DisplayMember = "GENERO";
            contextoArtistas.mcboGenero.ValueMember = "GENERO";
            contextoArtistas.mcboGenero.Text = mtxtGenero.Text;
            Close();
            forms.retornarFrm(contexto);
            
        }
    }
}

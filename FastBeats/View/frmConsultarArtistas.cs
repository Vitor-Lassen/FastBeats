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
    public partial class frmConsultarArtistas : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Artista art = new Artista();
        Genero gen = new Genero();
        frmArtistas contextoArtistas = new frmArtistas();
        public frmConsultarArtistas(frmPrincipal contexto,frmArtistas contextoArtistas)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.contextoArtistas = contextoArtistas;
            this.StyleManager = metroStyleManager;
        }


        private void frmConsultarArtistas_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            mcboGenero.DataSource = gen.consGenero().Tables[0];
            mcboGenero.DisplayMember = "GENERO";
            mcboGenero.ValueMember = "GENERO";
            mcboGenero.SelectedIndex = -1;
            mtxtArtista_TextChanged(sender, e);

        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            
            Close();
            forms.retornarFrm(contexto);
        }


        private void mtxtArtista_TextChanged(object sender, EventArgs e)
        {
            mdgvArtistas.DataSource = art.consArtista(mtxtArtista.Text).Tables[0];
        }

        private void mcboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            mdgvArtistas.DataSource = art.consArtistasGenero(mcboGenero.Text).Tables[0];
        }

        private void mdgvArtistas_DoubleClick(object sender, EventArgs e)
        {
            contextoArtistas.codArtista = Convert.ToInt32(mdgvArtistas.CurrentRow.Cells[0].Value.ToString());
            contextoArtistas.mtxtArtista.Text = mdgvArtistas.CurrentRow.Cells[1].Value.ToString();
            contextoArtistas.mskTel.Text = mdgvArtistas.CurrentRow.Cells[2].Value.ToString();
            contextoArtistas.mtxtEmail.Text = mdgvArtistas.CurrentRow.Cells[3].Value.ToString();
            contextoArtistas.mcboGenero.Text = mdgvArtistas.CurrentRow.Cells[4].Value.ToString();
            contextoArtistas.mtxtEmpresario.Text = mdgvArtistas.CurrentRow.Cells[5].Value.ToString();
            contextoArtistas.mbtnAtualizar.Visible = true;
            contextoArtistas.mbtnNovo.Visible = true;
            contextoArtistas.mbtnCadastrar.Visible = false;
            Close();
            forms.retornarFrm(contexto);
            
        }

        private void mtxtArtista_Enter(object sender, EventArgs e)
        {
            mcboGenero.SelectedIndex = -1;
        }

        private void mcboGenero_Enter(object sender, EventArgs e)
        {
            mtxtArtista.Clear();
        }


      
    }
}

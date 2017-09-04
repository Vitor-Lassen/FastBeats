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
    public partial class frmArtistas : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Artista art = new Artista();
        Genero gen = new Genero();
        Limpar limpar = new Limpar();

        public int codArtista;
        public frmArtistas(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
        }

        public frmArtistas()
        {
            
        }

    

       

        private void frmArtistas_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
           
            mcboGenero.DataSource = gen.consGenero().Tables[0];
            mcboGenero.DisplayMember = "GENERO";
            mcboGenero.ValueMember = "GENERO";
            mcboGenero.SelectedIndex = -1;
            temas.temaComponente(mskTel, contexto.numTema);
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal(contexto);

            forms.chamarFrm(contexto, voltar);
            voltar.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            voltar.metroStyleManager.Style = contexto.metroStyleManager.Style;
            this.Close();
        }

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {
            if ((mtxtArtista.Text != "") && (mskTel.Text != ""))
            {
                art.cadArtista(mtxtArtista.Text,mskTel.Text,mtxtEmail.Text,mcboGenero.Text,mtxtEmpresario.Text, mPanel, contexto);
                mlblAvisos.Text = "";

                
            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios!";
            }
        }

        private void mbtnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarArtistas consArt = new frmConsultarArtistas(contexto,this);
            forms.chamarFrm(contexto, consArt);
            consArt.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            consArt.metroStyleManager.Style = contexto.metroStyleManager.Style;
            mlblAvisos.Text = "";

            
           
        }

        private void mbtnMaisGenero_Click(object sender, EventArgs e)
        {
            frmGenero gen = new frmGenero(contexto,this);
            forms.chamarFrm(contexto, gen);
            gen.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            gen.metroStyleManager.Style = contexto.metroStyleManager.Style;
            
        }

        private void mbtnNovo_Click(object sender, EventArgs e)
        {
            limpar.limpar(mPanel);
            codArtista = 0;
           mbtnAtualizar.Visible = false;
           mbtnNovo.Visible = false;
           mbtnCadastrar.Visible = true;
           mlblAvisos.Text = "";

        }

        private void mbtnAtualizar_Click(object sender, EventArgs e)
        {
            if ((mtxtArtista.Text != "") && (mskTel.Text != ""))
            {
                art.atuaArtista(mtxtArtista.Text, mskTel.Text, mtxtEmail.Text, mcboGenero.Text, mtxtEmpresario.Text,codArtista, mPanel, contexto);
                mbtnAtualizar.Visible = false;
                mbtnNovo.Visible = false;
                mbtnCadastrar.Visible = true;
                mlblAvisos.Text = "";

            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios!";
            }
        }

        
    }
}

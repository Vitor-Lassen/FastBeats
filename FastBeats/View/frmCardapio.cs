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
using FastBeats.Utilities;


namespace FastBeats.View
{
    public partial class frmCardapio : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Cardapio card = new Cardapio();
        Temas temas = new Temas();
        Limpar limpar = new Limpar();
        PropriedadesTextBox propTXT = new PropriedadesTextBox();

        
        public frmCardapio(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
        }

        public frmCardapio()
        {
            // TODO: Complete member initialization
        }

        private void frmCardapio_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            propTXT.aplicarDinheiro(mtxtPrecoProd);
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
            if ((mtxtNomeProd.Text != ""))
            {
                propTXT.tirarMascara(mtxtPrecoProd);
                card.cadCardapio(mtxtNomeProd.Text, mtxtPrecoProd.Text, mPanel, contexto);
                mlblAviso.Text = "";


            }
            else
            {
                mlblAviso.Text = "Os campos com * são obrigatórios!";
            }
        }

        private void mbtnAtualizar_Click(object sender, EventArgs e)
        {
            if ((mtxtNomeProd.Text != "") && (mtxtPrecoProd.Text != ""))
            {
                propTXT.tirarMascara(mtxtPrecoProd);
                card.atuaCardapio(mtxtNomeProd.Text, mtxtPrecoProd.Text, Convert.ToInt32(mtxtCod.Text), mPanel, contexto);
                mbtnAtualizar.Visible = false;
                mbtnNovo.Visible = false;
                mbtnCadastrar.Visible = true;
                mtxtCod.Visible = false;
                mlblCod.Visible = false;
                mlblAviso.Text = "";


            }
            else
            {
                mlblAviso.Text = "Os campos com * são obrigatórios!";
            }
        }

        private void mbtnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarCardapio consCard = new frmConsultarCardapio(contexto, this);
            forms.chamarFrm(contexto, consCard);
            consCard.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            consCard.metroStyleManager.Style = contexto.metroStyleManager.Style;
            mlblAviso.Text = "";


        }

    
        private void mbtnNovo_Click(object sender, EventArgs e)
        {
            limpar.limpar(mPanel);

            mbtnAtualizar.Visible = false;
            mbtnNovo.Visible = false;
            mbtnCadastrar.Visible = true;
            mtxtCod.Visible = false;
            mlblCod.Visible = false;
            mlblAviso.Text = "";

        }  
    }
}

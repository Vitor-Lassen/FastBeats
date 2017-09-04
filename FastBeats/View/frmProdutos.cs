using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastBeats.Utilities;
using FastBeats.DB;
namespace FastBeats.View
{
    public partial class frmProdutos : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Produto prod = new Produto();
        Limpar limpar = new Limpar();
        PropriedadesTextBox propTXT = new PropriedadesTextBox();
        
        public frmProdutos(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
        }

        public frmProdutos()
        {
            // TODO: Complete member initialization
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            propTXT.aplicarDinheiro(mtxtPrecoCusto);
            propTXT.aplicarDinheiro(mtxtPrecoVenda);
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
            try
            {
                if ((mtxtCodigo.Text != "") && (mtxtPrecoVenda.Text != ""))
                {
                    propTXT.tirarMascara(mtxtPrecoCusto);
                    propTXT.tirarMascara(mtxtPrecoVenda);
                    prod.cadProd(Convert.ToInt32(mtxtCodigo.Text), mtxtNome.Text, Convert.ToInt32(mtxtQuantidade.Text), Convert.ToInt32(mtxtQuantidadeMin.Text), mtxtPrecoCusto.Text, mtxtPrecoVenda.Text, mPanel, contexto);
                    mlblAvisos.Text = "";


                }
                else
                {
                    mlblAvisos.Text = "Os campos com * são obrigatórios!";
                }
            }
            catch
            {
                mlblAvisos.Text = "Código já cadastrado!";
            }
        }

        private void mbtnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos consProd = new frmConsultarProdutos(contexto, this);
            forms.chamarFrm(contexto, consProd);
            consProd.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            consProd.metroStyleManager.Style = contexto.metroStyleManager.Style;
            mlblAvisos.Text = "";

            
        }

        private void mbtnAlterar_Click(object sender, EventArgs e)
        {
            if ((mtxtCodigo.Text != "") && (mtxtPrecoVenda.Text != ""))
            {
                propTXT.tirarMascara(mtxtPrecoCusto);
                propTXT.tirarMascara(mtxtPrecoVenda);
                prod.atuaProd(mtxtNome.Text, Convert.ToInt32(mtxtQuantidade.Text), Convert.ToInt32(mtxtQuantidadeMin.Text),mtxtPrecoCusto.Text, mtxtPrecoVenda.Text, Convert.ToInt32(mtxtCodigo.Text), mPanel, contexto);
                limpar.limpar(mPanel);
                mtxtCodigo.ReadOnly = false;
                mbtnAlterar.Visible = false;
                mbtnNovo.Visible = false;
                mbtnCadastrar.Visible = true;
                mlblAvisos.Text = "";

            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios!";
            }
        }

        private void mbtnNovo_Click(object sender, EventArgs e)
        {
            limpar.limpar(mPanel);
            mtxtCodigo.ReadOnly = false;
            mbtnAlterar.Visible = false;
            mbtnNovo.Visible = false;
            mbtnCadastrar.Visible = true;
            mlblAvisos.Text = "";

        }

        private void mtxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            propTXT.somenteNum(e);
        }

        

        private void mtxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            propTXT.somenteNum(e);
        }

        private void mtxtQuantidadeMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            propTXT.somenteNum(e);
        }

     

   


       

       
    }
}

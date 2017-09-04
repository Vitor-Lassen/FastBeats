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
    public partial class frmFuncionario : MetroFramework.Forms.MetroForm
    {
        string arquivo = "";   
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        FunLoginTema flt = new FunLoginTema();
        Limpar limpar = new Limpar();
        public frmFuncionario(frmPrincipal contexto)
        {
            this.contexto = contexto;

            InitializeComponent();
            this.StyleManager = metroStyleManager;
        }

        public frmFuncionario()
        {
            
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {

            forms.correcaoInicialForm(this);


            temas.temaComponente(mskCPF, contexto.numTema);
            temas.temaComponente(mskTel, contexto.numTema);
            temas.temaComponente(mskCel, contexto.numTema);
            
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
            if ((mskCPF.Text != "") && (mtxtRG.Text != "") && (mtxtNome.Text != "") && (mtxtEmail.Text != ""))
            {
                 int ativo;
                if (mtglAtivo.Checked)
                {
                    ativo = 1;
                    mlblAvisos.Text = "";

                }
                else
                {
                    ativo = 0;
                }
                    
                flt.cadFuncionario(mskCPF.Text, mtxtNome.Text, mtxtEnd.Text, mskTel.Text, mskCel.Text, mtxtRG.Text, mtxtEmail.Text, mtxtCargo.Text, mdtmNascimento.Text, arquivo,mtxtLogin.Text, mtxtSenha.Text, mcboAcesso.SelectedIndex,ativo, mPanel, contexto);               
               
               
            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios!";
            }
            }
           catch
           {
               mlblAvisos.Text = "CPF Já Cadastrado!";

           }
        }




        private void mtxtRG_TextChanged(object sender, EventArgs e)
        {
            if (mtxtRG.Text.Length > 20)
            {
                MessageBox.Show("Caracteres excedidos!");
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            this.openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
            arquivo = openFileDialog.FileName;
            
            try
            {
                picFoto.Image = Image.FromFile(arquivo);
            }
            catch 
            {

            }
           
            
  
        }

        private void mbtnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario consFunc= new frmConsultarFuncionario(contexto, this);
            forms.chamarFrm(contexto, consFunc);
            consFunc.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            consFunc.metroStyleManager.Style = contexto.metroStyleManager.Style;
            mlblAvisos.Text = "";

        }

        private void mbtnAtualizar_Click(object sender, EventArgs e)
        {
            if ((mskCPF.Text != "") && (mtxtRG.Text != "") && (mtxtNome.Text != "") && (mtxtEmail.Text != ""))
            {
                mlblAvisos.Text = "";

                int ativo;
                if (mtglAtivo.Checked)
                {
                    ativo = 1;
                }
                else
                {
                    ativo = 0;
                }

                flt.atuaFuncionario(mskCPF.Text, mtxtNome.Text, mtxtEnd.Text, mskTel.Text, mskCel.Text, mtxtRG.Text, mtxtEmail.Text, mtxtCargo.Text, mdtmNascimento.Text, arquivo, mtxtLogin.Text, mtxtSenha.Text, mcboAcesso.SelectedIndex, ativo, mPanel, contexto);
                limpar.limpar(mPanel);
                limpar.limpar(mPanel2);
                mskCPF.ReadOnly = false;
                mtxtLogin.ReadOnly = false;
                mbtnAtualizar.Visible = false;
                mbtnNovo.Visible = false;
                mbtnCadastrar.Visible = true;
                picFoto.Image = FastBeats.Properties.Resources.Funcionarios;

            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios!";
            }
        }

        private void mbtnNovo_Click(object sender, EventArgs e)
        {
            limpar.limpar(mPanel);
            limpar.limpar(mPanel2);
            
            mskCPF.ReadOnly = false;
            mtxtLogin.ReadOnly = false;
            mbtnAtualizar.Visible = false;
            mbtnNovo.Visible = false;
            mbtnCadastrar.Visible = true;
            mlblAvisos.Text = "";
            picFoto.Image = FastBeats.Properties.Resources.Funcionarios;

        } 
    }
}

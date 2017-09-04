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
    public partial class frmClientes : MetroFramework.Forms.MetroForm
    {

        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Cliente cli = new Cliente();
        Limpar limpar = new Limpar();
        public frmClientes(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;          
            this.StyleManager = metroStyleManager;
        }

        public frmClientes()
        {
            
        }

        private void Clientes_Load(object sender, EventArgs e)
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
                if ((mskCPF.Text != "") && (mtxtNome.Text != ""))
                {
                    cli.cadCliente(mskCPF.Text, mtxtNome.Text, mtxtRG.Text, mskTel.Text, mskCel.Text, mPanel, contexto);
                    limpar.limpar(mPanel);
                    mlblAvisos.Text = "";
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

        private void mbtnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarCliente consCli = new frmConsultarCliente(contexto, this);
            forms.chamarFrm(contexto, consCli);
            consCli.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            consCli.metroStyleManager.Style = contexto.metroStyleManager.Style;
            mlblAvisos.Text = "";

        }

        private void mbtnNovo_Click(object sender, EventArgs e)
        {
            limpar.limpar(mPanel);
            mskCPF.ReadOnly = false;
            mbtnAtualizar.Visible = false;
            mbtnNovo.Visible = false;
            mbtnCadastrar.Visible = true;
            mlblAvisos.Text = "";

        }

        private void mbtnAtualizar_Click(object sender, EventArgs e)
        {
            if ((mskCPF.Text != "") && (mtxtNome.Text != ""))
            {
                cli.atuaCliente(mskCPF.Text, mtxtNome.Text, mtxtRG.Text, mskTel.Text, mskCel.Text, mPanel, contexto);
                limpar.limpar(mPanel);
                mskCPF.ReadOnly = false;
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

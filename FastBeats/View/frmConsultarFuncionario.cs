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
    public partial class frmConsultarFuncionario : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        FunLoginTema flt = new FunLoginTema();
        frmFuncionario contextoFunc = new frmFuncionario();
        public frmConsultarFuncionario(frmPrincipal contexto,frmFuncionario contextoFunc)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.contextoFunc = contextoFunc;
            this.StyleManager = metroStyleManager;
        }

        private void frmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            temas.temaComponente(mskCPF, contexto.numTema);
            mtxtNome_TextChanged(sender, e);
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
           
            Close();
            forms.retornarFrm(contexto);
        }

        private void mtxtNome_TextChanged(object sender, EventArgs e)
        {
            mdgvFuncionarios.DataSource = flt.consFuncionario(mtxtNome.Text).Tables[0];
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            mdgvFuncionarios.DataSource = flt.consFuncionarioCPF(mskCPF.Text).Tables[0];
        }

        private void mdgvFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            contextoFunc.mskCPF.ReadOnly = true;
            contextoFunc.mskCPF.Text = mdgvFuncionarios.CurrentRow.Cells[0].Value.ToString();
            contextoFunc.mtxtNome.Text = mdgvFuncionarios.CurrentRow.Cells[1].Value.ToString();
            contextoFunc.mtxtEnd.Text = mdgvFuncionarios.CurrentRow.Cells[2].Value.ToString();
            contextoFunc.mskTel.Text = mdgvFuncionarios.CurrentRow.Cells[3].Value.ToString();
            contextoFunc.mskCel.Text = mdgvFuncionarios.CurrentRow.Cells[4].Value.ToString();
            contextoFunc.mtxtRG.Text = mdgvFuncionarios.CurrentRow.Cells[5].Value.ToString();
            contextoFunc.mtxtEmail.Text = mdgvFuncionarios.CurrentRow.Cells[6].Value.ToString();
            contextoFunc.mtxtCargo.Text = mdgvFuncionarios.CurrentRow.Cells[7].Value.ToString();
            contextoFunc.mdtmNascimento.Text = mdgvFuncionarios.CurrentRow.Cells[8].Value.ToString();
            contextoFunc.picFoto.ImageLocation = flt.consLocalFoto(mdgvFuncionarios.CurrentRow.Cells[0].Value.ToString());
            DataSet ds = new DataSet();
            ds = flt.consLogin(mdgvFuncionarios.CurrentRow.Cells[0].Value.ToString());
            contextoFunc.mtxtLogin.ReadOnly = true;
            contextoFunc.mtxtLogin.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            contextoFunc.mtxtSenha.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            contextoFunc.mcboAcesso.SelectedIndex = Convert.ToInt16( ds.Tables[0].Rows[0].ItemArray[2].ToString());
            contextoFunc.mtglAtivo.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[4].ToString());
            contextoFunc.mbtnAtualizar.Visible = true;
            contextoFunc.mbtnNovo.Visible = true;
            contextoFunc.mbtnCadastrar.Visible = false;
            Close();
            forms.retornarFrm(contexto);
        }

        private void mtxtNome_Enter(object sender, EventArgs e)
        {
            mskCPF.Clear();
        }

        private void mskCPF_Enter(object sender, EventArgs e)
        {
            mtxtNome.Clear();
        }

       
    }
}

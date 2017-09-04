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
    public partial class frmRelatorios : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Limpar limpar = new Limpar();
        Produto prod = new Produto();
        Comanda coman = new Comanda();
        Caixa caixa = new Caixa();
        FunLoginTema flt = new FunLoginTema();

        DataSet ds = new DataSet();
        public frmRelatorios(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;

        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            mdgvRProduto.DataSource = prod.produtoEmFalta().Tables[0];
            mdgvRComanda.DataSource = coman.comandasAtivas().Tables[0];

            mdtpData_ValueChanged(sender, e);
            mchbConsulta_CheckedChanged(sender, e);

            temas.temaComponente(cboFuncionario, contexto.numTema);
            cboFuncionario.DataSource = flt.consFuncionario().Tables[0];
            cboFuncionario.DisplayMember = "NOME_FUNC";
            cboFuncionario.ValueMember = "CPF_FUNC";
            
        }

        private void metroTileLogoff_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal(contexto);

            forms.chamarFrm(contexto, voltar);
            voltar.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            voltar.metroStyleManager.Style = contexto.metroStyleManager.Style;
            this.Close();
        }

        private void mtxtCodComanda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mdgvRComanda.DataSource = coman.comandasAtivas(Convert.ToInt32(mtxtCodComanda.Text)).Tables[0];
            }
            catch { }
        }
        private void preencheDGV()
        {
                mdgvRCaixa.DataSource = ds.Tables[0];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    mdgvRCaixa.Rows[i].Cells[1].Value = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[1].ToString()).ToString("#.00");
                }
                decimal valor = 0, valorTotal = 0;
                for (int i = 0; i < mdgvRCaixa.Rows.Count; i++)
                {
                    valor = Convert.ToDecimal(mdgvRCaixa.Rows[i].Cells[1].Value);
                    valorTotal += valor;
                }
                mtxtTotal.Text = valorTotal.ToString();
                mtxtTotal.Text = double.Parse(mtxtTotal.Text).ToString("C2");
        }
        private void mdtpData_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((mchbConsulta.Checked) && (mchbFun.Checked == false))
                {

                    ds = caixa.consCaixa(mdtpData.Value, mdtpDataFim.Value);
                    preencheDGV();

                }
                else if ((mchbConsulta.Checked == false) && (mchbFun.Checked == false))
                {
                    ds = caixa.consCaixa(mdtpData.Value, mdtpData.Value);
                    preencheDGV();
                }
                else if ((mchbConsulta.Checked) && (mchbFun.Checked))
                {

                    ds = caixa.consCaixa(mdtpData.Value, mdtpDataFim.Value, cboFuncionario.SelectedValue.ToString());
                    preencheDGV();

                }
                else if ((mchbConsulta.Checked == false) && (mchbFun.Checked))
                {
                    ds = caixa.consCaixa(mdtpData.Value, mdtpData.Value, cboFuncionario.SelectedValue.ToString());
                    preencheDGV();
                }
            }
            catch { }
        }

        private void mdtpDataFim_ValueChanged(object sender, EventArgs e)
        {
            mdtpData_ValueChanged(sender, e);
        }

        private void mchbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (mchbConsulta.Checked)
            {
                mlblConsulta.Text = "Consultar por Período";
                mlblDatafim.Visible = true;
                mdtpDataFim.Visible = true;
                mlblData.Text = "Data Início:";

            }
            else
            {
                mlblConsulta.Text = "Consultar por Data";
                mlblDatafim.Visible = false;
                mdtpDataFim.Visible = false;
                mlblData.Text = "Data:";
            }
        }

        private void mchbFun_CheckedChanged(object sender, EventArgs e)
        {
            if (mchbFun.Checked)
            {
                mlblFun.Visible = true;
                cboFuncionario.Visible = true;
                cboFuncionario.SelectedIndex = -1;
            }
            else
            {
                mlblFun.Visible = false;
                cboFuncionario.Visible = false;
                cboFuncionario.SelectedIndex = -1;
                mdtpData_ValueChanged(sender, e);
            }
        }

        private void cboFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            mdtpData_ValueChanged(sender, e);
        }    
    }
}

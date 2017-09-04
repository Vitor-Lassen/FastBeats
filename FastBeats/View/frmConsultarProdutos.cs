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
using FastBeats.Utilities;


using FastBeats.DB;
using System.Data.SqlClient;


namespace FastBeats.View
{
    public partial class frmConsultarProdutos : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Produto prod = new Produto();
        Limpar limpar = new Limpar();
        frmProdutos contextoProd = new frmProdutos();
        PropriedadesTextBox propTxt = new PropriedadesTextBox();
        DataSet ds = new DataSet();
        public frmConsultarProdutos(frmPrincipal contexto, frmProdutos contextoProd)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.contextoProd = contextoProd;
            this.StyleManager = metroStyleManager;
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            Close();
            forms.retornarFrm(contexto);
        }


    

        private void mtxtCodigo_TextChanged(object sender, EventArgs e)

        {
            if (mtxtCodigo.Text != "")
            {

            ds = prod.consProdCod(Convert.ToInt32(mtxtCodigo.Text));
            preencheDGV();
            }
         }

        private void mtxtNome_TextChanged(object sender, EventArgs e)
        {
            ds = prod.consProdNome(mtxtNome.Text);
            preencheDGV();
        }
        private void preencheDGV()
        {
            mdgvProdutos.DataSource = ds.Tables[0];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                mdgvProdutos.Rows[i].Cells[4].Value = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[4].ToString()).ToString("#.00");
                mdgvProdutos.Rows[i].Cells[5].Value = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[5].ToString()).ToString("#.00");
            }
            
        }

        private void frmConsultarProdutos_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            mtxtNome_TextChanged(sender, e);

        }

        private void mtxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            propTxt.somenteNum(e);
        }

        private void mdgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            contextoProd.mtxtCodigo.ReadOnly = true;
            contextoProd.mtxtCodigo.Text = mdgvProdutos.CurrentRow.Cells[0].Value.ToString();
            contextoProd.mtxtNome.Text = mdgvProdutos.CurrentRow.Cells[1].Value.ToString();
            contextoProd.mtxtQuantidadeMin.Text = mdgvProdutos.CurrentRow.Cells[3].Value.ToString();
            contextoProd.mtxtQuantidade.Text = mdgvProdutos.CurrentRow.Cells[2].Value.ToString();
            contextoProd.mtxtPrecoCusto.Text = mdgvProdutos.CurrentRow.Cells[4].Value.ToString();
            contextoProd.mtxtPrecoCusto.Text = double.Parse(contextoProd.mtxtPrecoCusto.Text).ToString("C2");
            contextoProd.mtxtPrecoVenda.Text = mdgvProdutos.CurrentRow.Cells[5].Value.ToString();
            contextoProd.mtxtPrecoVenda.Text = double.Parse(contextoProd.mtxtPrecoVenda.Text).ToString("C2");

            contextoProd.mbtnAlterar.Visible = true;
            contextoProd.mbtnNovo.Visible = true;
            contextoProd.mbtnCadastrar.Visible = false;
            Close();
            forms.retornarFrm(contexto);
        }
    }
}

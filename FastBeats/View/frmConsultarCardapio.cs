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
using System.Data.SqlClient;
using FastBeats.Utilities;



namespace FastBeats.View
{
    public partial class frmConsultarCardapio : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Cardapio card = new Cardapio();
        Limpar limpar = new Limpar();
        frmCardapio contextoCard = new frmCardapio();
        PropriedadesTextBox propTxt = new PropriedadesTextBox();
        DataSet ds = new DataSet();
        

        public frmConsultarCardapio(frmPrincipal contexto, frmCardapio contextoCard)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.contextoCard = contextoCard;
            this.StyleManager = metroStyleManager;

        }

        private void frmConsultarCardapio_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            mtxtProduto_TextChanged(sender, e);

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

                ds= card.consCardCod(Convert.ToInt32(mtxtCodigo.Text));
                preencheDGV();
            }
        }

        private void mtxtProduto_TextChanged(object sender, EventArgs e)
        {
           ds = card.consCardProd(mtxtProduto.Text);
           preencheDGV();
        }
        private void preencheDGV()
        {
            mdgvCardapio.DataSource = ds.Tables[0];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                mdgvCardapio.Rows[i].Cells[2].Value = Convert.ToDecimal(ds.Tables[0].Rows[i].ItemArray[2].ToString()).ToString("#.00");
            }

        }

     
        private void mtxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            propTxt.somenteNum(e);
        }

        private void mdgvCardapio_DoubleClick(object sender, EventArgs e)
        {
            contextoCard.mtxtCod.Text = mdgvCardapio.CurrentRow.Cells[0].Value.ToString();
            contextoCard.mtxtNomeProd.Text = mdgvCardapio.CurrentRow.Cells[1].Value.ToString();
            contextoCard.mtxtPrecoProd.Text = mdgvCardapio.CurrentRow.Cells[2].Value.ToString();
            contextoCard.mtxtPrecoProd.Text = double.Parse(contextoCard.mtxtPrecoProd.Text).ToString("C2");
            contextoCard.mbtnAtualizar.Visible = true;
            contextoCard.mbtnNovo.Visible = true;
            contextoCard.mbtnCadastrar.Visible = false;
            contextoCard.mtxtCod.Visible = true;
            contextoCard.mlblCod.Visible = true;
            Close();
            forms.retornarFrm(contexto);
        }

       
    }
}

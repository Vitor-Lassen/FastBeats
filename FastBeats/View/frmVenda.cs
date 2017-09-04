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
using MetroFramework;

namespace FastBeats.View
{
    
    public partial class frmVenda : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Produto prod = new Produto();
        Cardapio card = new Cardapio();
        PropriedadesTextBox proptxt = new PropriedadesTextBox();
        itemVenda iVenda = new itemVenda();
        Comanda Coman = new Comanda();
        Limpar limpar = new Limpar();
       
        public frmVenda(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
        }

        private void mtxtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                mbtnAdd_Click(sender, e);
            }
            proptxt.somenteNum(e);
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal(contexto);

            forms.chamarFrm(contexto, voltar);
            voltar.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            voltar.metroStyleManager.Style = contexto.metroStyleManager.Style;
            this.Close();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            temas.temaComponente(cboNome, contexto.numTema);
        }

        private void mbtnAdd_Click(object sender, EventArgs e)
        {
            if (mtxtQuantidade.Text != "")
            {
                for (int i = 0; i < Convert.ToInt16(mtxtQuantidade.Text); i++)
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        if (mrdbProd.Checked)
                        {

                            ds = prod.consProdCod(Convert.ToInt32(mtxtCod.Text));
                            mdgvItensVenda.Rows.Add(ds.Tables[0].Rows[0].ItemArray[0].ToString(), null, ds.Tables[0].Rows[0].ItemArray[1].ToString(), Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[5].ToString()).ToString("#.00"));
                        }
                        else if (mrdbCardapio.Checked)
                        {

                            ds = card.consCardCod(Convert.ToInt32(mtxtCod.Text));
                            mdgvItensVenda.Rows.Add(null, ds.Tables[0].Rows[0].ItemArray[0].ToString(), ds.Tables[0].Rows[0].ItemArray[1].ToString(), Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[2].ToString()).ToString("#.00"));

                        }
                        mlblAviso.Text = "";
                        
                    }
                    catch
                    {
                        mlblAviso.Text = "Produto Não Cadastrado!";
                    }
                    double valorTotal = 0, valor = 0;
                    for (int j = 0; j < mdgvItensVenda.Rows.Count; j++)
                    {
                        valor = Convert.ToDouble(mdgvItensVenda.Rows[j].Cells[3].Value);
                        valorTotal += valor;
                        mtxtTotal.Text = valorTotal.ToString();
                        
                    }
                    mtxtTotal.Text = double.Parse(mtxtTotal.Text).ToString("C2");
                
            }
            }
            else
            {
                mlblAviso.Text = "Digite a Quantidade.";
            }
        }

        private void mtxtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            proptxt.somenteNum(e);
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cboNome.DataSource = prod.consProd().Tables[0];
            cboNome.DisplayMember = "NOME_PRODUTO";
            cboNome.ValueMember = "COD_PRODUTO";
            mtxtCod.Clear();
            cboNome.SelectedIndex = -1;
        }

        private void mrdbCardapio_CheckedChanged(object sender, EventArgs e)
        {
            cboNome.DataSource = card.consCard().Tables[0];
            cboNome.DisplayMember = "Nome do Produto";
            cboNome.ValueMember = "Código do Produto";
            mtxtCod.Clear();
            cboNome.SelectedIndex = -1;
            
        }

        private void cboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                    mtxtCod.Text = cboNome.SelectedValue.ToString();
                
                
            }
            catch { }
        }
        
        private void mtxtCod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (mrdbCardapio.Checked)
                {
                    card.consCardCod(Convert.ToInt32(mtxtCod.Text));
                }
                else if (mrdbProd.Checked)
                {

                    prod.consNomeProd(Convert.ToInt32(mtxtCod.Text));
                }
            }
            catch { }
        }

        private void mbtnFinalizar_Click(object sender, EventArgs e)
        {
            if (mtxtComanda.Text != "")
            {
                int codUtilidadeComanda = Coman.codUtilidadeComanda(Convert.ToInt32(mtxtComanda.Text));
                if (codUtilidadeComanda == 0)
                {
                    mlblAviso.Text = "Comanda Inativa.";
                }
                else
                {



                    int i = 1;
                    while (i <= mdgvItensVenda.Rows.Count)
                    {
                        iVenda.cadItemVenda(
                            Convert.ToInt32(codUtilidadeComanda),
                            contexto.cpf,
                            Convert.ToInt32(mdgvItensVenda.Rows[0].Cells[1].Value),
                            Convert.ToInt32(mdgvItensVenda.Rows[0].Cells[0].Value)
                            );
                        if (mdgvItensVenda.Rows[0].Cells[0].Value != null)
                        {
                            prod.retirarProduto(Convert.ToInt32(mdgvItensVenda.Rows[0].Cells[0].Value), 1);
                        }

                        mdgvItensVenda.Rows.RemoveAt(0);

                    }
                    MetroMessageBox.Show(contexto, "venda a comanda " + mtxtComanda.Text + " Realizada com sucesso.", "Venda Concluida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar.limpar(mPanel);
                    mlblAviso.Text = "";
                    mtxtQuantidade.Text = "1";
                }
            }

        }

        private void cboNome_TextChanged(object sender, EventArgs e)
        {
            mtxtCod.Clear();
        }


}
}
